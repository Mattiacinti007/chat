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
    public partial class frmChat : Form
    {

        //dichiarazione variabili
        Chat client;
        Messaggio messaggio;

        public frmChat()
        {
            InitializeComponent();

            client = new Chat();

            //connetto al server i client
            client.Connetti(Program.utente.Nome, MessaggioRicevuto, Disconnesso);
        }

        public void MessaggioRicevuto(string dati)
        {
            BeginInvoke(new MetodoMessaggioDelegate(aggiungiMessaggio), dati);

        }

        /// <summary>
        /// metodo chiamato quando si viene disconnessi
        /// </summary>
        public void Disconnesso()
        {
            BeginInvoke(new MethodInvoker(visualizzaMessaggioDisconnessione));
        }

        /// <summary>
        /// disconnette il client alla chiusura della form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnetti();
        }

        /// <summary>
        /// visualizza ed inserisce il messaggio nella listbox
        /// </summary>
        public void aggiungiMessaggio(string messaggio)
        {
            lbMessaggi.Items.Add(messaggio);
        }

        /// <summary>
        /// visualizza il messaggio di disconnessione
        /// </summary>
        public void visualizzaMessaggioDisconnessione()
        {
            MessageBox.Show("La chat non è più online. Sei stato disconnesso.", "Disconnesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        /// <summary>
        /// al clikc invia il messagio alla chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInvia_Click(object sender, EventArgs e)
        {
            try
            {
                //asseggno la variabile alle textbox
                string messaggioInserito = txtMessaggio.Text.Trim();

                //creo un nuovo messaggio
                messaggio = new Messaggio(messaggioInserito, Program.utente.Nome);

                //do al messaggio un formato più chiaro
                string messaggioFormattato = messaggio.formatoMessaggio();

                //inivio il messaggio alla chat
                client.InviaMessaggio(messaggioFormattato);

                //ripulisco la textbox per mandare un nuovo messaggio
                txtMessaggio.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
            

        }

        //delegato per passare una stringa a invoke
        private delegate void MetodoMessaggioDelegate(string messaggio);
    }
}
