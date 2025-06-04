using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinti_chat
{
    internal class Messaggio
    {
        //dichiarazione attributi
        string _testo;
        string _mittente;

        #region proprietà attributi
        //proprietà attributo testo
        public string Testo
        {
            get
            {
                return _testo;
            }
            set
            {
                //controllo la validità del messaggio
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Messaggio inserito non valido");
                }

                _testo = value;
            }
        }

        //proprietà attributo mittente
        public string Mittente
        {
            get
            {
                return _mittente;
            }
            set
            {
                _mittente = value;
            }
        }
        #endregion


        //costruttore della classe
        public Messaggio(string testo, string mittente)
        {
            Testo = testo;
            Mittente = mittente;
        }

    }
}
