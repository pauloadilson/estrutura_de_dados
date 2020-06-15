namespace _001_Pilhas
{
    partial class Ex26
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcIncluir = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btGravar = new System.Windows.Forms.Button();
            this.tbEmailIns = new System.Windows.Forms.TextBox();
            this.tbNomeIns = new System.Windows.Forms.TextBox();
            this.tbNotaIns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LRecebeDecimal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btProcurar = new System.Windows.Forms.Button();
            this.tbEmailRec = new System.Windows.Forms.TextBox();
            this.tbNomeRec = new System.Windows.Forms.TextBox();
            this.tbNotaRec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btExibeNumColisoes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcIncluir.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcIncluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 274);
            this.panel1.TabIndex = 0;
            // 
            // tcIncluir
            // 
            this.tcIncluir.Controls.Add(this.tabPage1);
            this.tcIncluir.Controls.Add(this.tabPage2);
            this.tcIncluir.Controls.Add(this.tabPage4);
            this.tcIncluir.Location = new System.Drawing.Point(3, 3);
            this.tcIncluir.Multiline = true;
            this.tcIncluir.Name = "tcIncluir";
            this.tcIncluir.SelectedIndex = 0;
            this.tcIncluir.Size = new System.Drawing.Size(478, 268);
            this.tcIncluir.TabIndex = 0;
            this.tcIncluir.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btGravar);
            this.tabPage1.Controls.Add(this.tbEmailIns);
            this.tabPage1.Controls.Add(this.tbNomeIns);
            this.tabPage1.Controls.Add(this.tbNotaIns);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LRecebeDecimal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravar.FlatAppearance.BorderSize = 0;
            this.btGravar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.Location = new System.Drawing.Point(102, 158);
            this.btGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(97, 32);
            this.btGravar.TabIndex = 5;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // tbEmailIns
            // 
            this.tbEmailIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailIns.Location = new System.Drawing.Point(102, 107);
            this.tbEmailIns.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailIns.Name = "tbEmailIns";
            this.tbEmailIns.Size = new System.Drawing.Size(280, 22);
            this.tbEmailIns.TabIndex = 2;
            // 
            // tbNomeIns
            // 
            this.tbNomeIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeIns.Location = new System.Drawing.Point(102, 67);
            this.tbNomeIns.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeIns.Name = "tbNomeIns";
            this.tbNomeIns.Size = new System.Drawing.Size(280, 22);
            this.tbNomeIns.TabIndex = 2;
            // 
            // tbNotaIns
            // 
            this.tbNotaIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotaIns.Location = new System.Drawing.Point(102, 25);
            this.tbNotaIns.Margin = new System.Windows.Forms.Padding(2);
            this.tbNotaIns.Name = "tbNotaIns";
            this.tbNotaIns.Size = new System.Drawing.Size(140, 22);
            this.tbNotaIns.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // LRecebeDecimal
            // 
            this.LRecebeDecimal.AutoSize = true;
            this.LRecebeDecimal.BackColor = System.Drawing.Color.Transparent;
            this.LRecebeDecimal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecebeDecimal.Location = new System.Drawing.Point(28, 28);
            this.LRecebeDecimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRecebeDecimal.Name = "LRecebeDecimal";
            this.LRecebeDecimal.Size = new System.Drawing.Size(47, 19);
            this.LRecebeDecimal.TabIndex = 6;
            this.LRecebeDecimal.Text = "Nota:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btProcurar);
            this.tabPage2.Controls.Add(this.tbEmailRec);
            this.tabPage2.Controls.Add(this.tbNomeRec);
            this.tabPage2.Controls.Add(this.tbNotaRec);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recuperar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btProcurar
            // 
            this.btProcurar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcurar.FlatAppearance.BorderSize = 0;
            this.btProcurar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Location = new System.Drawing.Point(285, 19);
            this.btProcurar.Margin = new System.Windows.Forms.Padding(2);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(97, 32);
            this.btProcurar.TabIndex = 10;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = false;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // tbEmailRec
            // 
            this.tbEmailRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailRec.Location = new System.Drawing.Point(102, 107);
            this.tbEmailRec.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailRec.Name = "tbEmailRec";
            this.tbEmailRec.ReadOnly = true;
            this.tbEmailRec.Size = new System.Drawing.Size(280, 22);
            this.tbEmailRec.TabIndex = 8;
            // 
            // tbNomeRec
            // 
            this.tbNomeRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeRec.Location = new System.Drawing.Point(102, 67);
            this.tbNomeRec.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeRec.Name = "tbNomeRec";
            this.tbNomeRec.ReadOnly = true;
            this.tbNomeRec.Size = new System.Drawing.Size(280, 22);
            this.tbNomeRec.TabIndex = 9;
            // 
            // tbNotaRec
            // 
            this.tbNotaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotaRec.Location = new System.Drawing.Point(102, 25);
            this.tbNotaRec.Margin = new System.Windows.Forms.Padding(2);
            this.tbNotaRec.Name = "tbNotaRec";
            this.tbNotaRec.Size = new System.Drawing.Size(140, 22);
            this.tbNotaRec.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nota:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btExibeNumColisoes);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(470, 242);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Informar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 76);
            this.label6.TabIndex = 2;
            this.label6.Text = "0";
            // 
            // btExibeNumColisoes
            // 
            this.btExibeNumColisoes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExibeNumColisoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExibeNumColisoes.FlatAppearance.BorderSize = 0;
            this.btExibeNumColisoes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibeNumColisoes.Location = new System.Drawing.Point(176, 23);
            this.btExibeNumColisoes.Margin = new System.Windows.Forms.Padding(2);
            this.btExibeNumColisoes.Name = "btExibeNumColisoes";
            this.btExibeNumColisoes.Size = new System.Drawing.Size(127, 60);
            this.btExibeNumColisoes.TabIndex = 1;
            this.btExibeNumColisoes.Text = "Quantidade de Colisões";
            this.btExibeNumColisoes.UseVisualStyleBackColor = false;
            this.btExibeNumColisoes.Click += new System.EventHandler(this.btExibeNumColisoes_Click);
            // 
            // Ex26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 274);
            this.Controls.Add(this.panel1);
            this.Name = "Ex26";
            this.Text = "Ex. 26 - Introdução ao Espalhamento";
            this.panel1.ResumeLayout(false);
            this.tcIncluir.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcIncluir;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox tbNomeIns;
        private System.Windows.Forms.TextBox tbNotaIns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LRecebeDecimal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btExibeNumColisoes;
        private System.Windows.Forms.TextBox tbEmailIns;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.TextBox tbEmailRec;
        private System.Windows.Forms.TextBox tbNomeRec;
        private System.Windows.Forms.TextBox tbNotaRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}