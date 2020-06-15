namespace _001_Pilhas
{
    partial class Ex24
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbExibeArvore = new System.Windows.Forms.ListBox();
            this.rbPosOrdem = new System.Windows.Forms.RadioButton();
            this.rbPreOrdem = new System.Windows.Forms.RadioButton();
            this.rbEmOrdem = new System.Windows.Forms.RadioButton();
            this.btExibirArvoreBinaria = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.tbNomeConsultaAlterar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 477);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbExibeArvore);
            this.groupBox2.Controls.Add(this.rbPosOrdem);
            this.groupBox2.Controls.Add(this.rbPreOrdem);
            this.groupBox2.Controls.Add(this.rbEmOrdem);
            this.groupBox2.Controls.Add(this.btExibirArvoreBinaria);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 313);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exibir";
            // 
            // lbExibeArvore
            // 
            this.lbExibeArvore.FormattingEnabled = true;
            this.lbExibeArvore.Location = new System.Drawing.Point(66, 103);
            this.lbExibeArvore.Name = "lbExibeArvore";
            this.lbExibeArvore.Size = new System.Drawing.Size(218, 186);
            this.lbExibeArvore.TabIndex = 9;
            // 
            // rbPosOrdem
            // 
            this.rbPosOrdem.AutoSize = true;
            this.rbPosOrdem.Location = new System.Drawing.Point(252, 20);
            this.rbPosOrdem.Name = "rbPosOrdem";
            this.rbPosOrdem.Size = new System.Drawing.Size(77, 17);
            this.rbPosOrdem.TabIndex = 7;
            this.rbPosOrdem.TabStop = true;
            this.rbPosOrdem.Text = "Pós-Ordem";
            this.rbPosOrdem.UseVisualStyleBackColor = true;
            // 
            // rbPreOrdem
            // 
            this.rbPreOrdem.AutoSize = true;
            this.rbPreOrdem.Location = new System.Drawing.Point(144, 20);
            this.rbPreOrdem.Name = "rbPreOrdem";
            this.rbPreOrdem.Size = new System.Drawing.Size(75, 17);
            this.rbPreOrdem.TabIndex = 6;
            this.rbPreOrdem.TabStop = true;
            this.rbPreOrdem.Text = "Pré-Ordem";
            this.rbPreOrdem.UseVisualStyleBackColor = true;
            // 
            // rbEmOrdem
            // 
            this.rbEmOrdem.AutoSize = true;
            this.rbEmOrdem.Checked = true;
            this.rbEmOrdem.Location = new System.Drawing.Point(39, 19);
            this.rbEmOrdem.Name = "rbEmOrdem";
            this.rbEmOrdem.Size = new System.Drawing.Size(74, 17);
            this.rbEmOrdem.TabIndex = 5;
            this.rbEmOrdem.TabStop = true;
            this.rbEmOrdem.Text = "Em Ordem";
            this.rbEmOrdem.UseVisualStyleBackColor = true;
            // 
            // btExibirArvoreBinaria
            // 
            this.btExibirArvoreBinaria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExibirArvoreBinaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExibirArvoreBinaria.FlatAppearance.BorderSize = 0;
            this.btExibirArvoreBinaria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibirArvoreBinaria.Location = new System.Drawing.Point(130, 54);
            this.btExibirArvoreBinaria.Margin = new System.Windows.Forms.Padding(2);
            this.btExibirArvoreBinaria.Name = "btExibirArvoreBinaria";
            this.btExibirArvoreBinaria.Size = new System.Drawing.Size(97, 32);
            this.btExibirArvoreBinaria.TabIndex = 8;
            this.btExibirArvoreBinaria.Text = "Exibir";
            this.btExibirArvoreBinaria.UseVisualStyleBackColor = false;
            this.btExibirArvoreBinaria.Click += new System.EventHandler(this.btExibirArvoreBinaria_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Controls.Add(this.btInserir);
            this.groupBox1.Controls.Add(this.tbNomeConsultaAlterar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir, pesquisar e remover";
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(130, 63);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(97, 32);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(244, 63);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(97, 32);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInserir.FlatAppearance.BorderSize = 0;
            this.btInserir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(16, 63);
            this.btInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(97, 32);
            this.btInserir.TabIndex = 2;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // tbNomeConsultaAlterar
            // 
            this.tbNomeConsultaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeConsultaAlterar.Location = new System.Drawing.Point(126, 25);
            this.tbNomeConsultaAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeConsultaAlterar.Name = "tbNomeConsultaAlterar";
            this.tbNomeConsultaAlterar.Size = new System.Drawing.Size(142, 22);
            this.tbNomeConsultaAlterar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor:";
            // 
            // Ex24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 477);
            this.Controls.Add(this.panel1);
            this.Name = "Ex24";
            this.Text = "Árvore Binária";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPosOrdem;
        private System.Windows.Forms.RadioButton rbPreOrdem;
        private System.Windows.Forms.RadioButton rbEmOrdem;
        private System.Windows.Forms.Button btExibirArvoreBinaria;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox tbNomeConsultaAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbExibeArvore;
    }
}