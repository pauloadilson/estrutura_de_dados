namespace _001_Pilhas
{
    partial class ProvaPilha
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

        #region Windows Form Designer generated code

        // COPIAR A PARTIR DAQUI

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nElements = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btInsere = new System.Windows.Forms.Button();
            this.btExibe = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nElements
            // 
            this.nElements.AutoSize = true;
            this.nElements.BackColor = System.Drawing.Color.Transparent;
            this.nElements.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nElements.Location = new System.Drawing.Point(79, 56);
            this.nElements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nElements.Name = "nElements";
            this.nElements.Size = new System.Drawing.Size(22, 19);
            this.nElements.TabIndex = 0;
            this.nElements.Text = "n:";
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(120, 54);
            this.tbValor.Margin = new System.Windows.Forms.Padding(2);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(155, 22);
            this.tbValor.TabIndex = 5;
            this.tbValor.Text = "3";
            this.tbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 37);
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
            this.LTitle.Size = new System.Drawing.Size(95, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Prova Pilha";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btExibe);
            this.panel2.Controls.Add(this.lbResultado);
            this.panel2.Controls.Add(this.tbValor);
            this.panel2.Controls.Add(this.btInsere);
            this.panel2.Controls.Add(this.nElements);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 240);
            this.panel2.TabIndex = 8;
            // 
            // btInsere
            // 
            this.btInsere.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInsere.FlatAppearance.BorderSize = 0;
            this.btInsere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsere.Location = new System.Drawing.Point(297, 49);
            this.btInsere.Margin = new System.Windows.Forms.Padding(2);
            this.btInsere.Name = "btInsere";
            this.btInsere.Size = new System.Drawing.Size(97, 32);
            this.btInsere.TabIndex = 2;
            this.btInsere.Text = "Insere";
            this.btInsere.UseVisualStyleBackColor = false;
            this.btInsere.Click += new System.EventHandler(this.btInsere_Click);
            // 
            // btExibe
            // 
            this.btExibe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExibe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExibe.FlatAppearance.BorderSize = 0;
            this.btExibe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibe.Location = new System.Drawing.Point(313, 90);
            this.btExibe.Margin = new System.Windows.Forms.Padding(2);
            this.btExibe.Name = "btExibe";
            this.btExibe.Size = new System.Drawing.Size(147, 32);
            this.btExibe.TabIndex = 7;
            this.btExibe.Text = "Exibe";
            this.btExibe.UseVisualStyleBackColor = false;
            this.btExibe.Click += new System.EventHandler(this.btExibe_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 16;
            this.lbResultado.Location = new System.Drawing.Point(313, 128);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(167, 100);
            this.lbResultado.TabIndex = 8;
            // 
            // ProvaPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProvaPilha";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nElements;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btInsere;
        private System.Windows.Forms.Button btExibe;
        private System.Windows.Forms.ListBox lbResultado;

        // COPIAR ATÉ DAQUI

    }
}