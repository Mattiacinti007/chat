using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace cinti_chat
{
    internal class Chat
    {
        //dichiarazione attributi
        TcpClient client;
        NetworkStream stream; //canale di comunicazione tra client e server per inviare/ricevere dati
        Thread ricezioneThread; //processo in background per ascolare continuamente i messaggi che arrivano dal server 
        Action<string> messaggioRicevuto; //variabile che contiene un riferimento a un metodo, action string vuol dire un metodo che riceve una string e non sìrestituisce nulla
        Action Disconnesso; //metodo senza input e senza output, serve per dire UI che il client è disconesso

        /// <summary>
        /// connette il client al server TCP
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="messaggio"></param>
        /// <param name="disconesso"></param>
        public void Connetti(string nome, Action<string> messaggio, Action disconesso)
        {
            //connessione al server sulla porta 5000
            client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();

            //salvo i messaggi di ritorno
            this.messaggioRicevuto = messaggio;
            this.Disconnesso = disconesso;

            //invio il nome al server
            byte[] ByteNome = Encoding.UTF8.GetBytes(nome);
            stream.Write(ByteNome, 0, ByteNome.Length);

            //avvia un thread in background per la ricezione dei messaggi
            ricezioneThread = new Thread(RIceviMessaggi);
            ricezioneThread.IsBackground = true;
            ricezioneThread.Start();
        }

        /// <summary>
        /// invia un messaggio al server
        /// </summary>
        /// <param name="testo"></param>
        public void InviaMessaggio(string testo)
        {
            byte[] dati = Encoding.UTF8.GetBytes(testo);
            stream.Write(dati, 0, dati.Length);
        }

        /// <summary>
        /// thread dedicato alla ricezione dei messaggi dal server
        /// chiama il callback quando riceve un messaggio oppure se viene disconnesso
        /// </summary>
        public void RIceviMessaggi()
        {
            try
            {
                byte[] buffer = new byte[1024];

                while (true)
                {
                    //legge byte dal flusso
                    int byteletto = stream.Read(buffer, 0, buffer.Length);

                    //controllo se vi è ancora il flusso
                    if (byteletto == 0)
                    {
                        //disconetto il server
                        Disconnesso?.Invoke();
                        break;
                    }
                    
                    //converto il messaggio in stringa
                    string messaggio = Encoding.UTF8.GetString(buffer, 0, byteletto);

                    //controllo se ricevo un comando di disconessione
                    if (messaggio.StartsWith("DISCONNECT:"))
                    {
                        Disconnesso?.Invoke();
                        break;
                    }

                    //inoltro il messagio alla UI
                    messaggioRicevuto?.Invoke(messaggio);
                }
            }
            catch (Exception ex)
            {

                Disconnesso?.Invoke();
            }
        }

        /// <summary>
        /// chiude la connessione e libera le risorse
        /// </summary>
        public void Disconnetti()
        {
            stream?.Close();
            client?.Close();
        }
        
    }
}
