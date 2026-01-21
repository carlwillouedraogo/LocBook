<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Membre;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class MembreController extends Controller
{
    /**
     * Récupérer les informations du membre connecté
     */
    function getMembre(){
        
        $user = auth()->user();
        if($user->id == $user->id){
            $membres = DB::table('membre')
            ->join('users','membre.mem_use_id','=','users.id')
            ->where('mem_use_id','like','%'.$user->id.'%')
            ->select('mem_nom','mem_prenom','mem_age','email')
            ->get();
            return response()->json($membres);
        }else{
            return response()->json('you are not allowed to access this resource');
       }
    }

    
}
