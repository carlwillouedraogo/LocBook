<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class Membre extends Model
{
    use HasFactory;
    // Définir le nom de la table associée au modèle
    protected $fillable = [
        // Définir les champs pouvant être assignés
        'mem_nom',
        'mem_prenom',
        'mem_age',
        'mem_use_id',
    ];

    protected $table = 'membre';

}
