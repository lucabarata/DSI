namespace Projeto_2DS3
{
    partial class Tela_Inicial
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSisMatri = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnConf2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSisMatri
            // 
            this.lblSisMatri.AutoSize = true;
            this.lblSisMatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisMatri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSisMatri.Location = new System.Drawing.Point(164, 26);
            this.lblSisMatri.Name = "lblSisMatri";
            this.lblSisMatri.Size = new System.Drawing.Size(301, 31);
            this.lblSisMatri.TabIndex = 0;
            this.lblSisMatri.Text = "Sistema de matrículas";
            this.lblSisMatri.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlunos.Location = new System.Drawing.Point(388, 77);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(39, 13);
            this.lblAlunos.TabIndex = 1;
            this.lblAlunos.Text = "Alunos";
            this.lblAlunos.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisc.Location = new System.Drawing.Point(201, 77);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(57, 13);
            this.lblDisc.TabIndex = 2;
            this.lblDisc.Text = "Disciplinas";
            this.lblDisc.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_2DS3.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(204, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 171);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.progressBar1.Location = new System.Drawing.Point(204, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(223, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 30;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(193, 107);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 23);
            this.btnConf.TabIndex = 5;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConf2
            // 
            this.btnConf2.Location = new System.Drawing.Point(366, 107);
            this.btnConf2.Name = "btnConf2";
            this.btnConf2.Size = new System.Drawing.Size(75, 23);
            this.btnConf2.TabIndex = 6;
            this.btnConf2.Text = "Confirmar";
            this.btnConf2.UseVisualStyleBackColor = true;
            this.btnConf2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnConf2);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.lblSisMatri);
            this.Name = "Tela_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto_2DS3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSisMatri;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnConf2;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

