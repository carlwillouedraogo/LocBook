<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Reservation;
use Illuminate\Support\Facades\DB;

class ReservationController extends Controller
{
    /**
     * Récupérer les réservations de l'utilisateur connecté
     */
    function getReservation(){
        $user = auth()->user();
        $reservation = DB::table('reservation')
        ->join('users','users.id','=','reservation.res_use_id')
        ->join('ouvrage','ouvrage.ouv_id','=','reservation.res_liv_id')
        ->where('res_use_id','=',$user->id)
        ->select('res_date_debut','res_date_fin','ouv_titre','ouv_prix','ouv_auteur')
        ->get();
        return response()->json($reservation);
    }

    /**
     * Ajouter une nouvelle réservation
     */

    function ajouterReservation(Request $request){
        $user = auth()->user();
        $reservation = DB::table('reservation')->insert([
            'res_date_debut' => $request->input('date_debut'),
            'res_use_id' => $user->id,
            'res_liv_id' => $request->input('livre'),
            'res_date_fin' => $request->input('date_fin'),
        ]);
        return response()->json($reservation);
    }
}
