<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class EmpruntController extends Controller
{
    /**
     * Ajouter un nouvel emprunt
     */
    public function ajouterEmprunt(Request $request){
        $user = auth()->user();
        $emprunt = DB::table('emprunt')->insert([
            'emp_date_debut' => $request->input('date_debut'),
            'emp_date_fin' => $request->input('date_fin'),
            'emp_use_id' => $user->id,
            'emp_ouv_id' => $request->input('ouv_id'),
        ]);
        return response()->json($emprunt);
    }
    /**
     * Récupérer les emprunts de l'utilisateur connecté
     */
    public function getEmprunt(){
        $user = auth()->user();
        $emprunts = DB::table('emprunt')
        ->join('users','users.id','=','emprunt.emp_use_id')
        ->join('ouvrage','ouvrage.ouv_id','=','emprunt.emp_ouv_id')
        ->where('emp_use_id','=',$user->id)
        ->select('emp_date_debut','emp_date_fin','ouv_titre','ouv_prix')
        ->get();
        return response()->json($emprunts);
    }
}
