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
    public partial class frmParametre : Form
    {
        Entites.SessionManager sessionManager = Entites.SessionManager.getInstance();
        string urlModifier = "http://127.0.0.1:8000/api/modifier/membre";
        private static readonly HttpClient client = new HttpClient();
        public frmParametre()
        {
            InitializeComponent();
        }

        private void tsmiPageAccueil_Click(object sender, EventArgs e)
        {
            //Affiche la page d'accueil et ferme celle ci
            FrmPageAccueil accueil = new FrmPageAccueil();
            accueil.Show();
            this.Hide();
        }

        private void tsmiHistorique_Click(object sender, EventArgs e)
        {
            //Affiche la page historique et ferme celle ci
            frmHistorique hist = new frmHistorique();
            hist.Show();
            this.Hide();
        }

        private async void tsmiProfil_Click(object sender, EventArgs e)
        {
            IList<Entites.Membre> membre = await sessionManager.GetMembreInfo();
            //Affiche le page profil et ferme celle ci
            FrmProfil prof = new FrmProfil(membre) ;
            prof.Show();
            this.Hide();
        }

        private void tsmiDeconnextion_Click(object sender, EventArgs e)
        {
            //message affiché avec l'icon question et les boutons oui ou non
            String message = "Etes vous sur ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui deconnecte l'utilisateur et affiche la page de login
                frmLogin accueil = new frmLogin();
                accueil.Show();
                this.Hide();
            }
        }

        private async void btnConfirmer_Click(object sender, EventArgs e)
        {
            //confirme les choix de modifications du profil
            String message = "Valider vos choix";
            String caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string email = txtChangerMail.Text;
            string motDePasse = txtNouveauMotPasse.Text;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool modificationReussie = await ModifierInfosMembre(email, motDePasse);
                if (modificationReussie)
                {
                    // Parcours de tous les contrôles dans le formulaire
                    foreach (Control ctrl in this.Controls)
                    {
                        // Vérifie si le contrôle est un TextBox
                        if (ctrl is TextBox)
                        {
                            // Vide le contenu du TextBox
                            ((TextBox)ctrl).Text = string.Empty;
                        }
                    }
                    MessageBox.Show("les infos ont été modifiés");
                }
                else
                {
                    MessageBox.Show("les infos n'ont pas été modifiés");
                }

            }
                   
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Parcours de tous les contrôles dans le formulaire
            foreach (Control ctrl in this.Controls)
            {
                // Vérifie si le contrôle est un TextBox
                if (ctrl is TextBox)
                {
                    // Vide le contenu du TextBox
                    ((TextBox)ctrl).Text = string.Empty;
                }
            }
        }

        private async Task<bool> ModifierInfosMembre(string newEmail, string newPassword)
        {
            try
            {
                var data = new
                {
                    email = newEmail,
                    password = newPassword
                };

                var jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Put, urlModifier);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                request.Content = content;
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                    MessageBox.Show("Une erreur est survenue lors de la modification");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("une erreur est survenue");
                return false;
            }
            
        }

        private void frmParametre_Load(object sender, EventArgs e)
        {

        }

        private void txtChangerMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
