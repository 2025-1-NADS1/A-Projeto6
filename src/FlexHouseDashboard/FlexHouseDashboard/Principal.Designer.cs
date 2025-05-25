using System.Drawing;
using System.Windows.Forms;

namespace FlexHouseDashboard
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnNotif = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTroca = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnLogoff);
            this.panel1.Controls.Add(this.btnNotif);
            this.panel1.Controls.Add(this.btnConsumo);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogoff.FlatAppearance.BorderSize = 0;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogoff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoff.Image")));
            this.btnLogoff.Location = new System.Drawing.Point(0, 463);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(116, 66);
            this.btnLogoff.TabIndex = 4;
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click_1);
            // 
            // btnNotif
            // 
            this.btnNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotif.FlatAppearance.BorderSize = 0;
            this.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotif.Image = ((System.Drawing.Image)(resources.GetObject("btnNotif.Image")));
            this.btnNotif.Location = new System.Drawing.Point(0, 182);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(116, 59);
            this.btnNotif.TabIndex = 3;
            this.btnNotif.UseVisualStyleBackColor = true;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click_1);
            // 
            // btnConsumo
            // 
            this.btnConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumo.FlatAppearance.BorderSize = 0;
            this.btnConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsumo.Image")));
            this.btnConsumo.Location = new System.Drawing.Point(0, 133);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(116, 49);
            this.btnConsumo.TabIndex = 2;
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.Location = new System.Drawing.Point(0, 87);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(116, 46);
            this.btnDash.TabIndex = 0;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 87);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(116, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 52);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(534, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(134, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bem vindo ao FlexHouse!";
            // 
            // panelTroca
            // 
            this.panelTroca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelTroca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTroca.Location = new System.Drawing.Point(116, 52);
            this.panelTroca.Name = "panelTroca";
            this.panelTroca.Size = new System.Drawing.Size(592, 477);
            this.panelTroca.TabIndex = 2;
            this.panelTroca.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTroca_Paint_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(708, 529);
            this.Controls.Add(this.panelTroca);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelTroca;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnNotif;
        private Button btnConsumo;
        private Button btnDash;
        private Button btnLogoff;
        private Label label2;
        private PictureBox pictureBox2;
    }
}

