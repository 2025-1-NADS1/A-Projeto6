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
            //string menu = "Escolha a área:\n1 - Quarto 1\n2 - Quarto 2\n3 - Área da Piscina\n4 - Sala\n5 - Cozinha\nDigite 'sair' para encerrar.";
            //sendTCPMessage(client, menu);

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
                        resposta = "QUARTO 1\r\nTemperatura: 26°C\r\nUmidade: 61%\r\nAs luzes estão acesas.\r\nHá presença no Quarto.";
                        break;
                    case 2:
                        resposta = "QUARTO 2\r\nTemperatura: 20°C\r\nUmidade: 53%\r\nAs luzes estão apagadas.\r\nNão há presença no Quarto.";
                        break;
                    case 3:
                        resposta = "ÁREA DA PISCINA\r\nTemperatura: 32°C\r\nUmidade: 72%\r\nHá presença na Área da piscina.\r\nO aquecedor está desligado.\r\nA bomba está ligada.";
                        break;
                    case 4:
                        resposta = "SALA\r\nTemperatura: 29°C\r\nUmidade: 67%\r\nAs luzes estão acesas.\r\nNão há presença na Sala.";
                        break;
                    case 5:
                        resposta = "COZINHA\r\nTemperatura: 28°C\r\nUmidade: 65%\r\nAs luzes estão apagadas.\r\nNão há presença na Cozinha.";
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
