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

        Schema::create('administrateur', function (Blueprint $table) {
            $table->bigInteger('adm_id')->primary()->autoIncrement()->unsigned();
            $table->string('adm_nom');
            $table->string('adm_prenom');
            $table->integer('adm_age');
            $table->integer('adm_numeroEmploye');
            $table->bigInteger('adm_use_id')->unsigned();
            $table->foreign('adm_use_id')->references('id')->on('users');
            $table->timestamps();
        });

        Schema::enableForeignKeyConstraints();
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('administrateur');
    }
};
