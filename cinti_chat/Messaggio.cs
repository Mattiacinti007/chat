using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace cinti_chat
{
    internal class Messaggio
    {
        //dichiarazione attributi
        string _mittente;
        string _testo;

        //proprietò attributo testo
        public string Testo
        {
            get
            {
                return _testo;
            }
            set
            {
                //controllo la validità del testo
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Testo inserito non valido");
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

        /// <summary>
        /// crea il formato di un messaggio generico della chat
        /// </summary>
        /// <returns></returns>
        public string formatoMessaggio()
        {
            return $"{Mittente}: {Testo}";
        }

        //costruttore della classe
        public Messaggio(string testo, string mittente)
        {
            Testo = testo;
            Mittente = mittente;
        }
    }
}
