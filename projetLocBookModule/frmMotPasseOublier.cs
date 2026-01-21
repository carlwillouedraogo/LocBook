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
    public partial class frmMotPasseOublier : Form
    {
        string urlModifierPass = "http://127.0.0.1:8000/api/modifier/motdepasse";
        string urlUser = "http://127.0.0.1:8000/api/user";
        private static readonly HttpClient client = new HttpClient();
        public frmMotPasseOublier()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //affiche un message et son icon avec comme choix oui ou non
            String message = "Etes vous sûr de vouloir annuler ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui retourne à la fenêtre de login et ferme la fenêtre actuel
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private async void btnConfirmer_Click(object sender, EventArgs e)
        {
            //affiche un message et son icon avec les boutons oui ou non
            String message = "Mot de passe changer ";
            String caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string email = txtEmail.Text;
            string password = txtNouveauPasse.Text;
            string confirmerMotPass = txtConfirmerPasse.Text;

            if (password != confirmerMotPass)
            {
                MessageBox.Show("le mot de passe n'est pas le même");
                return;
            }

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                    bool changePass = await ModifierInfosMembre(email, password);
                    if (changePass)
                    {
                        // si oui change le mot de passe et retourne à la fenêtre de login
                        frmLogin login = new frmLogin();

                        login.Show();
                        this.Hide();
                        MessageBox.Show("mot de passe modifié");

                    }
                    else
                    {
                        MessageBox.Show("mot de passe pas modifié");
                    }
                }
            
        }

        private void frmMotPasseOublier_Load(object sender, EventArgs e)
        {

        }

        private async Task<bool> ModifierInfosMembre(string email, string newPassword)
        {
            try
            {
                var data = new { email = email, password = newPassword};
                var jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Put, urlModifierPass);
                request.Content = content;
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                    MessageBox.Show("mot de passe modifié");
                }
                else
                {
                    return false;
                    MessageBox.Show("Erreur lors de la modification");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("une erreur est survenue");
                return false;
            }
        }

        private async Task<Entites.User> GetuserByEmail(string email)
        {
            var response = await client.GetAsync($"{urlUser}?email={email}");

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<Entites.User>(responseBody);
                MessageBox.Show("user");
                return user;
            }
            else
            {
                return null;
                MessageBox.Show("user pas trouvé");
            }
        }
    }
}
