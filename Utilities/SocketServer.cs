using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace GardenGuardian.Utilities
{
    /// <summary>
    /// Classe permettant la communication avec les machines du réseau en utilisant des socket
    /// </summary>
    public class SocketServer
    {
        public EventHandler AlertReceived;
        public EventHandler InfosReceived;
        public string InputMessage = "";
        public Socket AlertedClient = null;

        public List<Socket> clients = new List<Socket>();
        private Socket serverSocket;
        private int port = 12345;
        private bool isRunning;
        private Thread listeningThread;
        

        /// <summary>
        /// Constructeur, permet d'initialiser le serveur
        /// </summary>
        public SocketServer()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            isRunning = false;
        }

        /// <summary>
        /// Méthode permettant de lancer le thread d'écoute du serveur
        /// </summary>
        public void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                listeningThread = new Thread(ListenForClientConnections);
                listeningThread.Start();
                MessageBox.Show("Serveur ouvert");
            }
        }

        /// <summary>
        /// Méthode permettant de fermer la communication avec le serveur
        /// </summary>
        public void Stop()
        {
            if (isRunning)
            {
                isRunning = false;
                listeningThread.Abort();//ferme le serveur
                serverSocket.Close();//Fermeture du socket serveur
                foreach (Socket client in clients)//Fermeture des sockets clients
                {
                    client.Close();
                }
            }
        }

        /// <summary>
        /// Méthode du thread d'écoute de connexion
        /// </summary>
        private void ListenForClientConnections()
        {
            try
            {
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                serverSocket.Listen(10);

                while (isRunning)
                {
                    //On accepte la connexion du client et on garde le Socket dans la liste
                    Socket clientSocket = serverSocket.Accept();
                    Thread clientThread = new Thread(HandleClient);
                    clients.Add(clientSocket);
                    clientThread.Start(clientSocket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception déclenchée :\n"+ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            MessageBox.Show("Listening Thread ended");
        }

        /// <summary>
        /// Méthode permettant d'écouter les messages d'un client
        /// </summary>
        /// <param name="clientSocketObj"></param>
        private void HandleClient(object clientSocketObj)
        {
            Socket clientSocket = (Socket)clientSocketObj;

            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while (isRunning)
                {
                    bytesRead = clientSocket.Receive(buffer);
                    if (bytesRead == 0)
                    {
                        break; // Le client s'est déconnecté
                    }

                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    MessageBox.Show($"Message du client : {message}");
                    InputMessage = message;
                    ///Traitement du message du client en fonction du type de message
                    string[] messageElements = message.Split(';');
                    switch (messageElements[0])
                    {
                        case "INFOS":
                            
                            SendMessage(clientSocket, "Infos reçues");
                            this.InfosReceived(this,new EventArgs());
                            break;
                        case "ALERT":
                            SendMessage(clientSocket, "Alerte recue");
                            AlertedClient = clientSocket;
                            this.AlertReceived(this, new EventArgs());
                            
                            break;
                    }

                }
                clientSocket.Close();
            }
            catch(ThreadAbortException ab_ex)
            {
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception déclenchée :\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientSocket.Close();
            }
        }

        /// <summary>
        /// Méthode permettant d'envoyer un message à un client
        /// </summary>
        /// <param name="clientSocket"></param>
        /// <param name="message"></param>
        public void SendMessage(Socket clientSocket, string message)
        {
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            clientSocket.Send(messageBytes);
        }


    }

}
