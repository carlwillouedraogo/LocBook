<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Str;

class GenreLivreSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('genre_livre')->insert([
            'gen_nom' => 'Policier',
        ]);

        DB::table('genre_livre')->insert([
            'gen_nom'=> 'Science-Fiction',
        ]);

        DB::table('genre_livre')->insert([
            'gen_nom'=> 'Fantastique',
        ]);
    }
}
