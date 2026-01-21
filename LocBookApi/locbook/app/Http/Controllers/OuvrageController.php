<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Models\Ouvrage;
use App\Models\Administrateur;


class OuvrageController extends Controller
{
    /**
     * Récupérer les informations d'un ouvrage par son ID
     */
    public function getOuvrage(Request $request){
        $id = $request->input('id');
        $ouvrages = DB::table('ouvrage')
        ->join('categorie','ouvrage.ouv_cat_id','=','categorie.cat_id')
        ->join('genre_livre','ouvrage.ouv_gen_id','=','genre_livre.gen_id')
        ->join('bibliotheque','ouvrage.ouv_bib_id','=','bibliotheque.bib_id')
        ->where('ouv_id','like','%'.$id.'%')
        ->select('ouv_titre','ouv_prix','ouv_auteur','ouv_stock','gen_nom','ouv_id','bib_nom')
        ->get();
        return response()->json($ouvrages);
    }

    /**
     * Récupérer les informations d'un ouvrage par son nom
     */
    
    public function getOuvrageByName(Request $request){
        $name = $request->input('name');
        $ouvrages = DB::table('ouvrage')
        ->join('categorie','ouvrage.ouv_cat_id','=','categorie.cat_id')
        ->join('genre_livre','ouvrage.ouv_gen_id','=','genre_livre.gen_id')
        ->where('ouv_titre','like','%'.$name.'%')
        ->select('ouv_titre','ouv_auteur','cat_nom','gen_nom','ouv_id')
        ->get();
        return response()->json($ouvrages);
    }

    /**
     * Récupérer les ouvrages par catégorie et genre
     */


    public function getOuvrageByCatEtGen(Request $request){
        // Récupérer les paramètres de catégorie et de genre depuis la requête
        $category = $request->input('category');
        $genre = $request->input('genre');
        $query = DB::table('ouvrage')
        ->join('categorie','ouvrage.ouv_cat_id','=','categorie.cat_id')
        ->join('genre_livre','ouvrage.ouv_gen_id','=','genre_livre.gen_id');
        // Construire la requête en fonction des paramètres fournis
        if($query->exists()){
            // Appliquer les filtres selon les paramètres fournis
            if($category != null && $genre != null){
            $query ->where('cat_nom','like','%'.$category.'%')
                        ->where('gen_nom','like','%'.$genre.'%');
            }elseif($category != null && $genre == null){
                $query ->where('cat_nom','like','%'.$category.'%');
            }elseif($category == null && $genre != null){
                $query ->where('gen_nom','like','%'.$genre.'%');
            }
            $ouvrages = $query ->select('ouv_titre','ouv_auteur','cat_nom','gen_nom','ouv_id')
            ->get();
        }else{
            return response()->json('ouvrage not found');
    }
        return response()->json($ouvrages);
    }

    /**
     * Récupérer les ouvrages pour la page d'accueil
     */

    public function getOuvrageAccueil(){
        $ouvrages = DB::table('ouvrage')
        ->join('categorie','ouvrage.ouv_cat_id','=','categorie.cat_id')
        ->join('genre_livre','ouvrage.ouv_gen_id','=','genre_livre.gen_id')
        ->select('ouv_titre','ouv_prix','cat_nom','gen_nom','ouv_auteur','ouv_id')
        ->get();
        return response()->json($ouvrages);
    }

    /**
     * Ajouter un nouvel ouvrage
     */

