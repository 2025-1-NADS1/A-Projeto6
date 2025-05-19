namespace FormsEntrega2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            btnQuarto1 = new Button();
            btnQuarto2 = new Button();
            btnSala = new Button();
            btnCozinha = new Button();
            btnPiscina = new Button();
            txtResposta = new TextBox();
            lblTitulo = new Label();
            lblEscolha = new Label();
            SuspendLayout();
            // 
            // btnQuarto1
            // 
            btnQuarto1.BackColor = Color.Ivory;
            btnQuarto1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuarto1.Location = new Point(12, 81);
            btnQuarto1.Name = "btnQuarto1";
            btnQuarto1.Size = new Size(616, 50);
            btnQuarto1.TabIndex = 0;
            btnQuarto1.Text = "Quarto 1";
            btnQuarto1.UseVisualStyleBackColor = false;
            btnQuarto1.Click += btnQuarto1_Click;
            // 
            // btnQuarto2
            // 
            btnQuarto2.BackColor = Color.Ivory;
            btnQuarto2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuarto2.Location = new Point(12, 137);
            btnQuarto2.Name = "btnQuarto2";
            btnQuarto2.Size = new Size(616, 50);
            btnQuarto2.TabIndex = 1;
            btnQuarto2.Text = "Quarto 2";
            btnQuarto2.UseVisualStyleBackColor = false;
            btnQuarto2.Click += btnQuarto2_Click;
            // 
            // btnSala
            // 
            btnSala.BackColor = Color.Ivory;
            btnSala.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSala.Location = new Point(12, 193);
            btnSala.Name = "btnSala";
            btnSala.Size = new Size(616, 50);
            btnSala.TabIndex = 2;
            btnSala.Text = "Sala";
            btnSala.UseVisualStyleBackColor = false;
            btnSala.Click += btnSala_Click;
            // 
            // btnCozinha
            // 
            btnCozinha.BackColor = Color.Ivory;
            btnCozinha.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCozinha.Location = new Point(12, 249);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.Size = new Size(616, 50);
            btnCozinha.TabIndex = 3;
            btnCozinha.Text = "Cozinha";
            btnCozinha.UseVisualStyleBackColor = false;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // btnPiscina
            // 
            btnPiscina.BackColor = Color.Ivory;
            btnPiscina.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPiscina.Location = new Point(12, 305);
            btnPiscina.Name = "btnPiscina";
            btnPiscina.Size = new Size(616, 50);
            btnPiscina.TabIndex = 4;
            btnPiscina.Text = "Área da Piscina";
            btnPiscina.UseVisualStyleBackColor = false;
            btnPiscina.Click += btnPiscina_Click;
            // 
            // txtResposta
            // 
            txtResposta.BackColor = Color.Ivory;
            txtResposta.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResposta.Location = new Point(12, 361);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.ReadOnly = true;
            txtResposta.ScrollBars = ScrollBars.Vertical;
            txtResposta.Size = new Size(616, 176);
            txtResposta.TabIndex = 5;
            txtResposta.TextChanged += txtResposta_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 22.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(96, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(447, 35);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "MENU DE MONITORAMENTO";
            lblTitulo.Click += label1_Click;
            // 
            // lblEscolha
            // 
            lblEscolha.AutoSize = true;
            lblEscolha.Font = new Font("Times New Roman", 18.25F, FontStyle.Bold);
            lblEscolha.ForeColor = Color.White;
            lblEscolha.Location = new Point(186, 44);
            lblEscolha.Name = "lblEscolha";
            lblEscolha.Size = new Size(264, 29);
            lblEscolha.TabIndex = 7;
            lblEscolha.Text = "ESCOLHA SUA ÁREA";
            // 
            // Form1
            // 
            BackColor = Color.SeaGreen;
            ClientSize = new Size(640, 549);
            Controls.Add(lblEscolha);
            Controls.Add(lblTitulo);
            Controls.Add(btnQuarto1);
            Controls.Add(btnQuarto2);
            Controls.Add(btnSala);
            Controls.Add(btnCozinha);
            Controls.Add(btnPiscina);
            Controls.Add(txtResposta);
            Name = "Form1";
            Text = "Monitoramento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnQuarto1;
        private System.Windows.Forms.Button btnQuarto2;
        private System.Windows.Forms.Button btnSala;
        private System.Windows.Forms.Button btnCozinha;
        private System.Windows.Forms.Button btnPiscina;
        private System.Windows.Forms.TextBox txtResposta;
        private Label lblTitulo;
        private Label lblEscolha;
    }
}
