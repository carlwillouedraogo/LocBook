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

        Schema::create('emprunt', function (Blueprint $table) {
            $table->unsignedBigInteger('emp_use_id');
            $table->foreign('emp_use_id')->references('id')->on('users');
            $table->unsignedBigInteger('emp_ouv_id');
            $table->foreign('emp_ouv_id')->references('ouv_id')->on('ouvrage');
            $table->date('emp_date_debut');
            $table->date('emp_date_fin');
            $table->timestamps();
        });

        Schema::enableForeignKeyConstraints();
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('emprunt');
    }
};
