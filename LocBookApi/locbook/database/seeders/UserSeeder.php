<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('users')->insert([
            'email' => 'thim@demo.com',
            'password' => Hash::make('password'),
            'use_role'=>'membre',
        ]);

        DB::table('users')->insert([
            'email' => 'thimo@demo.com',
            'password' => Hash::make('password1'),
            'use_role'=>'admin',
        ]);
    }
}
