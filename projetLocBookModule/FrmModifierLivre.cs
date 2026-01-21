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
    public partial class FrmModifierLivre : Form
    {
        string urlModifierOuvrage = "http://127.0.0.1:8000/api/ouvrage/modifier";
        private static readonly HttpClient client = new HttpClient();
        private int bookId;
        public FrmModifierLivre(int bookId)
        {
            InitializeComponent();
            this.bookId = bookId;
            
        }

        private void FrmModifierLivre_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmPageAccueil accueil = new FrmPageAccueil();
            accueil.Show();
            this.Hide();
        }

        private async Task<bool> ModifierOuvrage(int bookId,string categorie, string genre, int stock)
        {
            try
            {
                var data = new
                {
                    id = bookId,
                    categorie = categorie,
                    genre = genre,
                    stock = stock,
                };

                var jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Put, urlModifierOuvrage);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                request.Content = content;
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la modification");
                    return false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("une erreur est survenue");
                return false;
            }
        
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            string categorie = txtCategorie.Text;
            string genre = txtGenre.Text;
            int stock;

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("le stock doit être un nombre entier valide.");
                return;
            }

            String message = "Valider vos choix";
            String caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                bool modification = await ModifierOuvrage(bookId,categorie, genre, stock);
                if (modification)
                {
                    FrmPageAccueil p = new FrmPageAccueil();
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Information incomplète");
                }
            }
        }
    }
}
