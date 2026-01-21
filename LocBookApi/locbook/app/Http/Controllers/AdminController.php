<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class AdminController extends Controller
{
    /**
     * Récupérer les informations de l'administrateur connecté
     */
    function getAdmin(Request $request){
        $id = $request->input('id');
        $user = auth()->user();
        if($user->id != $id){
            return response()->json('you are not allowed to access this resource');
        }
        $admins = DB::table('admin')
        ->where('adm_use_id','=',$id)
        ->select('adm_nom','adm_prenom','adm_age')
        ->get();
        return response()->json($admins);
    }
}
