namespace _001_Pilhas
{
    partial class Ex02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex02));
            this.LRecebeDecimal = new System.Windows.Forms.Label();
            this.LRecebeBinario = new System.Windows.Forms.Label();
            this.BConvert = new System.Windows.Forms.Button();
            this.TBNumBinary = new System.Windows.Forms.TextBox();
            this.TBNumDecimal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LConvBin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LRecebeDecimal
            // 
            this.LRecebeDecimal.AutoSize = true;
            this.LRecebeDecimal.BackColor = System.Drawing.Color.Transparent;
            this.LRecebeDecimal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecebeDecimal.Location = new System.Drawing.Point(32, 53);
            this.LRecebeDecimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRecebeDecimal.Name = "LRecebeDecimal";
            this.LRecebeDecimal.Size = new System.Drawing.Size(128, 19);
            this.LRecebeDecimal.TabIndex = 0;
            this.LRecebeDecimal.Text = "Número decimal:";
            // 
            // LRecebeBinario
            // 
            this.LRecebeBinario.AutoSize = true;
            this.LRecebeBinario.BackColor = System.Drawing.Color.Transparent;
            this.LRecebeBinario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecebeBinario.Location = new System.Drawing.Point(80, 123);
            this.LRecebeBinario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRecebeBinario.Name = "LRecebeBinario";
            this.LRecebeBinario.Size = new System.Drawing.Size(119, 19);
            this.LRecebeBinario.TabIndex = 1;
            this.LRecebeBinario.Text = "Número binário:";
            // 
            // BConvert
            // 
            this.BConvert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BConvert.FlatAppearance.BorderSize = 0;
            this.BConvert.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConvert.Location = new System.Drawing.Point(98, 86);
            this.BConvert.Margin = new System.Windows.Forms.Padding(2);
            this.BConvert.Name = "BConvert";
            this.BConvert.Size = new System.Drawing.Size(97, 32);
            this.BConvert.TabIndex = 2;
            this.BConvert.Text = "Converta";
            this.BConvert.UseVisualStyleBackColor = false;
            this.BConvert.Click += new System.EventHandler(this.BConvert_Click_1);
            // 
            // TBNumBinary
            // 
            this.TBNumBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumBinary.Location = new System.Drawing.Point(36, 147);
            this.TBNumBinary.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumBinary.Name = "TBNumBinary";
            this.TBNumBinary.Size = new System.Drawing.Size(220, 22);
            this.TBNumBinary.TabIndex = 4;
            this.TBNumBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNumDecimal
            // 
            this.TBNumDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumDecimal.Location = new System.Drawing.Point(180, 51);
            this.TBNumDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumDecimal.Name = "TBNumDecimal";
            this.TBNumDecimal.Size = new System.Drawing.Size(76, 22);
            this.TBNumDecimal.TabIndex = 5;
            this.TBNumDecimal.Text = "31";
            this.TBNumDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LConvBin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 37);
            this.panel1.TabIndex = 7;
            // 
            // LConvBin
            // 
            this.LConvBin.AutoSize = true;
            this.LConvBin.BackColor = System.Drawing.Color.Transparent;
            this.LConvBin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConvBin.Location = new System.Drawing.Point(7, 10);
            this.LConvBin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LConvBin.Name = "LConvBin";
            this.LConvBin.Size = new System.Drawing.Size(181, 19);
            this.LConvBin.TabIndex = 0;
            this.LConvBin.Text = "Converta para binário";
            // 
            // Ex02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 189);
            this.Controls.Add(this.TBNumDecimal);
            this.Controls.Add(this.TBNumBinary);
            this.Controls.Add(this.BConvert);
            this.Controls.Add(this.LRecebeBinario);
            this.Controls.Add(this.LRecebeDecimal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex02";
            this.Text = this.LConvBin.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LRecebeDecimal;
        private System.Windows.Forms.Label LRecebeBinario;
        private System.Windows.Forms.Button BConvert;
        private System.Windows.Forms.TextBox TBNumBinary;
        private System.Windows.Forms.TextBox TBNumDecimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LConvBin;
    }
}