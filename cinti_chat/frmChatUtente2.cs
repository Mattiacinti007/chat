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
using System.Timers;
using System.Windows.Forms;

namespace cinti_chat
{
    public partial class frmChatUtente2 : Form
    {
        //dichiaro un nuovo timer
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public frmChatUtente2()
        {
            InitializeComponent();

            //setto il timer
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            timer.Start();

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

        #region timer tick
        /// <summary>
        /// al tick aggiorna la chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer_Tick(object sender, EventArgs e)
        {
            //controllo se l'utente 1 non è nullo
            if (Program.chat.Utente1 != null)
            {
                aggiornaChat();
            }
        }
        #endregion

        #region bottone invia
        /// <summary>
        /// al click aggiunge e invia il messaggio nella chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvia_Click(object sender, EventArgs e)
        {
            try
            {
                //rimuovo tutti gli spazi dal messaggio 
                Program.chat.Utente2.Messaggio = txtMessaggio.Text.Trim();

                //aggiungo il messaggio alla lista dei messaggi
                Program.chat.Utente2.aggiungiMessaggio();

                //pulisco la texbox per inivare un nuovo messagio
                txtMessaggio.Text = "";

                //aggiorno entrambe le chat
                Program.formchatUtente1?.aggiornaChat();
                Program.formchatUtente2?.aggiornaChat();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        #endregion

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
                Program.chat.Utente2 = Program.chat.aggiungiUtente(txtNomeUtente.Text);
                MessageBox.Show("Login effettuato con successo!");

                //se un'utente ha effettuato il login vuol dire che è online
                Program.chat.Utente2.StatoUtente = true;

                //abilito la chat per inviare messaggi
                txtMessaggio.Visible = true;
                btnInvia.Visible = true;
                panelMessaggi.Visible = true;


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

        #region funzione aggiorna chat
        /// <summary>
        /// aggiorna la chat
        /// </summary>
        public void aggiornaChat()
        {
            //dichiaro le coordinate dei messaggi
            int yMessaggi = 20;
            int xMessaggi;

            //controllo se entrambi gli utenti sono inizializzati
            if (Program.chat.Utente1 == null || Program.chat.Utente2 == null)
            {
                return;
            }

            //ripulisco il panel dei messaggi
            panelMessaggi.Controls.Clear();

            //scorro i messaggi della lista
            foreach (var messaggio in Program.chat.ListaMessaggi)
            {
                //setto la label per il messaggio
                Label messaggioLabel = new Label();
                messaggioLabel.Text = messaggio.Testo;
                messaggioLabel.Font = new Font("Segoe UI", 10);
                messaggioLabel.Padding = new Padding(10);
                messaggioLabel.AutoSize = false;
                messaggioLabel.MaximumSize = new Size(250, 0);
                messaggioLabel.UseCompatibleTextRendering = true;


                //in base al mittente imposta il colore di sfondo
                if (!string.IsNullOrEmpty(messaggio.Mittente) && messaggio.Mittente == Program.chat.Utente2.Nome)
                {
                    messaggioLabel.BackColor = Color.FromArgb(220, 248, 198);
                }
                else
                {
                    messaggioLabel.BackColor = Color.LightGray;
                }

                //imposto il colore del testo
                messaggioLabel.ForeColor = Color.Black;

                //calcola la dimenesione del label
                Size dimensioneLabel = TextRenderer.MeasureText(
                    messaggioLabel.Text,
                    messaggioLabel.Font,
                    new Size(250, 0),
                    TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl
                );

                //imposto la dimensione del label
                messaggioLabel.Size = new Size(250, dimensioneLabel.Height + 20);

                //controllo chi è il mittente del messaggio
                if (messaggio.Mittente == Program.chat.Utente2.Nome)
                {
                    //imposto la x del messaggio in base al mittente
                    xMessaggi = panelMessaggi.Width - messaggioLabel.Width - 10;
                }
                else
                {
                    //impostazio ne di default
                    xMessaggi = 10;
                }


                //imposto la posizione del label
                messaggioLabel.Location = new Point(xMessaggi, yMessaggi);

                //aggiungo la label al panel dei messaggi
                panelMessaggi.Controls.Add(messaggioLabel);
                
                //aggiorno la y del messaggio
                yMessaggi += messaggioLabel.Height + 10;
            }

            //scrollo in basso per vedere l'ultimo messaggo
            panelMessaggi.VerticalScroll.Value = panelMessaggi.VerticalScroll.Maximum;
            panelMessaggi.PerformLayout();
        }
        #endregion
    }
}