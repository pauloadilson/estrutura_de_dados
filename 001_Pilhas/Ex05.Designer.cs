namespace _001_Pilhas
{
    partial class Ex05
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

        // COPIAR A PARTIR DAQUI
        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex05));
            this.LExpressao = new System.Windows.Forms.Label();
            this.BTProcessa = new System.Windows.Forms.Button();
            this.TBExpressao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.LResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LExpressao
            // 
            this.LExpressao.AutoSize = true;
            this.LExpressao.BackColor = System.Drawing.Color.Transparent;
            this.LExpressao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LExpressao.Location = new System.Drawing.Point(12, 54);
            this.LExpressao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LExpressao.Name = "LExpressao";
            this.LExpressao.Size = new System.Drawing.Size(80, 19);
            this.LExpressao.TabIndex = 0;
            this.LExpressao.Text = "Expressão:";
            // 
            // BTProcessa
            // 
            this.BTProcessa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTProcessa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTProcessa.FlatAppearance.BorderSize = 0;
            this.BTProcessa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTProcessa.Location = new System.Drawing.Point(296, 46);
            this.BTProcessa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTProcessa.Name = "BTProcessa";
            this.BTProcessa.Size = new System.Drawing.Size(97, 32);
            this.BTProcessa.TabIndex = 2;
            this.BTProcessa.Text = "Processa";
            this.BTProcessa.UseVisualStyleBackColor = false;
            this.BTProcessa.Click += new System.EventHandler(this.BTProcessa_Click);
            // 
            // TBExpressao
            // 
            this.TBExpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBExpressao.Location = new System.Drawing.Point(89, 52);
            this.TBExpressao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBExpressao.Name = "TBExpressao";
            this.TBExpressao.Size = new System.Drawing.Size(174, 22);
            this.TBExpressao.TabIndex = 5;
            this.TBExpressao.Text = "a = b + (c -d) * (e – f)";
            this.TBExpressao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 37);
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
            this.LTitle.Size = new System.Drawing.Size(147, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Analisa Expressão";
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.BackColor = System.Drawing.Color.Transparent;
            this.LResultado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultado.Location = new System.Drawing.Point(450, 54);
            this.LResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(78, 19);
            this.LResultado.TabIndex = 0;
            this.LResultado.Text = "Resultado";
            // 
            // Ex05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 102);
            this.Controls.Add(this.TBExpressao);
            this.Controls.Add(this.BTProcessa);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.LExpressao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ex05";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LExpressao;
        private System.Windows.Forms.Button BTProcessa;
        private System.Windows.Forms.TextBox TBExpressao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LResultado;

        // COPIAR ATÉ DAQUI

    }
}