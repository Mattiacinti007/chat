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

        //costruttore della classe
        public Utente(string nome)
        {
            Nome = nome;
        }
    }
}
