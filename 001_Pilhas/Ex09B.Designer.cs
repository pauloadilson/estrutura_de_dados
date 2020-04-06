namespace _001_Pilhas
{
    partial class Ex09B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex09B));
            this.LValor = new System.Windows.Forms.Label();
            this.BTInsereFila = new System.Windows.Forms.Button();
            this.TBAviao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.TBQtdeFila = new System.Windows.Forms.TextBox();
            this.BTQtdeFila = new System.Windows.Forms.Button();
            this.BTAvioesFila = new System.Windows.Forms.Button();
            this.LBAvioesFila = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTAutorizaDec = new System.Windows.Forms.Button();
            this.TBAutorizaDec = new System.Windows.Forms.TextBox();
            this.BTPrimeiroFila = new System.Windows.Forms.Button();
            this.TBPrimeiroFila = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.BackColor = System.Drawing.Color.Transparent;
            this.LValor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValor.Location = new System.Drawing.Point(15, 71);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(48, 19);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Avião";
            // 
            // BTInsereFila
            // 
            this.BTInsereFila.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTInsereFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTInsereFila.FlatAppearance.BorderSize = 0;
            this.BTInsereFila.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInsereFila.Location = new System.Drawing.Point(315, 63);
            this.BTInsereFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTInsereFila.Name = "BTInsereFila";
            this.BTInsereFila.Size = new System.Drawing.Size(212, 39);
            this.BTInsereFila.TabIndex = 2;
            this.BTInsereFila.Text = "Insere na fila";
            this.BTInsereFila.UseVisualStyleBackColor = false;
            this.BTInsereFila.Click += new System.EventHandler(this.BTInsereFila_Click);
            // 
            // TBAviao
            // 
            this.TBAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAviao.Location = new System.Drawing.Point(113, 69);
            this.TBAviao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBAviao.Name = "TBAviao";
            this.TBAviao.Size = new System.Drawing.Size(165, 22);
            this.TBAviao.TabIndex = 5;
            this.TBAviao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBAviao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBAviao_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 46);
            this.panel1.TabIndex = 7;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.BackColor = System.Drawing.Color.Transparent;
            this.LTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(9, 12);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(150, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Controle de Pista B";
            // 
            // TBQtdeFila
            // 
            this.TBQtdeFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBQtdeFila.Location = new System.Drawing.Point(299, 146);
            this.TBQtdeFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBQtdeFila.Name = "TBQtdeFila";
            this.TBQtdeFila.Size = new System.Drawing.Size(227, 22);
            this.TBQtdeFila.TabIndex = 5;
            this.TBQtdeFila.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTQtdeFila
            // 
            this.BTQtdeFila.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTQtdeFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTQtdeFila.FlatAppearance.BorderSize = 0;
            this.BTQtdeFila.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTQtdeFila.Location = new System.Drawing.Point(20, 139);
            this.BTQtdeFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTQtdeFila.Name = "BTQtdeFila";
            this.BTQtdeFila.Size = new System.Drawing.Size(212, 39);
            this.BTQtdeFila.TabIndex = 2;
            this.BTQtdeFila.Text = "Quantidade na fila";
            this.BTQtdeFila.UseVisualStyleBackColor = false;
            this.BTQtdeFila.Click += new System.EventHandler(this.BTQtdeFila_Click);
            // 
            // BTAvioesFila
            // 
            this.BTAvioesFila.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTAvioesFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTAvioesFila.FlatAppearance.BorderSize = 0;
            this.BTAvioesFila.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAvioesFila.Location = new System.Drawing.Point(611, 110);
            this.BTAvioesFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTAvioesFila.Name = "BTAvioesFila";
            this.BTAvioesFila.Size = new System.Drawing.Size(196, 39);
            this.BTAvioesFila.TabIndex = 2;
            this.BTAvioesFila.Text = "Aviões na fila";
            this.BTAvioesFila.UseVisualStyleBackColor = false;
            this.BTAvioesFila.Click += new System.EventHandler(this.BTAvioesFila_Click);
            // 
            // LBAvioesFila
            // 
            this.LBAvioesFila.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAvioesFila.FormattingEnabled = true;
            this.LBAvioesFila.ItemHeight = 16;
            this.LBAvioesFila.Location = new System.Drawing.Point(597, 165);
            this.LBAvioesFila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBAvioesFila.Name = "LBAvioesFila";
            this.LBAvioesFila.Size = new System.Drawing.Size(221, 132);
            this.LBAvioesFila.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.LValor);
            this.panel2.Controls.Add(this.TBAviao);
            this.panel2.Controls.Add(this.BTInsereFila);
            this.panel2.Controls.Add(this.BTQtdeFila);
            this.panel2.Controls.Add(this.TBQtdeFila);
            this.panel2.Controls.Add(this.BTAutorizaDec);
            this.panel2.Controls.Add(this.TBAutorizaDec);
            this.panel2.Controls.Add(this.BTPrimeiroFila);
            this.panel2.Controls.Add(this.TBPrimeiroFila);
            this.panel2.Controls.Add(this.BTAvioesFila);
            this.panel2.Controls.Add(this.LBAvioesFila);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 370);
            this.panel2.TabIndex = 9;
            // 
            // BTAutorizaDec
            // 
            this.BTAutorizaDec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTAutorizaDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTAutorizaDec.FlatAppearance.BorderSize = 0;
            this.BTAutorizaDec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAutorizaDec.Location = new System.Drawing.Point(20, 212);
            this.BTAutorizaDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTAutorizaDec.Name = "BTAutorizaDec";
            this.BTAutorizaDec.Size = new System.Drawing.Size(212, 39);
            this.BTAutorizaDec.TabIndex = 2;
            this.BTAutorizaDec.Text = "Autoriza decolagem";
            this.BTAutorizaDec.UseVisualStyleBackColor = false;
            this.BTAutorizaDec.Click += new System.EventHandler(this.BTAutorizaDec_Click);
            // 
            // TBAutorizaDec
            // 
            this.TBAutorizaDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAutorizaDec.Location = new System.Drawing.Point(299, 219);
            this.TBAutorizaDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBAutorizaDec.Name = "TBAutorizaDec";
            this.TBAutorizaDec.Size = new System.Drawing.Size(227, 22);
            this.TBAutorizaDec.TabIndex = 5;
            this.TBAutorizaDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTPrimeiroFila
            // 
            this.BTPrimeiroFila.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTPrimeiroFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTPrimeiroFila.FlatAppearance.BorderSize = 0;
            this.BTPrimeiroFila.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPrimeiroFila.Location = new System.Drawing.Point(20, 284);
            this.BTPrimeiroFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTPrimeiroFila.Name = "BTPrimeiroFila";
            this.BTPrimeiroFila.Size = new System.Drawing.Size(212, 39);
            this.BTPrimeiroFila.TabIndex = 2;
            this.BTPrimeiroFila.Text = "Primeiro da Fila";
            this.BTPrimeiroFila.UseVisualStyleBackColor = false;
            this.BTPrimeiroFila.Click += new System.EventHandler(this.BTPrimeiroFila_Click);
            // 
            // TBPrimeiroFila
            // 
            this.TBPrimeiroFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrimeiroFila.Location = new System.Drawing.Point(299, 292);
            this.TBPrimeiroFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPrimeiroFila.Name = "TBPrimeiroFila";
            this.TBPrimeiroFila.Size = new System.Drawing.Size(227, 22);
            this.TBPrimeiroFila.TabIndex = 5;
            this.TBPrimeiroFila.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ex09B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ex09B";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.Button BTInsereFila;
        private System.Windows.Forms.TextBox TBAviao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.TextBox TBQtdeFila;
        private System.Windows.Forms.Button BTQtdeFila;
        private System.Windows.Forms.Button BTAvioesFila;
        private System.Windows.Forms.ListBox LBAvioesFila;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTAutorizaDec;
        private System.Windows.Forms.TextBox TBAutorizaDec;
        private System.Windows.Forms.Button BTPrimeiroFila;
        private System.Windows.Forms.TextBox TBPrimeiroFila;

        // COPIAR ATÉ DAQUI
    }
}