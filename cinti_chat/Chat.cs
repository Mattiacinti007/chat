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
        public List<Label> ListaMessaggi { get; set; }

        #region funzione aggiungi utente
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
        #endregion

        #region funzione visualizza chat
        /// <summary>
        /// visualizza la chat tra i due utenti nel panel
        /// </summary>
        public void visualizzaChat(Panel panelGenerico)
        {
            //foreach che scorre i messaggi della lista
            foreach (var messaggio in ListaMessaggi)
            {
                //li aggiungo al panel
                panelGenerico.ScrollControlIntoView(messaggio);
            }
        }
        #endregion

        //costruttore vuoto
        public Chat()
        {
            ListaMessaggi = new List<Label>();
        }

    }
}
