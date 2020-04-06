namespace _001_Pilhas
{
    partial class Ex04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex04));
            this.LRecebeDecimal = new System.Windows.Forms.Label();
            this.BTProcessa = new System.Windows.Forms.Button();
            this.TBFraseOD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFraseOI = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LRecebeDecimal
            // 
            this.LRecebeDecimal.AutoSize = true;
            this.LRecebeDecimal.BackColor = System.Drawing.Color.Transparent;
            this.LRecebeDecimal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecebeDecimal.Location = new System.Drawing.Point(13, 55);
            this.LRecebeDecimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRecebeDecimal.Name = "LRecebeDecimal";
            this.LRecebeDecimal.Size = new System.Drawing.Size(102, 19);
            this.LRecebeDecimal.TabIndex = 0;
            this.LRecebeDecimal.Text = "Frase original:";
            // 
            // BTProcessa
            // 
            this.BTProcessa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTProcessa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTProcessa.FlatAppearance.BorderSize = 0;
            this.BTProcessa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTProcessa.Location = new System.Drawing.Point(96, 89);
            this.BTProcessa.Margin = new System.Windows.Forms.Padding(2);
            this.BTProcessa.Name = "BTProcessa";
            this.BTProcessa.Size = new System.Drawing.Size(97, 32);
            this.BTProcessa.TabIndex = 2;
            this.BTProcessa.Text = "Processa";
            this.BTProcessa.UseVisualStyleBackColor = false;
            this.BTProcessa.Click += new System.EventHandler(this.BTProcessa_Click);
            // 
            // TBFraseOD
            // 
            this.TBFraseOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFraseOD.Location = new System.Drawing.Point(128, 54);
            this.TBFraseOD.Margin = new System.Windows.Forms.Padding(2);
            this.TBFraseOD.Name = "TBFraseOD";
            this.TBFraseOD.Size = new System.Drawing.Size(306, 22);
            this.TBFraseOD.TabIndex = 5;
            this.TBFraseOD.Text = "Paulo Adilson";
            this.TBFraseOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 37);
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
            this.LTitle.Size = new System.Drawing.Size(121, 19);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Frase Invertida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase invertida:";
            // 
            // TBFraseOI
            // 
            this.TBFraseOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFraseOI.Location = new System.Drawing.Point(128, 134);
            this.TBFraseOI.Margin = new System.Windows.Forms.Padding(2);
            this.TBFraseOI.Name = "TBFraseOI";
            this.TBFraseOI.Size = new System.Drawing.Size(306, 22);
            this.TBFraseOI.TabIndex = 5;
            this.TBFraseOI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ex04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 189);
            this.Controls.Add(this.TBFraseOI);
            this.Controls.Add(this.TBFraseOD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTProcessa);
            this.Controls.Add(this.LRecebeDecimal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex04";
            this.Text = this.LTitle.Text;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LRecebeDecimal;
        private System.Windows.Forms.Button BTProcessa;
        private System.Windows.Forms.TextBox TBFraseOD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBFraseOI;

        // COPIAR ATÉ DAQUI

    }
}