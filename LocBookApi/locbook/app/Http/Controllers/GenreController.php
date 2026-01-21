<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Models\GenreLivre;

class GenreController extends Controller
{
    /**
     * Récupérer les genres de livres
     */
    function getGenre(){
        $genre = DB::table('genre_livre')
        ->select('gen_nom')
        ->get();
        return response()->json($genre);
    }
}
