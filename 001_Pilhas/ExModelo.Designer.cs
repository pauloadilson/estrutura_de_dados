namespace _001_Pilhas
{
    partial class ExModelo
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
        // COPIAR A PARTIR DAQUI
        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
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
            this.LValor.Location = new System.Drawing.Point(11, 57);
            this.LValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(48, 19);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Valor:";
            // 
            // BTInsereFila
            // 
            this.BTInsereFila.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTInsereFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTInsereFila.FlatAppearance.BorderSize = 0;
            this.BTInsereFila.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInsereFila.Location = new System.Drawing.Point(256, 50);
            this.BTInsereFila.Margin = new System.Windows.Forms.Padding(2);
            this.BTInsereFila.Name = "BTInsereFila";
            this.BTInsereFila.Size = new System.Drawing.Size(159, 32);
            this.BTInsereFila.TabIndex = 2;
            this.BTInsereFila.Text = "Insere na fila";
            this.BTInsereFila.UseVisualStyleBackColor = false;
            // 
            // TBValor
            // 
            this.TBValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValor.Location = new System.Drawing.Point(109, 56);
            this.TBValor.Margin = new System.Windows.Forms.Padding(2);
            this.TBValor.Name = "TBValor";
            this.TBValor.Size = new System.Drawing.Size(125, 22);
            this.TBValor.TabIndex = 5;
            this.TBValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 37);
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
            this.LTitle.Size = new System.Drawing.Size(89, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Divide Fila";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor p:";
            // 
            // TBValorP
            // 
            this.TBValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValorP.Location = new System.Drawing.Point(109, 94);
            this.TBValorP.Margin = new System.Windows.Forms.Padding(2);
            this.TBValorP.Name = "TBValorP";
            this.TBValorP.Size = new System.Drawing.Size(125, 22);
            this.TBValorP.TabIndex = 5;
            this.TBValorP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LFMen
            // 
            this.LFMen.AutoSize = true;
            this.LFMen.BackColor = System.Drawing.Color.Transparent;
            this.LFMen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFMen.Location = new System.Drawing.Point(30, 193);
            this.LFMen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFMen.Name = "LFMen";
            this.LFMen.Size = new System.Drawing.Size(165, 19);
            this.LFMen.TabIndex = 0;
            this.LFMen.Text = "Filha números menores";
            // 
            // BTDivide2Filas
            // 
            this.BTDivide2Filas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTDivide2Filas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTDivide2Filas.FlatAppearance.BorderSize = 0;
            this.BTDivide2Filas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDivide2Filas.Location = new System.Drawing.Point(256, 88);
            this.BTDivide2Filas.Margin = new System.Windows.Forms.Padding(2);
            this.BTDivide2Filas.Name = "BTDivide2Filas";
            this.BTDivide2Filas.Size = new System.Drawing.Size(159, 32);
            this.BTDivide2Filas.TabIndex = 2;
            this.BTDivide2Filas.Text = "Divide em 2 filas";
            this.BTDivide2Filas.UseVisualStyleBackColor = false;
            // 
            // BTExibeFilas
            // 
            this.BTExibeFilas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTExibeFilas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTExibeFilas.FlatAppearance.BorderSize = 0;
            this.BTExibeFilas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTExibeFilas.Location = new System.Drawing.Point(148, 143);
            this.BTExibeFilas.Margin = new System.Windows.Forms.Padding(2);
            this.BTExibeFilas.Name = "BTExibeFilas";
            this.BTExibeFilas.Size = new System.Drawing.Size(147, 32);
            this.BTExibeFilas.TabIndex = 2;
            this.BTExibeFilas.Text = "Exibe filas";
            this.BTExibeFilas.UseVisualStyleBackColor = false;
            // 
            // LBNumMenores
            // 
            this.LBNumMenores.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNumMenores.FormattingEnabled = true;
            this.LBNumMenores.ItemHeight = 16;
            this.LBNumMenores.Location = new System.Drawing.Point(34, 225);
            this.LBNumMenores.Name = "LBNumMenores";
            this.LBNumMenores.Size = new System.Drawing.Size(167, 116);
            this.LBNumMenores.TabIndex = 8;
            // 
            // LBNumMaiores
            // 
            this.LBNumMaiores.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNumMaiores.FormattingEnabled = true;
            this.LBNumMaiores.ItemHeight = 16;
            this.LBNumMaiores.Location = new System.Drawing.Point(256, 225);
            this.LBNumMaiores.Name = "LBNumMaiores";
            this.LBNumMaiores.Size = new System.Drawing.Size(167, 116);
            this.LBNumMaiores.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 379);
            this.panel2.TabIndex = 9;
            // 
            // Ex07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex07";
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