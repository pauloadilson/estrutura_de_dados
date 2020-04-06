namespace _001_Pilhas
{
    partial class Ex08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex08));
            this.LValor = new System.Windows.Forms.Label();
            this.BTInsere = new System.Windows.Forms.Button();
            this.TBNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.LFMen = new System.Windows.Forms.Label();
            this.BTProcessa = new System.Windows.Forms.Button();
            this.LBNumeros = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.BackColor = System.Drawing.Color.Transparent;
            this.LValor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValor.Location = new System.Drawing.Point(11, 58);
            this.LValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(67, 19);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Número:";
            // 
            // BTInsere
            // 
            this.BTInsere.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTInsere.FlatAppearance.BorderSize = 0;
            this.BTInsere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInsere.Location = new System.Drawing.Point(231, 51);
            this.BTInsere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTInsere.Name = "BTInsere";
            this.BTInsere.Size = new System.Drawing.Size(110, 32);
            this.BTInsere.TabIndex = 2;
            this.BTInsere.Text = "Insere";
            this.BTInsere.UseVisualStyleBackColor = false;
            this.BTInsere.Click += new System.EventHandler(this.BTInsere_Click);
            // 
            // TBNum
            // 
            this.TBNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNum.Location = new System.Drawing.Point(86, 56);
            this.TBNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNum.Name = "TBNum";
            this.TBNum.Size = new System.Drawing.Size(125, 22);
            this.TBNum.TabIndex = 1;
            this.TBNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBNum_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 37);
            this.panel1.TabIndex = 7;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.BackColor = System.Drawing.Color.Transparent;
            this.LTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(7, 10);
            this.LTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(81, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Estatística";
            // 
            // LFMen
            // 
            this.LFMen.AutoSize = true;
            this.LFMen.BackColor = System.Drawing.Color.Transparent;
            this.LFMen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFMen.Location = new System.Drawing.Point(143, 159);
            this.LFMen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFMen.Name = "LFMen";
            this.LFMen.Size = new System.Drawing.Size(83, 19);
            this.LFMen.TabIndex = 0;
            this.LFMen.Text = "Resultados";
            // 
            // BTProcessa
            // 
            this.BTProcessa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTProcessa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTProcessa.FlatAppearance.BorderSize = 0;
            this.BTProcessa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTProcessa.Location = new System.Drawing.Point(124, 103);
            this.BTProcessa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTProcessa.Name = "BTProcessa";
            this.BTProcessa.Size = new System.Drawing.Size(120, 32);
            this.BTProcessa.TabIndex = 3;
            this.BTProcessa.Text = "Processa";
            this.BTProcessa.UseVisualStyleBackColor = false;
            this.BTProcessa.Click += new System.EventHandler(this.BTProcessa_Click);
            // 
            // LBNumeros
            // 
            this.LBNumeros.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNumeros.FormattingEnabled = true;
            this.LBNumeros.ItemHeight = 16;
            this.LBNumeros.Location = new System.Drawing.Point(101, 191);
            this.LBNumeros.Name = "LBNumeros";
            this.LBNumeros.Size = new System.Drawing.Size(167, 100);
            this.LBNumeros.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.TBNum);
            this.panel2.Controls.Add(this.BTInsere);
            this.panel2.Controls.Add(this.LValor);
            this.panel2.Controls.Add(this.LFMen);
            this.panel2.Controls.Add(this.BTProcessa);
            this.panel2.Controls.Add(this.LBNumeros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 337);
            this.panel2.TabIndex = 9;
            // 
            // Ex08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ex08";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.Button BTInsere;
        private System.Windows.Forms.TextBox TBNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LFMen;
        private System.Windows.Forms.Button BTProcessa;
        private System.Windows.Forms.ListBox LBNumeros;
        private System.Windows.Forms.Panel panel2;

        // COPIAR ATÉ DAQUI
    }
}