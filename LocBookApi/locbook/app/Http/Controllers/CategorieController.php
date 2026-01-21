<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class CategorieController extends Controller
{
    /**
     * Récupérer les catégories d'ouvrages
     */
    function getCategorie(){
        $categorie = DB::table('categorie')
        ->select('cat_nom')
        ->get();
        return response()->json($categorie);
    }
}
