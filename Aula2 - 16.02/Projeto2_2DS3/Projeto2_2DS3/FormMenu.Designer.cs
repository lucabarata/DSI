namespace Projeto2_2DS3
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpregados = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEmpregados
            // 
            this.btnEmpregados.Location = new System.Drawing.Point(130, 148);
            this.btnEmpregados.Name = "btnEmpregados";
            this.btnEmpregados.Size = new System.Drawing.Size(135, 117);
            this.btnEmpregados.TabIndex = 1;
            this.btnEmpregados.Text = "Cadastrar Funcionário";
            this.btnEmpregados.UseVisualStyleBackColor = true;
            this.btnEmpregados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(312, 148);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(135, 117);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(494, 148);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(135, 117);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(692, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnEmpregados);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpregados;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
    }
}