📚 LocBook

Application de gestion de location de livres
Backend Laravel (API REST) + Module applicatif C#

## Sommaire
- [Description](#description)
- [Architecture](#architecture)
- [Technologies utilisées](#technologies-utilisées)
- [Installation & Configuration](#installation--configuration)
- [API & Authentification](#api--authentification)
- [Fonctionnalités](#fonctionnalités)
- [Modélisation](#modélisation)
- [Contexte académique](#contexte-académique)
- [Remarques](#remarques)
- [Auteur](#auteur)


## description

LocBook est une application complète de gestion de location de livres développée dans le cadre de mon Bachelor en informatique de gestion à la Haute École de Gestion de Genève.

L’application permet de :

gérer un catalogue de livres

gérer les utilisateurs (membres et administrateurs)

enregistrer des emprunts, réservations et achats

suivre les disponibilités

interagir avec un backend Laravel via un module développé en C#

Le backend est une API REST, sécurisée via Laravel Sanctum, consommée par une application C#.

## architecture

Le projet est composé de deux parties :

1️⃣ Backend – Laravel (API REST)

Framework : Laravel

Authentification : Laravel Sanctum

Rôle :

gestion des ouvrages

gestion des membres et administrateurs

gestion des emprunts, réservations et achats

récupération des genres et catégories

authentification et gestion des profils

Accès aux données via des endpoints REST

Base de données : MySQL

2️⃣ Module applicatif – C# (Windows Forms)

Langage : C#

Plateforme : .NET Framework (Windows Forms)

Rôle :

interface graphique utilisateur

consommation de l’API Laravel

affichage et gestion des données

opérations CRUD

authentification utilisateur

## technologies utilisées
Backend

Laravel

PHP

MySQL

Laravel Sanctum (authentification API)

Module applicatif

C#

.NET

HTTP Client / API REST

Autres

UML

Git

## installation & configuration
🔹 Prérequis

PHP ≥ 8.x

Composer

MySQL

.NET (Framework ou .NET Core selon ton projet)

Serveur local (XAMPP, WAMP, Laragon, etc.)

🔹Configurer l’environnement :

cp .env.example .env
php artisan key:generate


Modifier le fichier .env :

DB_DATABASE=locbook
DB_USERNAME=root
DB_PASSWORD=


🔹 Backend Laravel (API REST)

Cloner le dépôt :

git clone https://github.com/carlwillouedraogo/locbook.git
cd locbook/backend


Installer les dépendances :

composer install


Créer le fichier d’environnement :

cp .env.example .env

Configurer la base de données dans .env :

DB_DATABASE=locbook
DB_USERNAME=root
DB_PASSWORD=


Créer les tables :

php artisan migrate

Ajouter des données de test :

php artisan db:seed


Lancer le serveur Laravel :

php artisan serve


🔹 Module C#

Ouvrir le projet dans Visual Studio

Vérifier la configuration de l’URL de l’API backend

⚠️ Par défaut, l’API backend est configurée sur :
http://127.0.0.1:8000/api


Lancer l’application C#

## api & authentification

Le backend expose une API REST pure sécurisée via Laravel Sanctum.

Exemples d’endpoints :

POST /api/auth – Authentification

POST /api/register – Inscription membre

GET /api/ouvrage – Liste des ouvrages

POST /api/ouvrage/ajouter – Ajouter un ouvrage

GET /api/emprunt – Liste des emprunts

POST /api/emprunt/ajouter – Ajouter un emprunt

GET /api/reservation – Liste des réservations

POST /api/reservation/ajouter – Ajouter une réservation

Toutes les routes métiers sont protégées par :

auth:sanctum

## fonctionnalités

📖 Gestion du catalogue de livres

👤 Gestion des membres et administrateurs

📅 Gestion des emprunts

📌 Gestion des réservations

💳 Gestion des achats

🔐 Authentification API (Laravel Sanctum)

🔄 Synchronisation C# ↔ Laravel

🗄️ Accès base de données MySQL

📊 Opérations CRUD complètes

## modélisation

Le projet inclut :

diagrammes UML

schéma relationnel de la base de données

## contexte académique

Ce projet a été réalisé dans un cadre académique dans le but de :

appliquer les concepts de développement full stack

concevoir une API REST

mettre en œuvre l’authentification API

pratiquer l’intégration backend ↔ applicatif

travailler selon une approche structurée

## remarques

Le backend doit être lancé avant le module C#

L’URL de l’API doit être cohérente entre les deux projets

Aucune donnée sensible n’est stockée dans le dépôt

Les adresses 127.0.0.1 sont utilisées uniquement pour l’environnement local

## auteur

Carl-William Ouedraogo
