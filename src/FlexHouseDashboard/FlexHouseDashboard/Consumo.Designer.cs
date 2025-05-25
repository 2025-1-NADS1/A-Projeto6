partial class Consumo
{
    private void InitializeComponent()
    {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnComodoAnt = new FrameworkTest.SATAButton();
            this.btnProxComodo = new FrameworkTest.SATAButton();
            this.btnProxMes = new FrameworkTest.SATAButton();
            this.btnMesAnt = new FrameworkTest.SATAButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea3.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea3);
            this.grafico.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend3.Name = "Legend1";
            this.grafico.Legends.Add(legend3);
            this.grafico.Location = new System.Drawing.Point(-35, 8);
            this.grafico.Name = "grafico";
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.grafico.Series.Add(series3);
            this.grafico.Size = new System.Drawing.Size(658, 463);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // btnComodoAnt
            // 
            this.btnComodoAnt.ButtonText = "Cômodo Anterior";
            this.btnComodoAnt.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComodoAnt.CheckedForeColor = System.Drawing.Color.White;
            this.btnComodoAnt.CheckedImageTint = System.Drawing.Color.White;
            this.btnComodoAnt.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnComodoAnt.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComodoAnt.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnComodoAnt.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnComodoAnt.HoverForeColor = System.Drawing.Color.White;
            this.btnComodoAnt.HoverImage = null;
            this.btnComodoAnt.HoverImageTint = System.Drawing.Color.White;
            this.btnComodoAnt.HoverOutline = System.Drawing.Color.Empty;
            this.btnComodoAnt.Image = null;
            this.btnComodoAnt.ImageAutoCenter = true;
            this.btnComodoAnt.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnComodoAnt.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnComodoAnt.ImageTint = System.Drawing.Color.White;
            this.btnComodoAnt.IsToggleButton = false;
            this.btnComodoAnt.IsToggled = false;
            this.btnComodoAnt.Location = new System.Drawing.Point(49, 445);
            this.btnComodoAnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnComodoAnt.Name = "btnComodoAnt";
            this.btnComodoAnt.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComodoAnt.NormalForeColor = System.Drawing.Color.White;
            this.btnComodoAnt.NormalOutline = System.Drawing.Color.Empty;
            this.btnComodoAnt.OutlineThickness = 2F;
            this.btnComodoAnt.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnComodoAnt.PressedForeColor = System.Drawing.Color.White;
            this.btnComodoAnt.PressedImageTint = System.Drawing.Color.White;
            this.btnComodoAnt.PressedOutline = System.Drawing.Color.Empty;
            this.btnComodoAnt.Rounding = new System.Windows.Forms.Padding(5);
            this.btnComodoAnt.Size = new System.Drawing.Size(116, 32);
            this.btnComodoAnt.TabIndex = 5;
            this.btnComodoAnt.TextAutoCenter = true;
            this.btnComodoAnt.TextOffset = new System.Drawing.Point(0, 0);
            this.btnComodoAnt.Click += new System.EventHandler(this.btnComodoAnt_Click);
            // 
            // btnProxComodo
            // 
            this.btnProxComodo.ButtonText = "Próximo Cômodo";
            this.btnProxComodo.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnProxComodo.CheckedForeColor = System.Drawing.Color.White;
            this.btnProxComodo.CheckedImageTint = System.Drawing.Color.White;
            this.btnProxComodo.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnProxComodo.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProxComodo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnProxComodo.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnProxComodo.HoverForeColor = System.Drawing.Color.White;
            this.btnProxComodo.HoverImage = null;
            this.btnProxComodo.HoverImageTint = System.Drawing.Color.White;
            this.btnProxComodo.HoverOutline = System.Drawing.Color.Empty;
            this.btnProxComodo.Image = null;
            this.btnProxComodo.ImageAutoCenter = true;
            this.btnProxComodo.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnProxComodo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnProxComodo.ImageTint = System.Drawing.Color.White;
            this.btnProxComodo.IsToggleButton = false;
            this.btnProxComodo.IsToggled = false;
            this.btnProxComodo.Location = new System.Drawing.Point(173, 445);
            this.btnProxComodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProxComodo.Name = "btnProxComodo";
            this.btnProxComodo.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProxComodo.NormalForeColor = System.Drawing.Color.White;
            this.btnProxComodo.NormalOutline = System.Drawing.Color.Empty;
            this.btnProxComodo.OutlineThickness = 2F;
            this.btnProxComodo.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnProxComodo.PressedForeColor = System.Drawing.Color.White;
            this.btnProxComodo.PressedImageTint = System.Drawing.Color.White;
            this.btnProxComodo.PressedOutline = System.Drawing.Color.Empty;
            this.btnProxComodo.Rounding = new System.Windows.Forms.Padding(5);
            this.btnProxComodo.Size = new System.Drawing.Size(118, 32);
            this.btnProxComodo.TabIndex = 6;
            this.btnProxComodo.TextAutoCenter = true;
            this.btnProxComodo.TextOffset = new System.Drawing.Point(0, 0);
            this.btnProxComodo.Click += new System.EventHandler(this.btnProxComodo_Click);
            // 
            // btnProxMes
            // 
            this.btnProxMes.ButtonText = "Próximo Mês";
            this.btnProxMes.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnProxMes.CheckedForeColor = System.Drawing.Color.White;
            this.btnProxMes.CheckedImageTint = System.Drawing.Color.White;
            this.btnProxMes.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnProxMes.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProxMes.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnProxMes.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnProxMes.HoverForeColor = System.Drawing.Color.White;
            this.btnProxMes.HoverImage = null;
            this.btnProxMes.HoverImageTint = System.Drawing.Color.White;
            this.btnProxMes.HoverOutline = System.Drawing.Color.Empty;
            this.btnProxMes.Image = null;
            this.btnProxMes.ImageAutoCenter = true;
            this.btnProxMes.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnProxMes.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnProxMes.ImageTint = System.Drawing.Color.White;
            this.btnProxMes.IsToggleButton = false;
            this.btnProxMes.IsToggled = false;
            this.btnProxMes.Location = new System.Drawing.Point(405, 445);
            this.btnProxMes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProxMes.Name = "btnProxMes";
            this.btnProxMes.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProxMes.NormalForeColor = System.Drawing.Color.White;
            this.btnProxMes.NormalOutline = System.Drawing.Color.Empty;
            this.btnProxMes.OutlineThickness = 2F;
            this.btnProxMes.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnProxMes.PressedForeColor = System.Drawing.Color.White;
            this.btnProxMes.PressedImageTint = System.Drawing.Color.White;
            this.btnProxMes.PressedOutline = System.Drawing.Color.Empty;
            this.btnProxMes.Rounding = new System.Windows.Forms.Padding(5);
            this.btnProxMes.Size = new System.Drawing.Size(92, 32);
            this.btnProxMes.TabIndex = 7;
            this.btnProxMes.TextAutoCenter = true;
            this.btnProxMes.TextOffset = new System.Drawing.Point(0, 0);
            this.btnProxMes.Click += new System.EventHandler(this.btnProxMes_Click);
            // 
            // btnMesAnt
            // 
            this.btnMesAnt.ButtonText = "Mês Anterior";
            this.btnMesAnt.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnMesAnt.CheckedForeColor = System.Drawing.Color.White;
            this.btnMesAnt.CheckedImageTint = System.Drawing.Color.White;
            this.btnMesAnt.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnMesAnt.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMesAnt.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMesAnt.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMesAnt.HoverForeColor = System.Drawing.Color.White;
            this.btnMesAnt.HoverImage = null;
            this.btnMesAnt.HoverImageTint = System.Drawing.Color.White;
            this.btnMesAnt.HoverOutline = System.Drawing.Color.Empty;
            this.btnMesAnt.Image = null;
            this.btnMesAnt.ImageAutoCenter = true;
            this.btnMesAnt.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMesAnt.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMesAnt.ImageTint = System.Drawing.Color.White;
            this.btnMesAnt.IsToggleButton = false;
            this.btnMesAnt.IsToggled = false;
            this.btnMesAnt.Location = new System.Drawing.Point(300, 445);
            this.btnMesAnt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnMesAnt.Name = "btnMesAnt";
            this.btnMesAnt.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMesAnt.NormalForeColor = System.Drawing.Color.White;
            this.btnMesAnt.NormalOutline = System.Drawing.Color.Empty;
            this.btnMesAnt.OutlineThickness = 2F;
            this.btnMesAnt.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnMesAnt.PressedForeColor = System.Drawing.Color.White;
            this.btnMesAnt.PressedImageTint = System.Drawing.Color.White;
            this.btnMesAnt.PressedOutline = System.Drawing.Color.Empty;
            this.btnMesAnt.Rounding = new System.Windows.Forms.Padding(5);
            this.btnMesAnt.Size = new System.Drawing.Size(96, 32);
            this.btnMesAnt.TabIndex = 8;
            this.btnMesAnt.TextAutoCenter = true;
            this.btnMesAnt.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMesAnt.Click += new System.EventHandler(this.btnMesAnt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(207, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gasto mensal";
            // 
            // Consumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(592, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMesAnt);
            this.Controls.Add(this.btnProxMes);
            this.Controls.Add(this.btnProxComodo);
            this.Controls.Add(this.btnComodoAnt);
            this.Controls.Add(this.grafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consumo";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
    private FrameworkTest.SATAButton btnComodoAnt;
    private FrameworkTest.SATAButton btnProxComodo;
    private FrameworkTest.SATAButton btnProxMes;
    private FrameworkTest.SATAButton btnMesAnt;
    private System.Windows.Forms.Label label2;
}
