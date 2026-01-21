<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class MembreSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('membre')->insert([
            'mem_nom' => 'thim',
            'mem_prenom' => 'sull',
            'mem_age' => '50',
            'mem_use_id' => 1,
        ]);
    }
}
