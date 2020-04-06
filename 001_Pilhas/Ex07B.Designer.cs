namespace _001_Pilhas
{
    partial class Ex07B
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LValor = new System.Windows.Forms.Label();
            this.BTInsereFila = new System.Windows.Forms.Button();
            this.TBValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBValorP = new System.Windows.Forms.TextBox();
            this.LFMen = new System.Windows.Forms.Label();
            this.BTDivide2Filas = new System.Windows.Forms.Button();
            this.BTExibeFilas = new System.Windows.Forms.Button();
            this.LBNumMenores = new System.Windows.Forms.ListBox();
            this.LBNumMaiores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.LValor.Location = new System.Drawing.Point(15, 70);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(59, 21);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Valor:";
            // 
            // BTInsereFila
            // 
            this.BTInsereFila.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTInsereFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTInsereFila.FlatAppearance.BorderSize = 0;
            this.BTInsereFila.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInsereFila.Location = new System.Drawing.Point(341, 62);
            this.BTInsereFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTInsereFila.Name = "BTInsereFila";
            this.BTInsereFila.Size = new System.Drawing.Size(212, 39);
            this.BTInsereFila.TabIndex = 2;
            this.BTInsereFila.Text = "Insere na fila";
            this.BTInsereFila.UseVisualStyleBackColor = false;
            this.BTInsereFila.Click += new System.EventHandler(this.BTInsereFila_Click);
            // 
            // TBValor
            // 
            this.TBValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValor.Location = new System.Drawing.Point(145, 69);
            this.TBValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBValor.Name = "TBValor";
            this.TBValor.Size = new System.Drawing.Size(165, 26);
            this.TBValor.TabIndex = 1;
            this.TBValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBValor_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 46);
            this.panel1.TabIndex = 7;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.BackColor = System.Drawing.Color.Transparent;
            this.LTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(9, 12);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(160, 29);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Divide Fila B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor p:";
            // 
            // TBValorP
            // 
            this.TBValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValorP.Location = new System.Drawing.Point(145, 116);
            this.TBValorP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBValorP.Name = "TBValorP";
            this.TBValorP.Size = new System.Drawing.Size(165, 26);
            this.TBValorP.TabIndex = 3;
            this.TBValorP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBValorP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBValorP_KeyDown);
            // 
            // LFMen
            // 
            this.LFMen.AutoSize = true;
            this.LFMen.BackColor = System.Drawing.Color.Transparent;
            this.LFMen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFMen.Location = new System.Drawing.Point(40, 238);
            this.LFMen.Name = "LFMen";
            this.LFMen.Size = new System.Drawing.Size(195, 21);
            this.LFMen.TabIndex = 0;
            this.LFMen.Text = "Filha números menores";
            // 
            // BTDivide2Filas
            // 
            this.BTDivide2Filas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTDivide2Filas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTDivide2Filas.FlatAppearance.BorderSize = 0;
            this.BTDivide2Filas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDivide2Filas.Location = new System.Drawing.Point(341, 108);
            this.BTDivide2Filas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTDivide2Filas.Name = "BTDivide2Filas";
            this.BTDivide2Filas.Size = new System.Drawing.Size(212, 39);
            this.BTDivide2Filas.TabIndex = 4;
            this.BTDivide2Filas.Text = "Divide em 2 filas";
            this.BTDivide2Filas.UseVisualStyleBackColor = false;
            this.BTDivide2Filas.Click += new System.EventHandler(this.BTDivide2Filas_Click);
            // 
            // BTExibeFilas
            // 
            this.BTExibeFilas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTExibeFilas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTExibeFilas.FlatAppearance.BorderSize = 0;
            this.BTExibeFilas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTExibeFilas.Location = new System.Drawing.Point(197, 176);
            this.BTExibeFilas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTExibeFilas.Name = "BTExibeFilas";
            this.BTExibeFilas.Size = new System.Drawing.Size(196, 39);
            this.BTExibeFilas.TabIndex = 5;
            this.BTExibeFilas.Text = "Exibe filas";
            this.BTExibeFilas.UseVisualStyleBackColor = false;
            this.BTExibeFilas.Click += new System.EventHandler(this.BTExibeFilas_Click);
            // 
            // LBNumMenores
            // 
            this.LBNumMenores.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNumMenores.FormattingEnabled = true;
            this.LBNumMenores.ItemHeight = 20;
            this.LBNumMenores.Location = new System.Drawing.Point(45, 277);
            this.LBNumMenores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBNumMenores.Name = "LBNumMenores";
            this.LBNumMenores.Size = new System.Drawing.Size(221, 104);
            this.LBNumMenores.TabIndex = 6;
            // 
            // LBNumMaiores
            // 
            this.LBNumMaiores.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNumMaiores.FormattingEnabled = true;
            this.LBNumMaiores.ItemHeight = 20;
            this.LBNumMaiores.Location = new System.Drawing.Point(341, 277);
            this.LBNumMaiores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBNumMaiores.Name = "LBNumMaiores";
            this.LBNumMaiores.Size = new System.Drawing.Size(221, 104);
            this.LBNumMaiores.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filha números maiores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.TBValor);
            this.panel2.Controls.Add(this.BTInsereFila);
            this.panel2.Controls.Add(this.TBValorP);
            this.panel2.Controls.Add(this.BTDivide2Filas);
            this.panel2.Controls.Add(this.LValor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LFMen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BTExibeFilas);
            this.panel2.Controls.Add(this.LBNumMenores);
            this.panel2.Controls.Add(this.LBNumMaiores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 466);
            this.panel2.TabIndex = 9;
            // 
            // Ex07B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ex07B";
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
        private System.Windows.Forms.TextBox TBValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBValorP;
        private System.Windows.Forms.Label LFMen;
        private System.Windows.Forms.Button BTDivide2Filas;
        private System.Windows.Forms.Button BTExibeFilas;
        private System.Windows.Forms.ListBox LBNumMenores;
        private System.Windows.Forms.ListBox LBNumMaiores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;

        // COPIAR ATÉ DAQUI

    }
}