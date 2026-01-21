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
    public partial class frmAchat : Form
    {
        static frmAchat instance;

        private static readonly HttpClient client = new HttpClient();
        
        string urlAchat = "http://127.0.0.1:8000/api/achat/ajouter";
        private frmAchat()
        {
            InitializeComponent();
            
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            //ouvre une boite de dialogue et affiche les message oui ou non
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
                        date = DateTime.Now.ToString("yyyy-MM-dd"),
                        ouv_id = ouvrage.ouv_id.ToString(),
                        prixAchat = ouvrage.ouv_prix.ToString()
                    };
                        var jsonData = JsonSerializer.Serialize(data);
                        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                        var request = new HttpRequestMessage(HttpMethod.Post, urlAchat);
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                        request.Content = content;
                        var response = await client.SendAsync(request);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Achat validé");
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
                catch(Exception ex)
                {
                    MessageBox.Show("une erreure est survenue");
                }
                
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //ouvre une boite de dialogue et affiche les message oui ou non
            String message = "Etes vous sûr de vouloir annuler ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui affiche la page du panier et ferme la page Achat
                frmPanier panier = new frmPanier();
                panier.Show();
                this.Hide();
            }
        }

        private void frmAchat_Load(object sender, EventArgs e)
        {

        }
        static public frmAchat getInstance()
        {
            if (instance is null || instance.IsDisposed)
            {
                instance = new frmAchat();
            }
            return instance;
        }
    }

}
