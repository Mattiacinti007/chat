using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinti_chat
{
    public partial class frmChatUtente1 : Form
    {
        //dichiaro la y del messaggio
        int yMessaggi = 20;

        public frmChatUtente1()
        {
            InitializeComponent();

            //inizializzo e faccio visualizzare la nuova fornm
            frmChatUtente2 formChatUtente2 = new frmChatUtente2();
            formChatUtente2.Show();

            //impostazioni iniziali prima del login
            txtMessaggio.Visible = false;
            btnInvia.Visible = false;

            panelMessaggi.Visible = false;

            //disattiva il pulsante di massimizzazione
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            panelMessaggi.HorizontalScroll.Enabled = false;
            panelMessaggi.HorizontalScroll.Visible = false;

        }

        /// <summary>
        /// al click aggiunge e invia il messaggio nella chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvia_Click(object sender, EventArgs e)
        {

            Program.chat.Utente1.Messaggio = txtMessaggio.Text.Trim();

            // Passo la larghezza del panel (senza dichiarare panelWidth)
            Label messaggio = Program.chat.Utente1.aggiungiMessaggio(yMessaggi, panelMessaggi.Width);

            panelMessaggi.Controls.Add(messaggio);

            yMessaggi += messaggio.Height + 10;

            txtMessaggio.Text = "";

            Program.chat.ListaMessaggi.Add(messaggio);



            

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
                panelMessaggi.Visible = true;


                //rimuovo strumenti per l'inserimento del nome
                txtNomeUtente.Visible = false;
                btnLogin.Visible = false;
                lblNome.Visible = false;

                //carico la chat 
                Program.chat.visualizzaChat(panelMessaggi);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Errore: {ex.Message}");
            }
        }
        #endregion
    }
}
