using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook
{
    public partial class frmAjouterLivre : Form
    {
        string urlAjouterLivre = "http://127.0.0.1:8000/api/ouvrage/ajouter";
        private static readonly HttpClient client = new HttpClient();
        public frmAjouterLivre()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmPageAccueil pageAccueil = new FrmPageAccueil();
            pageAccueil.Show();
            this.Hide();
        }

        private void frmAjouterLivre_Load(object sender, EventArgs e)
        {

        }

        public async Task<bool> ajouterLivre(string titre, double prix, string auteur, int stock, string bibliotheque,string categorie,string genre)
        {
            try
            {
                var data = new
                {
                    titre = titre,
                    prix = prix,
                    auteur = auteur,
                    stock = stock,
                    bibliotheque = bibliotheque,
                    categorie = categorie,
                    genre = genre,
                };
                var jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Post, urlAjouterLivre);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                request.Content = content;
                var response = await client.SendAsync(request);
                Console.WriteLine($"Response Status: {response.StatusCode}");
                Console.WriteLine($"Response Content: {await response.Content.ReadAsStringAsync()}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livre ajouteé avec succès");
                    return true;
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du Livre");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du Livre");
                return false;
            }
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            string titre = txtTitre.Text;
            double prix;
            string auteur = txtAuteur.Text;
            int stock;
            string bibliotheque = txtBibliotheque.Text;
            string categorie = txtCategorie.Text;
            string genre = txtGenre.Text;


            if (!double.TryParse(txtPrix.Text, out prix))
            {
                MessageBox.Show("le prix doit être un nombre entier valide.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("le stock doit être un nombre entier valide.");
                return;
            }



            bool ajoutReussi = await ajouterLivre(titre,prix,auteur,stock,bibliotheque,categorie,genre);
            if (ajoutReussi)
            {
                //affiche la page d'accueil et ferme la page d'enregistrement
                FrmPageAccueil p = new FrmPageAccueil();
                p.Show();
                this.Hide();
                MessageBox.Show("Ajout réussi");
            }
            else
            {
                MessageBox.Show("il manque une info");
            }
        }
    }
}
