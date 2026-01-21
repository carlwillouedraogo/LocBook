<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class GenreLivre extends Model
{
    use HasFactory;
    // Définir le nom de la table associée au modèle
    protected $fillable = [
        // Définir les champs pouvant être assignés
        'gen_id',
        'gen_nom',
    ];
}
