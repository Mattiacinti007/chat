using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinti_chat
{

    internal class Utente
    {
        #region dichiarazione attributi
        //dichiarazione attributi
        public string Nome
        {
            get
            {
                return this.Nome;
            }
            set
            {
                //controllo la validità del nome
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome non valido.");
                }

                this.Nome = value;
            }
        }
        
        public string Messaggio
        {
            get
            {
                return this.Messaggio;
            }
            set
            {
                //controllo la validità del messaggio
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Messaggio non valido.");
                }
            }
        }

        public bool StatoUtente { get; set; }
        #endregion

        //costruttore della classe
        public Utente(string nome, string messaggio)
        {
            Nome = nome;
            Messaggio = messaggio;
            StatoUtente = false;
        }

        /// <summary>
        /// aggiunge un messaggio alla chat
        /// </summary>
        /// <returns></returns>
        public Label aggiungiMessaggio()
        {
            Label nuovoMessaggio = new Label();
            nuovoMessaggio.Text = Messaggio;
            return nuovoMessaggio;
        }

    }
}
