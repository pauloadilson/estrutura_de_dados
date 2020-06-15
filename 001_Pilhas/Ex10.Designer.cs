namespace _001_Pilhas
{
    partial class Ex10
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
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LValor = new System.Windows.Forms.Label();
            this.btMostraSomatorio = new System.Windows.Forms.Button();
            this.TBNumInicial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.btOrdenaCrescente = new System.Windows.Forms.Button();
            this.btMostraImpares = new System.Windows.Forms.Button();
            this.LB_Resultado = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSomaVetor = new System.Windows.Forms.Button();
            this.btInsereNoVetor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.gbSemVetor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOrdenaDecrescente = new System.Windows.Forms.Button();
            this.TBNumFinal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSemVetor.SuspendLayout();
            this.SuspendLayout();
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.BackColor = System.Drawing.Color.Transparent;
            this.LValor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValor.Location = new System.Drawing.Point(16, 22);
            this.LValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(107, 19);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Número Inicial";
            // 
            // btMostraSomatorio
            // 
            this.btMostraSomatorio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMostraSomatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMostraSomatorio.FlatAppearance.BorderSize = 0;
            this.btMostraSomatorio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostraSomatorio.Location = new System.Drawing.Point(296, 80);
            this.btMostraSomatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btMostraSomatorio.Name = "btMostraSomatorio";
            this.btMostraSomatorio.Size = new System.Drawing.Size(120, 32);
            this.btMostraSomatorio.TabIndex = 2;
            this.btMostraSomatorio.Text = "Somatório";
            this.btMostraSomatorio.UseVisualStyleBackColor = false;
            this.btMostraSomatorio.Click += new System.EventHandler(this.BTInsereFila_Click);
            // 
            // TBNumInicial
            // 
            this.TBNumInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumInicial.Location = new System.Drawing.Point(20, 43);
            this.TBNumInicial.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumInicial.Name = "TBNumInicial";
            this.TBNumInicial.Size = new System.Drawing.Size(125, 22);
            this.TBNumInicial.TabIndex = 5;
            this.TBNumInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 37);
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
            this.LTitle.Size = new System.Drawing.Size(223, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Introdução à Recursividade";
            // 
            // btOrdenaCrescente
            // 
            this.btOrdenaCrescente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOrdenaCrescente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOrdenaCrescente.FlatAppearance.BorderSize = 0;
            this.btOrdenaCrescente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrdenaCrescente.Location = new System.Drawing.Point(20, 80);
            this.btOrdenaCrescente.Margin = new System.Windows.Forms.Padding(2);
            this.btOrdenaCrescente.Name = "btOrdenaCrescente";
            this.btOrdenaCrescente.Size = new System.Drawing.Size(120, 32);
            this.btOrdenaCrescente.TabIndex = 2;
            this.btOrdenaCrescente.Text = "Crescente";
            this.btOrdenaCrescente.UseVisualStyleBackColor = false;
            this.btOrdenaCrescente.Click += new System.EventHandler(this.btCrescenteRecursivaOnClick);
            // 
            // btMostraImpares
            // 
            this.btMostraImpares.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMostraImpares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMostraImpares.FlatAppearance.BorderSize = 0;
            this.btMostraImpares.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostraImpares.Location = new System.Drawing.Point(435, 80);
            this.btMostraImpares.Margin = new System.Windows.Forms.Padding(2);
            this.btMostraImpares.Name = "btMostraImpares";
            this.btMostraImpares.Size = new System.Drawing.Size(120, 32);
            this.btMostraImpares.TabIndex = 2;
            this.btMostraImpares.Text = "Ímpares";
            this.btMostraImpares.UseVisualStyleBackColor = false;
            this.btMostraImpares.Click += new System.EventHandler(this.BTAvioesFila_Click);
            // 
            // LB_Resultado
            // 
            this.LB_Resultado.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Resultado.FormattingEnabled = true;
            this.LB_Resultado.ItemHeight = 16;
            this.LB_Resultado.Location = new System.Drawing.Point(619, 76);
            this.LB_Resultado.Name = "LB_Resultado";
            this.LB_Resultado.Size = new System.Drawing.Size(167, 116);
            this.LB_Resultado.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gbSemVetor);
            this.panel2.Controls.Add(this.LB_Resultado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 300);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSomaVetor);
            this.groupBox1.Controls.Add(this.btInsereNoVetor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com vetor";
            // 
            // btSomaVetor
            // 
            this.btSomaVetor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btSomaVetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSomaVetor.FlatAppearance.BorderSize = 0;
            this.btSomaVetor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomaVetor.Location = new System.Drawing.Point(408, 18);
            this.btSomaVetor.Margin = new System.Windows.Forms.Padding(2);
            this.btSomaVetor.Name = "btSomaVetor";
            this.btSomaVetor.Size = new System.Drawing.Size(120, 32);
            this.btSomaVetor.TabIndex = 12;
            this.btSomaVetor.Text = "Soma vetor";
            this.btSomaVetor.UseVisualStyleBackColor = false;
            this.btSomaVetor.Click += new System.EventHandler(this.btSomaVetor_Click);
            // 
            // btInsereNoVetor
            // 
            this.btInsereNoVetor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btInsereNoVetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInsereNoVetor.FlatAppearance.BorderSize = 0;
            this.btInsereNoVetor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsereNoVetor.Location = new System.Drawing.Point(277, 18);
            this.btInsereNoVetor.Margin = new System.Windows.Forms.Padding(2);
            this.btInsereNoVetor.Name = "btInsereNoVetor";
            this.btInsereNoVetor.Size = new System.Drawing.Size(120, 32);
            this.btInsereNoVetor.TabIndex = 11;
            this.btInsereNoVetor.Text = "Insere no vetor";
            this.btInsereNoVetor.UseVisualStyleBackColor = false;
            this.btInsereNoVetor.Click += new System.EventHandler(this.btInsereNoVetor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número:";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(90, 23);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(171, 22);
            this.tbNumero.TabIndex = 5;
            this.tbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbSemVetor
            // 
            this.gbSemVetor.Controls.Add(this.TBNumInicial);
            this.gbSemVetor.Controls.Add(this.btMostraImpares);
            this.gbSemVetor.Controls.Add(this.label1);
            this.gbSemVetor.Controls.Add(this.btOrdenaDecrescente);
            this.gbSemVetor.Controls.Add(this.TBNumFinal);
            this.gbSemVetor.Controls.Add(this.btOrdenaCrescente);
            this.gbSemVetor.Controls.Add(this.LValor);
            this.gbSemVetor.Controls.Add(this.btMostraSomatorio);
            this.gbSemVetor.Location = new System.Drawing.Point(12, 54);
            this.gbSemVetor.Name = "gbSemVetor";
            this.gbSemVetor.Size = new System.Drawing.Size(575, 130);
            this.gbSemVetor.TabIndex = 12;
            this.gbSemVetor.TabStop = false;
            this.gbSemVetor.Text = "Sem vetor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Número Final";
            // 
            // btOrdenaDecrescente
            // 
            this.btOrdenaDecrescente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btOrdenaDecrescente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btOrdenaDecrescente.FlatAppearance.BorderSize = 0;
            this.btOrdenaDecrescente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrdenaDecrescente.Location = new System.Drawing.Point(158, 80);
            this.btOrdenaDecrescente.Margin = new System.Windows.Forms.Padding(2);
            this.btOrdenaDecrescente.Name = "btOrdenaDecrescente";
            this.btOrdenaDecrescente.Size = new System.Drawing.Size(120, 32);
            this.btOrdenaDecrescente.TabIndex = 2;
            this.btOrdenaDecrescente.Text = "Descrescente";
            this.btOrdenaDecrescente.UseVisualStyleBackColor = false;
            this.btOrdenaDecrescente.Click += new System.EventHandler(this.BTAutorizaDec_Click);
            // 
            // TBNumFinal
            // 
            this.TBNumFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumFinal.Location = new System.Drawing.Point(158, 43);
            this.TBNumFinal.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumFinal.Name = "TBNumFinal";
            this.TBNumFinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBNumFinal.Size = new System.Drawing.Size(125, 22);
            this.TBNumFinal.TabIndex = 11;
            this.TBNumFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ex10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex10";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSemVetor.ResumeLayout(false);
            this.gbSemVetor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.Button btMostraSomatorio;
        private System.Windows.Forms.TextBox TBNumInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Button btOrdenaCrescente;
        private System.Windows.Forms.Button btMostraImpares;
        private System.Windows.Forms.ListBox LB_Resultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOrdenaDecrescente;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNumFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSemVetor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSomaVetor;
        private System.Windows.Forms.Button btInsereNoVetor;

        // COPIAR ATÉ DAQUI
    }
}