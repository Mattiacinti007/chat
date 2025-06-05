using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinti_chat
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        #region bottone invia
        /// <summary>
        /// al cick effettua il login 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvia_Click(object sender, EventArgs e)
        {
            //variabile d'appoggio
            string nomeInserito;

            //assegno il nome alla texbox della form
            nomeInserito = txtNome.Text;


            try
            {

                //creo un nuovo utente
                Program.utente = new Utente(nomeInserito);

                //comunicazione
                MessageBox.Show("Login effettuato con accesso.");

                //apro la chat all'utente
                frmChat formChat = new frmChat();
                formChat.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }
        #endregion
    }
}
