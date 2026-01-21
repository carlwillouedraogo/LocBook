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
    public partial class frmEmprunt : Form
    {
        static frmEmprunt instance;
        private static readonly HttpClient client = new HttpClient();
        string urlAchat = "http://127.0.0.1:8000/api/emprunt/ajouter";
        private frmEmprunt()
        {
            InitializeComponent();
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            //affiche un message une icon et les boutons oui et non
            String message = "Avez-vous rempli toutes les cases ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            Entites.Panier panier = Entites.Panier.GetInstance();
            IList<Entites.Ouvrage> ouvrages = panier.GetPanier();

            if (ouvrages.Count == 0)
            {
                MessageBox.Show("Le panier est vide. Veuillez ajouter des articles avant de valider l'achat");
                return;
            }

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (var ouvrage in ouvrages)
                    {
                        var data = new
                        {
                            date_debut = dtpDebutEmprunt.Value.ToString("yyyy-MM-dd"),
                            ouv_id = ouvrage.ouv_id.ToString(),
                            date_fin = dtpFinEmprunt.Value.ToString("yyyy-MM-dd")
                        };
                        var jsonData = JsonSerializer.Serialize(data);
                        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                        var request = new HttpRequestMessage(HttpMethod.Post, urlAchat);
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                        request.Content = content;
                        var response = await client.SendAsync(request);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Emprunt validé");
                            
                        }
                        else
                        {
                            Console.WriteLine(response.StatusCode);
                            Console.WriteLine(response);
                            MessageBox.Show("Erreur lors de la validation");
                        }
                    }
                    //si oui affiche la page accueil et ferme la page Achat
                    FrmPageAccueil accueil = new FrmPageAccueil();
                    accueil.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("une erreure est survenue");
                }

            }
        }

       
    

        private void frmEmprunt_Load(object sender, EventArgs e)
        {

        }
    

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //affiche un message une icon et les boutons oui et non
            String message = "Etes vous sûr de vouloir annuler ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui affiche la page panier et ferme la page emprunt
                frmPanier panier = new frmPanier();
                panier.Show();
                this.Hide();
            }
        }

        
        

        static public frmEmprunt getInstance()
        {
            if (instance is null || instance.IsDisposed)
            {
                instance = new frmEmprunt();
            }
            return instance;
        }
    }
}
