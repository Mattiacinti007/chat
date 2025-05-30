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
        List<string> _listaMessaggi;

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
        public Label aggiungiMessaggio()
        {
            Label nuovoMessaggio = new Label();
            nuovoMessaggio.Text = Messaggio;
            return nuovoMessaggio;
        }
        #endregion


    }
}
