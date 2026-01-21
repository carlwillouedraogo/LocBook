<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::disableForeignKeyConstraints();

        Schema::create('reservation', function (Blueprint $table) {
            $table->unsignedBigInteger('res_use_id');
            $table->foreign('res_use_id')->references('id')->on('users');
            $table->unsignedBigInteger('res_liv_id');
            $table->foreign('res_liv_id')->references('ouv_id')->on('ouvrage');
            $table->date('res_date_debut');
            $table->date('res_date_fin');
            $table->timestamps();
        });

        Schema::enableForeignKeyConstraints();
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('reservation');
    }
};
