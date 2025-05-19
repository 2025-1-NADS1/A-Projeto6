using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FormsEntrega2
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        string ipServidor = "127.0.0.1";

        public Form1()
        {
            InitializeComponent();
        }

        private void Conectar()
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    client = new TcpClient();
                    client.Connect(ipServidor, 80);
                    stream = client.GetStream();

                    // Recebe o menu inicial
                    //string menu = ReceberMensagem();
                    //txtResposta.Text = menu + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void EnviarEscolha(string escolha)
        {
            try
            {
                if (stream == null) return;

                EnviarMensagem(escolha);
                string resposta = ReceberMensagem();
                txtResposta.AppendText(Environment.NewLine + resposta + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar/receber: " + ex.Message);
            }
        }

        private void EnviarMensagem(string msg)
        {
            byte[] dados = Encoding.UTF8.GetBytes(msg);
            stream.Write(dados, 0, dados.Length);
            stream.Flush();
        }

        private string ReceberMensagem()
        {
            byte[] buffer = new byte[1024];
            int tentativas = 0;

            while (!stream.DataAvailable && tentativas < 10)
            {
                Thread.Sleep(50);
                tentativas++;
            }

            int bytesLidos = stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesLidos);
        }

        // Eventos de clique dos botões
        private void btnQuarto1_Click(object sender, EventArgs e)
        {
            Conectar();
            EnviarEscolha("1");
        }

        private void btnQuarto2_Click(object sender, EventArgs e)
        {
            Conectar();
            EnviarEscolha("2");
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            Conectar();
            EnviarEscolha("4");
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Conectar();
            EnviarEscolha("5");
        }

        private void btnPiscina_Click(object sender, EventArgs e)
        {
            Conectar();
            EnviarEscolha("3");
        }

        // Opcional: Encerrar conexão ao fechar o programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (stream != null)
                {
                    EnviarMensagem("sair");
                    stream.Close();
                    client.Close();
                }
            }
            catch { }
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
