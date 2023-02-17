namespace Projeto2_2DS3
{
    partial class FormEmpregados
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.textNomeFuncionario = new System.Windows.Forms.TextBox();
            this.textAnoNasc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(266, 138);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(111, 13);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome do funcionário: ";
            this.lblNomeFuncionario.Click += new System.EventHandler(this.lblNomeFuncionario_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(271, 38);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(253, 25);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Cadastro de funcionários";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // textNomeFuncionario
            // 
            this.textNomeFuncionario.Location = new System.Drawing.Point(383, 135);
            this.textNomeFuncionario.Name = "textNomeFuncionario";
            this.textNomeFuncionario.Size = new System.Drawing.Size(152, 20);
            this.textNomeFuncionario.TabIndex = 2;
            this.textNomeFuncionario.TextChanged += new System.EventHandler(this.textNomeFuncionario_TextChanged);
            // 
            // textAnoNasc
            // 
            this.textAnoNasc.Location = new System.Drawing.Point(383, 174);
            this.textAnoNasc.Name = "textAnoNasc";
            this.textAnoNasc.Size = new System.Drawing.Size(151, 20);
            this.textAnoNasc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ano de nascimento: ";
            // 
            // textCargo
            // 
            this.textCargo.Location = new System.Drawing.Point(383, 212);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(152, 20);
            this.textCargo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cargo: ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(417, 253);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 20);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAnoNasc);
            this.Controls.Add(this.textNomeFuncionario);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Name = "FormEmpregados";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox textNomeFuncionario;
        private System.Windows.Forms.TextBox textAnoNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
    }
}