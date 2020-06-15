namespace _001_Pilhas
{
    partial class Ex17
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
            this.cbSexoInclusao = new System.Windows.Forms.ComboBox();
            this.btGravarInclusao = new System.Windows.Forms.Button();
            this.tbIdadeInclusao = new System.Windows.Forms.TextBox();
            this.tbNomeInclusao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LRecebeDecimal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbSexoAlteracao = new System.Windows.Forms.ComboBox();
            this.btConsultaAlteracao = new System.Windows.Forms.Button();
            this.btGravarAlteracao = new System.Windows.Forms.Button();
            this.tbIdadeAlteracao = new System.Windows.Forms.TextBox();
            this.tbNomeConsultaAlterar = new System.Windows.Forms.TextBox();
            this.tbNomeAlteracao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btProcurarExclusao = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbSexoExclusao = new System.Windows.Forms.TextBox();
            this.tbIdadeExclusao = new System.Windows.Forms.TextBox();
            this.tbConsultaNomeExclusao = new System.Windows.Forms.TextBox();
            this.tbNomeExclusao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbExibeRegistros = new System.Windows.Forms.ListBox();
            this.btExibeRegistros = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcIncluir.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcIncluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 567);
            this.panel1.TabIndex = 0;
            // 
            // tcIncluir
            // 
            this.tcIncluir.Controls.Add(this.tabPage1);
            this.tcIncluir.Controls.Add(this.tabPage2);
            this.tcIncluir.Controls.Add(this.tabPage3);
            this.tcIncluir.Controls.Add(this.tabPage4);
            this.tcIncluir.Location = new System.Drawing.Point(4, 4);
            this.tcIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcIncluir.Multiline = true;
            this.tcIncluir.Name = "tcIncluir";
            this.tcIncluir.SelectedIndex = 0;
            this.tcIncluir.Size = new System.Drawing.Size(637, 560);
            this.tcIncluir.TabIndex = 0;
            this.tcIncluir.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbSexoInclusao);
            this.tabPage1.Controls.Add(this.btGravarInclusao);
            this.tabPage1.Controls.Add(this.tbIdadeInclusao);
            this.tabPage1.Controls.Add(this.tbNomeInclusao);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LRecebeDecimal);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(629, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbSexoInclusao
            // 
            this.cbSexoInclusao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoInclusao.FormattingEnabled = true;
            this.cbSexoInclusao.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexoInclusao.Location = new System.Drawing.Point(136, 132);
            this.cbSexoInclusao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSexoInclusao.Name = "cbSexoInclusao";
            this.cbSexoInclusao.Size = new System.Drawing.Size(217, 24);
            this.cbSexoInclusao.TabIndex = 3;
            // 
            // btGravarInclusao
            // 
            this.btGravarInclusao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravarInclusao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravarInclusao.FlatAppearance.BorderSize = 0;
            this.btGravarInclusao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarInclusao.Location = new System.Drawing.Point(136, 194);
            this.btGravarInclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGravarInclusao.Name = "btGravarInclusao";
            this.btGravarInclusao.Size = new System.Drawing.Size(129, 39);
            this.btGravarInclusao.TabIndex = 5;
            this.btGravarInclusao.Text = "Gravar";
            this.btGravarInclusao.UseVisualStyleBackColor = false;
            this.btGravarInclusao.Click += new System.EventHandler(this.btGravarInclusao_Click);
            // 
            // tbIdadeInclusao
            // 
            this.tbIdadeInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdadeInclusao.Location = new System.Drawing.Point(136, 82);
            this.tbIdadeInclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdadeInclusao.Name = "tbIdadeInclusao";
            this.tbIdadeInclusao.Size = new System.Drawing.Size(217, 22);
            this.tbIdadeInclusao.TabIndex = 2;
            // 
            // tbNomeInclusao
            // 
            this.tbNomeInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeInclusao.Location = new System.Drawing.Point(136, 31);
            this.tbNomeInclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomeInclusao.Name = "tbNomeInclusao";
            this.tbNomeInclusao.Size = new System.Drawing.Size(372, 22);
            this.tbNomeInclusao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade:";
            // 
            // LRecebeDecimal
            // 
            this.LRecebeDecimal.AutoSize = true;
            this.LRecebeDecimal.BackColor = System.Drawing.Color.Transparent;
            this.LRecebeDecimal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecebeDecimal.Location = new System.Drawing.Point(37, 34);
            this.LRecebeDecimal.Name = "LRecebeDecimal";
            this.LRecebeDecimal.Size = new System.Drawing.Size(54, 19);
            this.LRecebeDecimal.TabIndex = 6;
            this.LRecebeDecimal.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbSexoAlteracao);
            this.tabPage2.Controls.Add(this.btConsultaAlteracao);
            this.tabPage2.Controls.Add(this.btGravarAlteracao);
            this.tabPage2.Controls.Add(this.tbIdadeAlteracao);
            this.tabPage2.Controls.Add(this.tbNomeConsultaAlterar);
            this.tabPage2.Controls.Add(this.tbNomeAlteracao);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(629, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbSexoAlteracao
            // 
            this.cbSexoAlteracao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoAlteracao.FormattingEnabled = true;
            this.cbSexoAlteracao.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexoAlteracao.Location = new System.Drawing.Point(136, 274);
            this.cbSexoAlteracao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSexoAlteracao.Name = "cbSexoAlteracao";
            this.cbSexoAlteracao.Size = new System.Drawing.Size(217, 24);
            this.cbSexoAlteracao.TabIndex = 5;
            // 
            // btConsultaAlteracao
            // 
            this.btConsultaAlteracao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btConsultaAlteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btConsultaAlteracao.FlatAppearance.BorderSize = 0;
            this.btConsultaAlteracao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaAlteracao.Location = new System.Drawing.Point(136, 76);
            this.btConsultaAlteracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConsultaAlteracao.Name = "btConsultaAlteracao";
            this.btConsultaAlteracao.Size = new System.Drawing.Size(129, 39);
            this.btConsultaAlteracao.TabIndex = 2;
            this.btConsultaAlteracao.Text = "Procurar";
            this.btConsultaAlteracao.UseVisualStyleBackColor = false;
            this.btConsultaAlteracao.Click += new System.EventHandler(this.btConsultaAlteracao_Click);
            // 
            // btGravarAlteracao
            // 
            this.btGravarAlteracao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravarAlteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravarAlteracao.FlatAppearance.BorderSize = 0;
            this.btGravarAlteracao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarAlteracao.Location = new System.Drawing.Point(136, 337);
            this.btGravarAlteracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGravarAlteracao.Name = "btGravarAlteracao";
            this.btGravarAlteracao.Size = new System.Drawing.Size(129, 39);
            this.btGravarAlteracao.TabIndex = 6;
            this.btGravarAlteracao.Text = "Gravar";
            this.btGravarAlteracao.UseVisualStyleBackColor = false;
            this.btGravarAlteracao.Click += new System.EventHandler(this.btGravarAlteracao_Click);
            // 
            // tbIdadeAlteracao
            // 
            this.tbIdadeAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdadeAlteracao.Location = new System.Drawing.Point(136, 225);
            this.tbIdadeAlteracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdadeAlteracao.Name = "tbIdadeAlteracao";
            this.tbIdadeAlteracao.Size = new System.Drawing.Size(217, 22);
            this.tbIdadeAlteracao.TabIndex = 4;
            // 
            // tbNomeConsultaAlterar
            // 
            this.tbNomeConsultaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeConsultaAlterar.Location = new System.Drawing.Point(136, 31);
            this.tbNomeConsultaAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomeConsultaAlterar.Name = "tbNomeConsultaAlterar";
            this.tbNomeConsultaAlterar.Size = new System.Drawing.Size(372, 22);
            this.tbNomeConsultaAlterar.TabIndex = 1;
            // 
            // tbNomeAlteracao
            // 
            this.tbNomeAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeAlteracao.Location = new System.Drawing.Point(136, 174);
            this.tbNomeAlteracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomeAlteracao.Name = "tbNomeAlteracao";
            this.tbNomeAlteracao.Size = new System.Drawing.Size(372, 22);
            this.tbNomeAlteracao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Idade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btProcurarExclusao);
            this.tabPage3.Controls.Add(this.btExcluir);
            this.tabPage3.Controls.Add(this.tbSexoExclusao);
            this.tabPage3.Controls.Add(this.tbIdadeExclusao);
            this.tabPage3.Controls.Add(this.tbConsultaNomeExclusao);
            this.tabPage3.Controls.Add(this.tbNomeExclusao);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(629, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btProcurarExclusao
            // 
            this.btProcurarExclusao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btProcurarExclusao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcurarExclusao.FlatAppearance.BorderSize = 0;
            this.btProcurarExclusao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurarExclusao.Location = new System.Drawing.Point(136, 76);
            this.btProcurarExclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcurarExclusao.Name = "btProcurarExclusao";
            this.btProcurarExclusao.Size = new System.Drawing.Size(129, 39);
            this.btProcurarExclusao.TabIndex = 2;
            this.btProcurarExclusao.Text = "Procurar";
            this.btProcurarExclusao.UseVisualStyleBackColor = false;
            this.btProcurarExclusao.Click += new System.EventHandler(this.btProcurarExclusao_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(136, 337);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(129, 39);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tbSexoExclusao
            // 
            this.tbSexoExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSexoExclusao.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSexoExclusao.Location = new System.Drawing.Point(136, 274);
            this.tbSexoExclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSexoExclusao.Name = "tbSexoExclusao";
            this.tbSexoExclusao.ReadOnly = true;
            this.tbSexoExclusao.Size = new System.Drawing.Size(217, 22);
            this.tbSexoExclusao.TabIndex = 4;
            // 
            // tbIdadeExclusao
            // 
            this.tbIdadeExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdadeExclusao.Location = new System.Drawing.Point(136, 225);
            this.tbIdadeExclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdadeExclusao.Name = "tbIdadeExclusao";
            this.tbIdadeExclusao.ReadOnly = true;
            this.tbIdadeExclusao.Size = new System.Drawing.Size(217, 22);
            this.tbIdadeExclusao.TabIndex = 4;
            // 
            // tbConsultaNomeExclusao
            // 
            this.tbConsultaNomeExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsultaNomeExclusao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbConsultaNomeExclusao.Location = new System.Drawing.Point(136, 31);
            this.tbConsultaNomeExclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbConsultaNomeExclusao.Name = "tbConsultaNomeExclusao";
            this.tbConsultaNomeExclusao.Size = new System.Drawing.Size(372, 22);
            this.tbConsultaNomeExclusao.TabIndex = 1;
            // 
            // tbNomeExclusao
            // 
            this.tbNomeExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeExclusao.Location = new System.Drawing.Point(136, 174);
            this.tbNomeExclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomeExclusao.Name = "tbNomeExclusao";
            this.tbNomeExclusao.ReadOnly = true;
            this.tbNomeExclusao.Size = new System.Drawing.Size(372, 22);
            this.tbNomeExclusao.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Idade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nome:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbExibeRegistros);
            this.tabPage4.Controls.Add(this.btExibeRegistros);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(629, 531);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Exibir";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbExibeRegistros
            // 
            this.lbExibeRegistros.FormattingEnabled = true;
            this.lbExibeRegistros.ItemHeight = 16;
            this.lbExibeRegistros.Location = new System.Drawing.Point(37, 102);
            this.lbExibeRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbExibeRegistros.Name = "lbExibeRegistros";
            this.lbExibeRegistros.Size = new System.Drawing.Size(549, 372);
            this.lbExibeRegistros.TabIndex = 26;
            // 
            // btExibeRegistros
            // 
            this.btExibeRegistros.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExibeRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExibeRegistros.FlatAppearance.BorderSize = 0;
            this.btExibeRegistros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibeRegistros.Location = new System.Drawing.Point(37, 34);
            this.btExibeRegistros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExibeRegistros.Name = "btExibeRegistros";
            this.btExibeRegistros.Size = new System.Drawing.Size(148, 39);
            this.btExibeRegistros.TabIndex = 1;
            this.btExibeRegistros.Text = "Exibir Todos";
            this.btExibeRegistros.UseVisualStyleBackColor = false;
            this.btExibeRegistros.Click += new System.EventHandler(this.btExibeRegistros_Click);
            // 
            // Ex17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ex17";
            this.Text = "Ex. 17 - Lista Encadeada";
            this.panel1.ResumeLayout(false);
            this.tcIncluir.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcIncluir;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbIdadeInclusao;
        private System.Windows.Forms.TextBox tbNomeInclusao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LRecebeDecimal;
        private System.Windows.Forms.ComboBox cbSexoInclusao;
        private System.Windows.Forms.Button btGravarInclusao;
        private System.Windows.Forms.ComboBox cbSexoAlteracao;
        private System.Windows.Forms.Button btConsultaAlteracao;
        private System.Windows.Forms.Button btGravarAlteracao;
        private System.Windows.Forms.TextBox tbIdadeAlteracao;
        private System.Windows.Forms.TextBox tbNomeConsultaAlterar;
        private System.Windows.Forms.TextBox tbNomeAlteracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btProcurarExclusao;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox tbIdadeExclusao;
        private System.Windows.Forms.TextBox tbConsultaNomeExclusao;
        private System.Windows.Forms.TextBox tbNomeExclusao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbExibeRegistros;
        private System.Windows.Forms.Button btExibeRegistros;
        private System.Windows.Forms.TextBox tbSexoExclusao;
    }
}