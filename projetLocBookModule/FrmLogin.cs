using Newtonsoft.Json;
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
    public partial class frmLogin : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string urlAuth = "http://127.0.0.1:8000/api/auth";
      


        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public async Task<(bool, bool)> Authentification(string email, string motDePasse)
        {
            try
            {
                var data = new
                {
                    email = email,
                    password = motDePasse
                };

                var jsonData = System.Text.Json.JsonSerializer.Serialize(data);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(urlAuth, content);

                Console.WriteLine($"Demande d'authentification envoyée. Statut de la réponse : {response.StatusCode}");


                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var tokenObject = System.Text.Json.JsonSerializer.Deserialize<Entites.AuthResponse>(responseBody);

                    if (tokenObject != null && !string.IsNullOrEmpty(tokenObject.Token))
                    {
                        Console.WriteLine($"Token : {tokenObject.Token}, isAdmin : {tokenObject.isAdmin}");
                        Entites.AuthTokenManager.AuthToken = tokenObject.Token;
                        return (true,tokenObject.isAdmin);
                    }
                    else
                    {
                        MessageBox.Show("token non trouvé");
                        return (false,false);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Erreur lors de la demande d'authentification");
                    return (false,false);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'authentification : {ex.Message}");
                MessageBox.Show("Erreur lors de l'authentification");
                return (false, false);
            }
        }

        private async void btnConnexion_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre page d'accueil et ferme la fenêtre de login
            string email = txtEmail.Text;
            string motDePasse = txtMotPass.Text;

            (bool estAuthentifie, bool isAdmin) = await Authentification(email, motDePasse);
            

            if (estAuthentifie)
            {
                
                string token = Entites.AuthTokenManager.AuthToken;
                Entites.SessionManager sessionManager = Entites.SessionManager.getInstance();
                sessionManager.ConnecterUtilisateur(isAdmin, token);
                FrmPageAccueil p = new FrmPageAccueil();
                p.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("l'authentification a échoué");
            }
           
        }

        private void llbEnregistrer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //affiche la fenêtre enregistrement et ferme la fenêtre de login
            FrmEnregistrement f = new FrmEnregistrement();
            f.Show();
            this.Hide();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void llbPasseOublier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //affiche la fenêtre mot de passe oublier et ferme la fenêtre de login
            
            frmMotPasseOublier mdp = new frmMotPasseOublier();
            mdp.Show();
            this.Hide();
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMotPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
