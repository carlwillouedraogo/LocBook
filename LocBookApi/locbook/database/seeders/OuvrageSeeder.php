<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Str;
use Illuminate\Support\Integer;

class OuvrageSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {

        DB::table('ouvrage')->insert([
            'ouv_titre' => 'Le Seigneur des Anneaux',
            'ouv_prix' => rand(10, 100),
            'ouv_stock' => rand(10, 100),
            'ouv_auteur' => 'J.R.R. Tolkien',
            'ouv_bib_id' => 1,
            'ouv_cat_id' => 1,
            'ouv_gen_id' => 1,
            
        ]);

        DB::table('ouvrage')->insert([
            'ouv_titre' => 'Harry Potter',
            'ouv_prix' => rand(10, 100),
            'ouv_stock' => rand(10, 100),
            'ouv_auteur' => 'J.K. Rowling',
            'ouv_bib_id' => 1,
            'ouv_cat_id' => 2,
            'ouv_gen_id' => 2,
            
        ]);

        DB::table('ouvrage')->insert([
            'ouv_titre' => 'One Piece',
            'ouv_prix' => rand(10, 100),
            'ouv_stock' => rand(10, 100),
            'ouv_auteur' => 'Eiichiro Oda',
            'ouv_bib_id' => 1,
            'ouv_cat_id' => 3,
            'ouv_gen_id' => 3,
            
        ]);
        
    }
}
