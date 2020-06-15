namespace _001_Pilhas
{
    partial class ProvaRecursividade
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
            this.tbBase = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.btProcessaPotencia = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.gbFibonacci = new System.Windows.Forms.GroupBox();
            this.tbFibo = new System.Windows.Forms.TextBox();
            this.btProcessaFibonacci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbMaxDivisorComum = new System.Windows.Forms.GroupBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btProcessaMDC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCubo = new System.Windows.Forms.GroupBox();
            this.tbNNumerosAoCubo = new System.Windows.Forms.TextBox();
            this.btProcessaCubo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBinario = new System.Windows.Forms.GroupBox();
            this.tbNumeroBase10 = new System.Windows.Forms.TextBox();
            this.btProcessaBinario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSemVetor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExpoente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbFibonacci.SuspendLayout();
            this.gbMaxDivisorComum.SuspendLayout();
            this.gbCubo.SuspendLayout();
            this.gbBinario.SuspendLayout();
            this.gbSemVetor.SuspendLayout();
            this.SuspendLayout();
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.BackColor = System.Drawing.Color.Transparent;
            this.LValor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValor.Location = new System.Drawing.Point(50, 22);
            this.LValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(45, 19);
            this.LValor.TabIndex = 0;
            this.LValor.Text = "Base:";
            // 
            // tbBase
            // 
            this.tbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBase.Location = new System.Drawing.Point(101, 21);
            this.tbBase.Margin = new System.Windows.Forms.Padding(2);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(125, 22);
            this.tbBase.TabIndex = 5;
            this.tbBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 37);
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
            this.LTitle.Size = new System.Drawing.Size(184, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Recursividade Diversos";
            // 
            // btProcessaPotencia
            // 
            this.btProcessaPotencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcessaPotencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcessaPotencia.FlatAppearance.BorderSize = 0;
            this.btProcessaPotencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessaPotencia.Location = new System.Drawing.Point(245, 31);
            this.btProcessaPotencia.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessaPotencia.Name = "btProcessaPotencia";
            this.btProcessaPotencia.Size = new System.Drawing.Size(120, 32);
            this.btProcessaPotencia.TabIndex = 2;
            this.btProcessaPotencia.Text = "Processa";
            this.btProcessaPotencia.UseVisualStyleBackColor = false;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 16;
            this.lbResultado.Location = new System.Drawing.Point(569, 216);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(167, 212);
            this.lbResultado.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.gbFibonacci);
            this.panel2.Controls.Add(this.gbMaxDivisorComum);
            this.panel2.Controls.Add(this.gbCubo);
            this.panel2.Controls.Add(this.gbBinario);
            this.panel2.Controls.Add(this.gbSemVetor);
            this.panel2.Controls.Add(this.lbResultado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 562);
            this.panel2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Resultado:";
            // 
            // gbFibonacci
            // 
            this.gbFibonacci.Controls.Add(this.tbFibo);
            this.gbFibonacci.Controls.Add(this.btProcessaFibonacci);
            this.gbFibonacci.Controls.Add(this.label6);
            this.gbFibonacci.Location = new System.Drawing.Point(12, 445);
            this.gbFibonacci.Name = "gbFibonacci";
            this.gbFibonacci.Size = new System.Drawing.Size(397, 92);
            this.gbFibonacci.TabIndex = 15;
            this.gbFibonacci.TabStop = false;
            this.gbFibonacci.Text = "Série de Fibonacci";
            // 
            // tbFibo
            // 
            this.tbFibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFibo.Location = new System.Drawing.Point(106, 37);
            this.tbFibo.Margin = new System.Windows.Forms.Padding(2);
            this.tbFibo.Name = "tbFibo";
            this.tbFibo.Size = new System.Drawing.Size(125, 22);
            this.tbFibo.TabIndex = 5;
            this.tbFibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btProcessaFibonacci
            // 
            this.btProcessaFibonacci.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcessaFibonacci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcessaFibonacci.FlatAppearance.BorderSize = 0;
            this.btProcessaFibonacci.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessaFibonacci.Location = new System.Drawing.Point(245, 31);
            this.btProcessaFibonacci.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessaFibonacci.Name = "btProcessaFibonacci";
            this.btProcessaFibonacci.Size = new System.Drawing.Size(120, 32);
            this.btProcessaFibonacci.TabIndex = 2;
            this.btProcessaFibonacci.Text = "Processa";
            this.btProcessaFibonacci.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número:";
            // 
            // gbMaxDivisorComum
            // 
            this.gbMaxDivisorComum.Controls.Add(this.tbX);
            this.gbMaxDivisorComum.Controls.Add(this.label3);
            this.gbMaxDivisorComum.Controls.Add(this.tbY);
            this.gbMaxDivisorComum.Controls.Add(this.btProcessaMDC);
            this.gbMaxDivisorComum.Controls.Add(this.label5);
            this.gbMaxDivisorComum.Location = new System.Drawing.Point(12, 316);
            this.gbMaxDivisorComum.Name = "gbMaxDivisorComum";
            this.gbMaxDivisorComum.Size = new System.Drawing.Size(397, 92);
            this.gbMaxDivisorComum.TabIndex = 13;
            this.gbMaxDivisorComum.TabStop = false;
            this.gbMaxDivisorComum.Text = "Máximo Divisor Comum";
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbX.Location = new System.Drawing.Point(101, 21);
            this.tbX.Margin = new System.Windows.Forms.Padding(2);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(125, 22);
            this.tbX.TabIndex = 5;
            this.tbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y:";
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbY.Location = new System.Drawing.Point(101, 55);
            this.tbY.Margin = new System.Windows.Forms.Padding(2);
            this.tbY.Name = "tbY";
            this.tbY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbY.Size = new System.Drawing.Size(125, 22);
            this.tbY.TabIndex = 11;
            this.tbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btProcessaMDC
            // 
            this.btProcessaMDC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcessaMDC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcessaMDC.FlatAppearance.BorderSize = 0;
            this.btProcessaMDC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessaMDC.Location = new System.Drawing.Point(245, 31);
            this.btProcessaMDC.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessaMDC.Name = "btProcessaMDC";
            this.btProcessaMDC.Size = new System.Drawing.Size(120, 32);
            this.btProcessaMDC.TabIndex = 2;
            this.btProcessaMDC.Text = "Processa";
            this.btProcessaMDC.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "X:";
            // 
            // gbCubo
            // 
            this.gbCubo.Controls.Add(this.tbNNumerosAoCubo);
            this.gbCubo.Controls.Add(this.btProcessaCubo);
            this.gbCubo.Controls.Add(this.label2);
            this.gbCubo.Location = new System.Drawing.Point(12, 184);
            this.gbCubo.Name = "gbCubo";
            this.gbCubo.Size = new System.Drawing.Size(397, 92);
            this.gbCubo.TabIndex = 14;
            this.gbCubo.TabStop = false;
            this.gbCubo.Text = "Cubo";
            // 
            // tbNNumerosAoCubo
            // 
            this.tbNNumerosAoCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNNumerosAoCubo.Location = new System.Drawing.Point(106, 37);
            this.tbNNumerosAoCubo.Margin = new System.Windows.Forms.Padding(2);
            this.tbNNumerosAoCubo.Name = "tbNNumerosAoCubo";
            this.tbNNumerosAoCubo.Size = new System.Drawing.Size(125, 22);
            this.tbNNumerosAoCubo.TabIndex = 5;
            this.tbNNumerosAoCubo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btProcessaCubo
            // 
            this.btProcessaCubo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcessaCubo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcessaCubo.FlatAppearance.BorderSize = 0;
            this.btProcessaCubo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessaCubo.Location = new System.Drawing.Point(245, 31);
            this.btProcessaCubo.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessaCubo.Name = "btProcessaCubo";
            this.btProcessaCubo.Size = new System.Drawing.Size(120, 32);
            this.btProcessaCubo.TabIndex = 2;
            this.btProcessaCubo.Text = "Processa";
            this.btProcessaCubo.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número:";
            // 
            // gbBinario
            // 
            this.gbBinario.Controls.Add(this.tbNumeroBase10);
            this.gbBinario.Controls.Add(this.btProcessaBinario);
            this.gbBinario.Controls.Add(this.label4);
            this.gbBinario.Location = new System.Drawing.Point(450, 54);
            this.gbBinario.Name = "gbBinario";
            this.gbBinario.Size = new System.Drawing.Size(397, 92);
            this.gbBinario.TabIndex = 13;
            this.gbBinario.TabStop = false;
            this.gbBinario.Text = "Inteiro para Binário";
            // 
            // tbNumeroBase10
            // 
            this.tbNumeroBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroBase10.Location = new System.Drawing.Point(106, 37);
            this.tbNumeroBase10.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumeroBase10.Name = "tbNumeroBase10";
            this.tbNumeroBase10.Size = new System.Drawing.Size(125, 22);
            this.tbNumeroBase10.TabIndex = 5;
            this.tbNumeroBase10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btProcessaBinario
            // 
            this.btProcessaBinario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcessaBinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcessaBinario.FlatAppearance.BorderSize = 0;
            this.btProcessaBinario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessaBinario.Location = new System.Drawing.Point(245, 31);
            this.btProcessaBinario.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessaBinario.Name = "btProcessaBinario";
            this.btProcessaBinario.Size = new System.Drawing.Size(120, 32);
            this.btProcessaBinario.TabIndex = 2;
            this.btProcessaBinario.Text = "Processa";
            this.btProcessaBinario.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número:";
            // 
            // gbSemVetor
            // 
            this.gbSemVetor.Controls.Add(this.tbBase);
            this.gbSemVetor.Controls.Add(this.label1);
            this.gbSemVetor.Controls.Add(this.tbExpoente);
            this.gbSemVetor.Controls.Add(this.btProcessaPotencia);
            this.gbSemVetor.Controls.Add(this.LValor);
            this.gbSemVetor.Location = new System.Drawing.Point(12, 54);
            this.gbSemVetor.Name = "gbSemVetor";
            this.gbSemVetor.Size = new System.Drawing.Size(397, 92);
            this.gbSemVetor.TabIndex = 12;
            this.gbSemVetor.TabStop = false;
            this.gbSemVetor.Text = "Potência";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Expoente:";
            // 
            // tbExpoente
            // 
            this.tbExpoente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpoente.Location = new System.Drawing.Point(101, 55);
            this.tbExpoente.Margin = new System.Windows.Forms.Padding(2);
            this.tbExpoente.Name = "tbExpoente";
            this.tbExpoente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExpoente.Size = new System.Drawing.Size(125, 22);
            this.tbExpoente.TabIndex = 11;
            this.tbExpoente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ex11a15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex11a15";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbFibonacci.ResumeLayout(false);
            this.gbFibonacci.PerformLayout();
            this.gbMaxDivisorComum.ResumeLayout(false);
            this.gbMaxDivisorComum.PerformLayout();
            this.gbCubo.ResumeLayout(false);
            this.gbCubo.PerformLayout();
            this.gbBinario.ResumeLayout(false);
            this.gbBinario.PerformLayout();
            this.gbSemVetor.ResumeLayout(false);
            this.gbSemVetor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Button btProcessaPotencia;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExpoente;
        private System.Windows.Forms.GroupBox gbSemVetor;
        private System.Windows.Forms.GroupBox gbCubo;
        private System.Windows.Forms.TextBox tbNNumerosAoCubo;
        private System.Windows.Forms.Button btProcessaCubo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBinario;
        private System.Windows.Forms.TextBox tbNumeroBase10;
        private System.Windows.Forms.Button btProcessaBinario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbFibonacci;
        private System.Windows.Forms.TextBox tbFibo;
        private System.Windows.Forms.Button btProcessaFibonacci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbMaxDivisorComum;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btProcessaMDC;
        private System.Windows.Forms.Label label5;

        // COPIAR ATÉ DAQUI
    }
}