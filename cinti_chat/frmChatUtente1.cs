using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinti_chat
{
    public partial class frmChatUtente1 : Form
    {
        public frmChatUtente1()
        {
            InitializeComponent();

            //inizializzo e faccio visualizzare la nuova fornm
            frmChatUtente2 formChatUtente2 = new frmChatUtente2();
            formChatUtente2.Show();

            //impostazioni iniziali prima del login
            txtMessaggio.Visible = false;
            btnInvia.Visible = false;

        }

        /// <summary>
        /// al click aggiunge e invia il messaggio nella chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvia_Click(object sender, EventArgs e)
        {

            //salvo il messaggio dell'utente
            Program.chat.Utente1.Messaggio = txtMessaggio.Text;

            //faccio una nuova label
            Label messaggio = Program.chat.Utente1.aggiungiMessaggio();

            //faccio visualizzare il messaggio
            messaggio.Text = "Tu: " + Program.chat.Utente1.Messaggio;

            //faccio visualizzare la label
            messaggio.Visible = true;

            //dopo aver inviato il messaggio ripulisco la textbox
            txtMessaggio.Text = "";

            //aggiungo i controlli sul messaggio
            this.Controls.Add(messaggio);

            //aggiungo il messaggio alla lista dei messaggi della chat
            Program.chat.ListaMessaggi.Add(txtMessaggio.Text);

        }

        #region bottone login
        /// <summary>
        /// al click effettua il login dell'utente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //creo un nuovo utente
                Program.chat.Utente1 = Program.chat.aggiungiUtente(txtNomeUtente.Text);
                MessageBox.Show("Login effettuato con successo!");

                //se un'utente ha effettuato il login vuol dire che è online
                Program.chat.Utente1.StatoUtente = true;

                //abilito la chat per inviare messaggi
                txtMessaggio.Visible = true;
                btnInvia.Visible = true;

                //rimuovo strumenti per l'inserimento del nome
                txtNomeUtente.Visible = false;
                btnLogin.Visible = false;
                lblNome.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Errore: {ex.Message}");
            }
        }
        #endregion
    }
}
