using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook
{
    
    public partial class FrmEnregistrement : Form
    {
        string urlAjouter = "http://127.0.0.1:8000/api/register";
        private static readonly HttpClient client = new HttpClient();


        public FrmEnregistrement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public async Task<bool> ajouterMembre(string nom, string prenom, int age,string email,string motDePass)
        {
            try
            {
                var data = new
                {
                    nom = nom,
                    prenom = prenom,
                    age = age,
                    email = email,
                    password = motDePass

                };
                var jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(urlAjouter, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("membre ajouteé avec succès");
                    return true;
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du membre");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du membre");
                return false;
            }
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            int age;
            string email = txtEmail.Text;
            string motDePass = txtMotPass.Text;
            string confirmerMotPass = txtConfirmerPasse.Text;

            if (motDePass != confirmerMotPass)
            {
                MessageBox.Show("le mot de passe n'est pas le même");
                return;
            }

            
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("l'age doit être un nombre entier valide.");
                return;
            }



            bool ajoutReussi = await ajouterMembre(nom, prenom, age, email, motDePass);
            if (ajoutReussi)
            {
                //affiche la page d'accueil et ferme la page d'enregistrement
                frmLogin p = new frmLogin();
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("il manque une info");
            }
        }

        private void FrmEnregistrement_Load(object sender, EventArgs e)
        {
             
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //affiche un message avec son icon et les choix de boutons oui ou non
            String message = "Etes vous sur ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //affiche la page login et ferme la page d'enregistrement
                frmLogin accueil = new frmLogin();
                accueil.Show();
                this.Hide();
            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtConfirmerPasse_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
