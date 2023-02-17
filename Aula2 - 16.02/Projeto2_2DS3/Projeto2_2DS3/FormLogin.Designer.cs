namespace Projeto2_2DS3
{
    partial class FormLogin
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
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(354, 248);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(186, 23);
            this.textUsuario.TabIndex = 1;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(354, 288);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(186, 23);
            this.textSenha.TabIndex = 2;
            this.textSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(272, 248);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Usuário:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(410, 331);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(282, 288);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 20);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(375, 207);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(144, 13);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem-vindo ao nosso sistema!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto2_2DS3.Properties.Resources.cps_logo_identidade;
            this.pictureBox1.Location = new System.Drawing.Point(313, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUsuario);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

