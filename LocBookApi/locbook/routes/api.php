<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Models\Ouvrage;
use App\Http\Controllers\OuvrageController;
use App\Http\Controllers\MembreController;
use App\Models\Membre;
use App\Http\Controllers\ReservationController;
use App\Http\Controllers\EmpruntController;
use App\Http\Controllers\AchatController;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\AdminController;
use App\Http\Controllers\GenreController;
use App\Http\Controllers\CategorieController;

// la route protégée par le middleware 'auth:sanctum' pour récupérer l'utilisateur authentifié
Route::get('/user', function (Request $request) {
    return $request->user();
})->middleware('auth:sanctum');

// Routes publiques pour l'authentification
Route::post('/auth',[AuthController::class,'auth']);
Route::post('/register',[AuthController::class,'register']);
Route::post('/registerAdministrateur',[AuthController::class,'registerAdministrateur']);
// Route pour la réinitialisation du mot de passe
Route::put('/modifier/motdepasse',[AuthController::class,'updateMotPassOublie']);
// Routes protégées par le middleware 'auth:sanctum'
Route::group(['middleware' => ['auth:sanctum']],function(){
    // Routes pour la gestion des ouvrages
    Route::controller(OuvrageController::class)->group(function(){
        Route::get('/ouvrage/accueil',[OuvrageController::class,'getOuvrageAccueil']);
        Route::get('/ouvrage/bycatetgen',[OuvrageController::class,'getOuvrageByCatEtGen']);
        Route::get('/ouvrage/byname',[OuvrageController::class,'getOuvrageByName']);
        Route::get('/ouvrage',[OuvrageController::class,'getOuvrage']);
        Route::post('/ouvrage/ajouter',[OuvrageController::class,'ajouterOuvrage']);
        Route::put('/ouvrage/modifier',[OuvrageController::class,'updateOuvrage']);
        Route::delete('/ouvrage/supprimer',[OuvrageController::class,'deleteOuvrage']);
    });
    // Routes pour la gestion des membres et administrateurs
    Route::controller(MembreController::class)->group(function(){
        Route::get('/membre',[MembreController::class,'getMembre']);
    });
    // Routes pour la gestion des administrateurs
    Route::controller(AdminController::class)->group(function(){
        Route::get('/admin',[AdminController::class,'getAdmin']);
    });
    // Routes pour la gestion des réservations, emprunts et achats
    Route::controller(ReservationController::class)->group(function(){
        Route::get('/reservation',[ReservationController::class,'getReservation']);
        Route::post('/reservation/ajouter',[ReservationController::class,'ajouterReservation']);
    });
    // Routes pour la gestion des emprunts
    Route::controller(EmpruntController::class)->group(function(){
        Route::get('/emprunt',[EmpruntController::class,'getEmprunt']);
        Route::post('/emprunt/ajouter',[EmpruntController::class,'ajouterEmprunt']);
    });
    // Routes pour la gestion des achats
    Route::controller(AchatController::class)->group(function(){
        Route::get('/achat',[AchatController::class,'getAchat']);
        Route::post('/achat/ajouter',[AchatController::class,'ajouterAchat']);
    });
    // Routes pour la modification des profils membre et administrateur
    Route::controller(AuthController::class)->group(function(){
        Route::put('/modifier/membre',[AuthController::class,'updateMembre']);
        Route::put('/modifier/admin',[AuthController::class,'updateAdmin']);
    });
    // Routes pour récupérer les genres et catégories
    Route::get('/genre',[GenreController::class,'getGenre']);
    Route::get('/categorie',[CategorieController::class,'getCategorie']);
    // Route pour la déconnexion
    Route::post('/logout',[AuthController::class,'logout']);
});