using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CLIENTE
{
    class Program
    {
        static void Main(string[] args)
        {
            string IPServer = "127.0.0.1";
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(IPServer, 80);
                Console.WriteLine("Cliente conectado ao servidor.");
                NetworkStream stream = client.GetStream();

                // Recebe o menu inicial
                string menu = ReceiveMessage(stream);
                Console.WriteLine("\n" + menu);

                while (true)
                {
                    Console.Write("\nDigite sua escolha: ");
                    string entrada = Console.ReadLine()?.Trim();

                    SendMessage(stream, entrada);

                    string resposta = ReceiveMessage(stream);
                    Console.WriteLine("\n" + resposta);

                    if (entrada?.ToLower() == "sair")
                        break;
                }

                client.Close();
                Console.WriteLine("Cliente desconectado.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        static void SendMessage(NetworkStream stream, string msg)
        {
            Byte[] dados = Encoding.UTF8.GetBytes(msg);
            stream.Write(dados, 0, dados.Length);
            stream.Flush();
        }

        static string ReceiveMessage(NetworkStream stream)
        {
            Byte[] dadosLidos = new Byte[1024];
            int tentativas = 0;
            while (!stream.DataAvailable && tentativas < 10)
            {
                tentativas++;
                Thread.Sleep(10);
            }

            int numBytes = stream.Read(dadosLidos, 0, dadosLidos.Length);
            return Encoding.UTF8.GetString(dadosLidos, 0, numBytes);
        }
    }
}
