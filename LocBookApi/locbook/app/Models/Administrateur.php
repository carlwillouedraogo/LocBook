<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Administrateur extends Model
{
    use HasFactory;
    // Définir le nom de la table associée au modèle
    protected $fillable = [
        // Définir les champs pouvant être assignés
        'adm_nom',
        'adm_prenom',
        'adm_age',
        'adm_numeroEmploye',
        'adm_use_id',
    ];

    protected $table = 'administrateur';
    

}
