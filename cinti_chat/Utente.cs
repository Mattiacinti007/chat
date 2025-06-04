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
        /// aggiunge un messaggio alla chat alla lista dei messaggi
        /// </summary>
        /// <returns></returns>
        public void aggiungiMessaggio()
        {
            //creo un nuovo messaggio
            Messaggio nuovoMessaggio = new Messaggio(this.Messaggio, this.Nome);

            //aggiungo il messaggio alla lista
            Program.chat.ListaMessaggi.Add(nuovoMessaggio);
        }
        #endregion
    }
}

