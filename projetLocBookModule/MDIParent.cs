using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
            //affiche la fenêtre de login 
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {

        }
    }
}
