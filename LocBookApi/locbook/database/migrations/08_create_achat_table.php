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

        Schema::create('achat', function (Blueprint $table) {
            $table->unsignedBigInteger('ach_use_id');
            $table->foreign('ach_use_id')->references('id')->on('users');
            $table->unsignedBigInteger('ach_ouv_id');
            $table->foreign('ach_ouv_id')->references('ouv_id')->on('ouvrage');
            $table->date('ach_date');
            $table->double('ach_prix');
            $table->timestamps();
        });

        Schema::enableForeignKeyConstraints();
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('achat');
    }
};
