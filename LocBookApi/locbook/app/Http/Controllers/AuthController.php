<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Str;
use Illuminate\Support\Facades\Hash;
use App\Models\User;
use App\Models\Membre;
use App\Models\Administrateur;
use Illuminate\Support\Facades\DB;

class AuthController extends Controller
{
    /**
     * Authentifier un utilisateur et générer un token
     */
    public function auth(Request $request){
        $user = User::where('email', $request->email)->first();
        if(!$user || !Hash::check($request->password, $user->password)){
            return response([
                'message' => 'wrong user or password.'
            ]);
        }
        
        $token = $user->createToken(Str::random(10))->plainTextToken;
        $is_admin = $user->use_role === 'admin'; 
        return response([
            'token' => $token,
            'is_admin' => $is_admin
        ]);
    }


    /**
     * Déconnecter un utilisateur en supprimant ses tokens
     */

    public function logout(Request $request){
        $request->user()->tokens()->delete();
        return response([
            'message' => 'logout success.'
        ]);
    }

    /**
     * Enregistrer un nouvel utilisateur membre
     */

    public function register(Request $request){
        $user = new User([
            'email'=>$request->input('email'),
            'password'=>Hash::make($request->input('password')),
            'use_role'=>'membre',
        ]);
        $user->save();
        $membre = new Membre([
            'mem_nom' => $request->input('nom'),
            'mem_prenom' => $request->input('prenom'),
            'mem_age' => $request->input('age'),
            'mem_use_id' => $user->id
        ]);
        $membre->save();
        return response()->json($membre);
    }
    /**
     * Enregistrer un nouvel utilisateur administrateur
     */

    public function registerAdministrateur(Request $request){
        $user = new User([
            'email'=>$request->input('email'),
            'password'=>Hash::make($request->input('password')),
            'use_role'=>'admin',
        ]);
        $user->save();
        $admin = new Administrateur([
            'adm_nom' => $request->input('nom'),
            'adm_prenom' => $request->input('prenom'),
            'adm_age' => $request->input('age'),
            'adm_numeroEmploye' => $request->input('numeroEmploye'),
            'adm_use_id' => $user->id
        ]);
        $admin->save();
        return response()->json($admin);
    }

    /**
     * Mettre à jour les informations d'un membre connecté
     */

    function updateMembre(Request $request){
        $user = auth()->user();
        $email = $request->input('email');
        $motDePass = $request->input('password');
        if($user){
        $query = DB::table('users')
        ->where('id',$user->id);
        if ($query->exists()){
            $data = [];
            if($email != null){
                $data['email'] = $email;
            }if($motDePass != null){
                $data['password'] = Hash::make($motDePass);
            }
            if(!empty($data)){
                $query->update($data);
                return response()->json('user updated');
            }else{
                return response()->json('no data to update');
            }
        }else{
            return response()->json('user not found');
    }
        return response()->json(['message' => 'you are not allowed to update this user']);
    }
}
    /**
     * Mettre à jour les informations d'un administrateur connecté
     */

    function updateAdmin(Request $request){
        $user = auth()->user();
        $email = $request->input('email');
        $motDePass = $request->input('motDePass');
        $id = $request->input('id');

        if($user->id != $id){
            return response()->json('you are not allowed to update this user');
        }
        $query = DB::table('users')
        ->where('id',$id);
        if ($query->exists()){
            if($email != null && $motDePass != null){
                $query->update([
                    'email' => $email,
                    'password' => $motDePass,
                ]);
            }elseif($email != null && $motDePass == null){
                $query->update([
                    'email' => $email,
                ]);
            }elseif($email == null && $motDePass != null){
                $query->update([
                    'password' => $motDePass,
                ]);
            }
        }else{
            return response()->json('admin not found');
    }
        return response()->json($query);
    }

    /**
     * Mettre à jour le mot de passe d'un utilisateur ayant oublié son mot de passe
     */

    function updateMotPassOublie(Request $request){
    $email = $request->input('email');
    $newPassword = $request->input('password');

    $user = DB::table('users')->where('email', $email)->first();

    if ($user) {
        if (!is_null($newPassword)) {
            DB::table('users')
                ->where('email', $email)
                ->update([
                    'password' => Hash::make($newPassword),
                ]);
            return response()->json('User information updated successfully');
        } else {
            return response()->json('New password is required', 400);
        }
    } else {
        return response()->json('The email does not exist', 404);
    }
}
    
}
