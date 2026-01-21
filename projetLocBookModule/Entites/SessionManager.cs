using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook.Entites
{
    class SessionManager
    {
        private static SessionManager instance;
        public bool estConnecte { get; private set; }
        public bool EstAdmin { get; private set; }
        public string Token { get; private set; }
        private string url = "http://127.0.0.1:8000/api/logout";
        private string urlGetMembre = "http://127.0.0.1:8000/api/membre";
        private static readonly HttpClient client = new HttpClient();

        public void ConnecterUtilisateur(bool estAdmin, string token)
        {
            estConnecte = true;
            EstAdmin = estAdmin;
            Token = token;
        }

        public async Task<bool> DeconnecterUtilisateur()
        {
            estConnecte = false;
            EstAdmin = false;
            Token = null;

            var request = new HttpRequestMessage(HttpMethod.Post, url);

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);

            var response = await client.PostAsync(url, null);

            //string responseContent = await response.Content.ReadAsStringAsync();
            MessageBox.Show("Déconnexion réussie");
            return true;

        }

        public static SessionManager getInstance()
        {
            if (instance == null)
            {
                instance = new SessionManager();
            }
            return instance;
        }

        public async Task<IList<Entites.Membre>> GetMembreInfo()
        {
            IList<Entites.Membre> membres = null;
            var request = new HttpRequestMessage(HttpMethod.Get, urlGetMembre);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                membres = JsonSerializer.Deserialize<IList<Entites.Membre>>(responseBody);
                return membres;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des informations de l'utilisateur.");
                return null;
            }
        }
    }
}
