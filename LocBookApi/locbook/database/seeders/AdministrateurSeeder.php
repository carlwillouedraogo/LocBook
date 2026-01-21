<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Str;

class AdministrateurSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('administrateur')->insert([
            'adm_nom' => 'thimo',
            'adm_prenom' => 'sulli',
            'adm_age' => '50',
            'adm_numeroEmploye' => '123456789',
            'adm_use_id' => 2,
        ]);
    }
}
