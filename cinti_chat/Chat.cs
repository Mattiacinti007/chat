using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinti_chat
{
    internal class Chat
    {
        //dichiarazione attributi
        public Utente Utente1 { get; set; }
        public Utente Utente2 { get; set; }

        public List<string> ListaMessaggi { get; set; }

        /// <summary>
        /// aggiunge un'utente nella chat
        /// </summary>
        /// <param name="utente"></param>
        /// <param name="nomeInserito"></param>
        /// <returns></returns>
        public Utente aggiungiUtente(string nomeInserito)
        {
            //crea e ritorna un nuovo utente
            Utente utente;
            return utente = new Utente(nomeInserito);

        }

        //costruttore vuoto
        public Chat()
        {
            ListaMessaggi = new List<string>();
        }

    }
}
