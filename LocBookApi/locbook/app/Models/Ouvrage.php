<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\DB;

class Ouvrage extends Model
{
    use HasFactory;
    // Définir le nom de la table associée au modèle
    protected $fillable = [
        // Définir les champs pouvant être assignés
        'ouv_titre',
        'ouv_prix',
        'ouv_auteur',
        'ouv_stock',
        'ouv_bib_id',
        'ouv_cat_id',
        'ouv_gen_id',
    ];

}
