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

        Schema::create('ouvrage', function (Blueprint $table) {
            $table->bigInteger('ouv_id')->primary()->autoIncrement()->unsigned();
            $table->string('ouv_titre');
            $table->double('ouv_prix');
            $table->integer('ouv_stock');
            $table->string('ouv_auteur');
            $table->unsignedBigInteger('ouv_bib_id');
            $table->foreign('ouv_bib_id')->references('bib_id')->on('bibliotheque');
            $table->unsignedBigInteger('ouv_cat_id');
            $table->foreign('ouv_cat_id')->references('cat_id')->on('categorie');
            $table->unsignedBigInteger('ouv_gen_id');
            $table->foreign('ouv_gen_id')->references('gen_id')->on('genre_livre');
            $table->timestamps();
        });

        Schema::enableForeignKeyConstraints();
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('ouvrage');
    }
};
