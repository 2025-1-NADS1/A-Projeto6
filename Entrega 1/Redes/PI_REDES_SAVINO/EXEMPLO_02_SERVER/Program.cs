using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SERVIDOR
{
    class Program
    {
        static TcpListener tcpServer;
        static string myIP;
        static bool fim;

        static void Main(string[] args)
        {
            fim = false;
            myIP = "127.0.0.1";
            tcpServer = new TcpListener(IPAddress.Parse(myIP), 80);
            tcpServer.Start();
            Thread threadServer = new Thread(() => serverListener());
            threadServer.Start();

            Console.WriteLine("Servidor iniciado. Pressione [ENTER] para encerrar...");
            Console.ReadLine();
            fim = true;
        }

        public static void serverListener()
        {
            while (!fim)
            {
                TcpClient client = tcpServer.AcceptTcpClient();
                Thread thread = new Thread(() => responseMessage(client));
                thread.Start();
            }
        }

        public static void responseMessage(TcpClient client)
        {
            Console.WriteLine(client.Client.RemoteEndPoint);
            NetworkStream stream = client.GetStream();
            bool conectado = true;

            // Envia o menu logo no início
            string menu = "Escolha a área:\n1 - Quarto 1\n2 - Quarto 2\n3 - Área da Piscina\n4 - Sala\n5 - Cozinha\nDigite 'sair' para encerrar.";
            sendTCPMessage(client, menu);

            while (conectado)
            {
                try
                {
                    string msg = receiveTCPMessage(client);
                    if (msg.Trim().ToLower() == "sair")
                    {
                        conectado = false;
                        sendTCPMessage(client, "Conexão encerrada pelo cliente.");
                        break;
                    }

                    Console.WriteLine("Recebido: " + msg);
                    string resposta = parseMsg(msg);
                    sendTCPMessage(client, resposta);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    conectado = false;
                }
            }

            client.Close();
        }

        
        private static string parseMsg(string msg)
        {
            string resposta = "";

            if (int.TryParse(msg.Trim(), out int area))
            {
                switch (area)
                {
                    case 1:
                        resposta = "Quarto 1:\nTemperatura: 26°C\nUmidade: 61%\nAs luzes estão acesas.\nHá presença no Quarto.";
                        break;
                    case 2:
                        resposta = "Quarto 2:\nTemperatura: 20°C\nUmidade: 53%\nAs luzes estão apagadas.\nNão há presença no Quarto.";
                        break;
                    case 3:
                        resposta = "Área da Piscina:\nTemperatura: 32°C\nUmidade: 72%\nHá presença na Área da piscina.\nO aquecedor está desligado.\nA bomba está ligada.";
                        break;
                    case 4:
                        resposta = "Sala:\nTemperatura: 29°C\nUmidade: 67%\nAs luzes estão acesas.\nNão há presença na Sala.";
                        break;
                    case 5:
                        resposta = "Cozinha:\nTemperatura: 28°C\nUmidade: 65%\nAs luzes estão apagadas.\nNão há presença na Cozinha.";
                        break;
                    default:
                        resposta = "Área inválida. Tente novamente.";
                        break;
                }
            }

            return resposta;
        }

        public static string receiveTCPMessage(TcpClient tcpClient)
        {
            string TCPMsg = "";
            int i;

            NetworkStream stream = tcpClient.GetStream();
            Byte[] byteMsg = new Byte[tcpClient.ReceiveBufferSize];
            int tentativa = 0;
            while (!stream.DataAvailable && tentativa < 10)
            {
                Thread.Sleep(50);
                tentativa++;
            }

            while (stream.DataAvailable)
            {
                i = stream.Read(byteMsg, 0, byteMsg.Length);
                TCPMsg += Encoding.ASCII.GetString(byteMsg, 0, i);
            }

            return TCPMsg;
        }

        public static void sendTCPMessage(TcpClient tcpClient, string msg)
        {
            NetworkStream stream = tcpClient.GetStream();
            Byte[] byteMsg = Encoding.UTF8.GetBytes(msg);
            if (stream.CanWrite)
            {
                stream.Write(byteMsg, 0, byteMsg.Length);
                stream.Flush();
            }
            else
            {
                throw new Exception("Problema de Comunicação!!!");
            }
        }

    }
}
