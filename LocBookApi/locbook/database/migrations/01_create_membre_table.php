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
        Schema::create('membre', function (Blueprint $table) {
            $table->bigInteger('mem_id')->primary()->autoIncrement()->unsigned();
            $table->string('mem_nom');
            $table->string('mem_prenom');
            $table->integer('mem_age');
            $table->bigInteger('mem_use_id')->unsigned();
            $table->foreign('mem_use_id')->references('id')->on('users');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('membre');
    }
};
