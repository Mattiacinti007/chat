using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinti_chat
{

    internal class Utente
    {

        //dichiarazione attributi
        string _nome;
        string _messaggio;
        bool _statoUtente;

        #region proprietà attributi
        //proprietà attributo nome
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                //controllo la validità del nome
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome non valido.");
                }

                _nome = value;
            }
        }

        //proprietà attributo messaggio
        public string Messaggio
        {
            get
            {
                return _messaggio;
            }
            set
            {
                //controllo la validità del messaggio
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Messaggio non valido.");
                }

                _messaggio = value;
            }
        }

        //proprietà attributo stato utente
        public bool StatoUtente
        {
            get
            {
                return _statoUtente;
            }
            set
            {
                _statoUtente = value;
            }
        }
        #endregion


        //costruttore della classe
        public Utente(string nome)
        {
            Nome = nome;
            StatoUtente = true;

        }



        #region funzione aggiungi messaggio
        /// <summary>
        /// aggiunge un messaggio alla chat
        /// </summary>
        /// <returns></returns>
        public Label aggiungiMessaggio(int yMessaggi, int panelWidth)
        {
            Label nuovoMessaggio = new Label();

            nuovoMessaggio.Text = Program.chat.Utente1.Messaggio;
            nuovoMessaggio.Font = new Font("Segoe UI", 10);
            nuovoMessaggio.ForeColor = Color.Black;
            nuovoMessaggio.BackColor = Color.FromArgb(220, 248, 198);
            nuovoMessaggio.Padding = new Padding(10);
            nuovoMessaggio.TextAlign = ContentAlignment.TopLeft;

            // 🔑 Abilita rendering compatibile per wrap su parole lunghe
            nuovoMessaggio.UseCompatibleTextRendering = true;

            // Imposta word wrap con limite di larghezza
            nuovoMessaggio.AutoSize = false;
            nuovoMessaggio.MaximumSize = new Size(250, 0);

            // Calcola altezza necessaria per tutto il testo (anche senza spazi)
            Size preferredSize = TextRenderer.MeasureText(
                nuovoMessaggio.Text,
                nuovoMessaggio.Font,
                new Size(250, 0),
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl
            );

            // Imposta dimensioni finali
            nuovoMessaggio.Size = new Size(250, preferredSize.Height + 20);

            // Allineamento a destra
            int x = panelWidth - nuovoMessaggio.Width - 10;
            nuovoMessaggio.Location = new Point(x, yMessaggi);

            return nuovoMessaggio;
        }
        #endregion
    }
}

