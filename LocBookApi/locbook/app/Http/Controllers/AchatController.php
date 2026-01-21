<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Models\Achat;

class AchatController extends Controller
{
    /**
     * Ajouter un nouvel achat
     */
    public function ajouterAchat(Request $request){
        $user = auth()->user();
        $achat = DB::table('achat')->insert([
            'ach_date' => $request->input('date'),
            'ach_use_id' => $user->id,
            'ach_ouv_id' => $request->input('ouv_id'),
            'ach_prix' => $request->input('prixAchat'),
        ]);
        return response()->json($achat);
    }
    /**
     * Récupérer les achats de l'utilisateur connecté
     */

    public function getAchat(){
        $user = auth()->user();
        $achats = DB::table('achat')
        ->join('users','users.id','=','achat.ach_use_id')
        ->join('ouvrage','ouvrage.ouv_id','=','achat.ach_ouv_id')
        ->where('ach_use_id','=',$user->id)
        ->select('ach_date','ouv_titre','ouv_prix')
        ->get();
        return response()->json($achats);
    }
}
