<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Str;

class CategorieSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('categorie')->insert([
            'cat_nom' => 'Roman',
        ]);

        DB::table('categorie')->insert([
            'cat_nom'=> 'BD',
        ]);

        DB::table('categorie')->insert([
            'cat_nom'=> 'Manga',
        ]);

    }
}