    public function ajouterOuvrage(Request $request){
        // Vérifier si l'utilisateur est un administrateur
        $user = auth()->user();
        if($user->use_role == 'admin'){
        $bibliotheque = DB::table('bibliotheque')->where('bib_nom', $request->input('bibliotheque'))->first();
        // Créer la bibliothèque si elle n'existe pas
        if (!$bibliotheque) {
            $bibliothequeId = DB::table('bibliotheque')->insertGetId([
                'bib_nom' => $request->input('bibliotheque')
            ]);
        } else {
            $bibliothequeId = $bibliotheque->bib_id;
        }
        // Récupérer ou créer la catégorie
        $categorie = DB::table('categorie')->where('cat_nom', $request->input('categorie'))->first();
        // Créer la catégorie si elle n'existe pas
        if (!$categorie) {
            $categorieId = DB::table('categorie')->insertGetId([
                'cat_nom' => $request->input('categorie')
            ]);
        } else {
            $categorieId = $categorie->cat_id;
        }
        // Récupérer ou créer le genre
        $genre = DB::table('genre_livre')->where('gen_nom', $request->input('genre'))->first();
        // Créer le genre s'il n'existe pas
        if (!$genre) {
            $genreId = DB::table('genre_livre')->insertGetId([
                'gen_nom' => $request->input('genre')
            ]);
        } else {
            $genreId = $genre->gen_id;
        }
            $ouvrages = DB::table('ouvrage')->insert([
                'ouv_titre' => $request->input('titre'),
                'ouv_prix' => $request->input('prix'),
                'ouv_auteur' => $request->input('auteur'),
                'ouv_stock' => $request->input('stock'),
                'ouv_bib_id' => $bibliotheque->bib_id,
                'ouv_cat_id' => $categorie->cat_id,
                'ouv_gen_id' => $genre->gen_id,
            ]);
            return response()->json($ouvrages);   
        }else{
            return response()->json("vous n'êtes pas autorisé");
        }
    }

    /**
     * Mettre à jour un ouvrage
     */

    public function updateOuvrage(Request $request){
        $stock = $request->input('stock');
        $id = $request->input('id');
        $user = auth()->user();
        /*/ Vérifier si l'utilisateur est un administrateur */
         if ($user->use_role == 'admin') {
            // Récupérer ou créer la catégorie
            $categorie = DB::table('categorie')->where('cat_nom', $request->input('categorie'))->first();
            // Créer la catégorie si elle n'existe pas
            if (!$categorie) {
                $categorieId = DB::table('categorie')->insertGetId([
                    'cat_nom' => $request->input('categorie')
                ]);
            } else {
                $categorieId = $categorie->cat_id;
            }
            // Récupérer ou créer le genre
            $genre = DB::table('genre_livre')->where('gen_nom', $request->input('genre'))->first();
            // Créer le genre si il n'existe pas
            if (!$genre) {
                $genreId = DB::table('genre_livre')->insertGetId([
                    'gen_nom' => $request->input('genre')
                ]);
            } else {
                $genreId = $genre->gen_id;
            }
            // Mettre à jour l'ouvrage
            $query = DB::table('ouvrage')->where('ouv_id', $id);
            // Vérifier si l'ouvrage existe
            if ($query->exists()) {
                // Préparer les données à mettre à jour
                $updateData = [];
                // Mettre à jour la catégorie si fourni
                if ($categorieId) {
                    $updateData['ouv_cat_id'] = $categorieId;
                }
                // Mettre à jour le genre si fourni
                if ($genreId) {
                    $updateData['ouv_gen_id'] = $genreId;
                }
                // Mettre à jour le stock si fourni
                if ($stock !== null) {
                    $updateData['ouv_stock'] = $stock;
                }
                // Exécuter la mise à jour
                if (!empty($updateData)) {
                    $query->update($updateData);
                    return response()->json('Ouvrage updated successfully');
                } else {
                    return response()->json('No data to update', 400);
                }
            } else {
                return response()->json('Ouvrage not found', 404);
            }
        } else {
            return response()->json("Vous n'avez pas les droits", 403);
        }
    }
    /**
     * Supprimer un ouvrage
     */

    public function deleteOuvrage(Request $request){
        // Récupérer l'ID de l'ouvrage à supprimer
        $id = $request->input('id');
        // Récupérer l'utilisateur authentifié
        $user = auth()->user();
        $query = DB::table('ouvrage')
        ->where('ouv_id',$id);
        // Supprimer l'ouvrage si l'utilisateur est un administrateur
        if($user->use_role == "admin"){
            if($query->exists()){
                $query->delete();
            }else{
                return response()->json('ouvrage not found');
            }
        }else{
            return response()->json("vous n'avez pas les droits");
        }
    }
}
