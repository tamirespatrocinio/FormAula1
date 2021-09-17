
namespace FormAula1
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioGenero3 = new System.Windows.Forms.RadioButton();
            this.radioButtonGenero2 = new System.Windows.Forms.RadioButton();
            this.radioButtonGenero1 = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerAdmissao = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSetor = new System.Windows.Forms.GroupBox();
            this.checkBoxSetor6 = new System.Windows.Forms.CheckBox();
            this.checkBoxSetor5 = new System.Windows.Forms.CheckBox();
            this.checkBoxSetor4 = new System.Windows.Forms.CheckBox();
            this.checkBoxSetor3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSetor2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSetor1 = new System.Windows.Forms.CheckBox();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxSetor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(129, 112);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 25);
            this.textBoxNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(129, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(494, 25);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSenha.Location = new System.Drawing.Point(129, 208);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(269, 25);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioGenero3);
            this.groupBoxGenero.Controls.Add(this.radioButtonGenero2);
            this.groupBoxGenero.Controls.Add(this.radioButtonGenero1);
            this.groupBoxGenero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxGenero.Location = new System.Drawing.Point(129, 257);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(222, 136);
            this.groupBoxGenero.TabIndex = 6;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Identidade de Gênero:";
            // 
            // radioGenero3
            // 
            this.radioGenero3.AutoSize = true;
            this.radioGenero3.Location = new System.Drawing.Point(42, 90);
            this.radioGenero3.Name = "radioGenero3";
            this.radioGenero3.Size = new System.Drawing.Size(149, 23);
            this.radioGenero3.TabIndex = 8;
            this.radioGenero3.TabStop = true;
            this.radioGenero3.Text = "Gênero Não-Binário";
            this.radioGenero3.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenero2
            // 
            this.radioButtonGenero2.AutoSize = true;
            this.radioButtonGenero2.Location = new System.Drawing.Point(42, 59);
            this.radioButtonGenero2.Name = "radioButtonGenero2";
            this.radioButtonGenero2.Size = new System.Drawing.Size(162, 23);
            this.radioButtonGenero2.TabIndex = 7;
            this.radioButtonGenero2.TabStop = true;
            this.radioButtonGenero2.Text = "Homem (Trans ou Cis)";
            this.radioButtonGenero2.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenero1
            // 
            this.radioButtonGenero1.AutoSize = true;
            this.radioButtonGenero1.Location = new System.Drawing.Point(42, 28);
            this.radioButtonGenero1.Name = "radioButtonGenero1";
            this.radioButtonGenero1.Size = new System.Drawing.Size(157, 23);
            this.radioButtonGenero1.TabIndex = 6;
            this.radioButtonGenero1.TabStop = true;
            this.radioButtonGenero1.Text = "Mulher (Trans ou Cis)";
            this.radioButtonGenero1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(532, 426);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 30);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar);
            // 
            // maskedTextBoxDataNascimento
            // 
            this.maskedTextBoxDataNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxDataNascimento.Location = new System.Drawing.Point(546, 112);
            this.maskedTextBoxDataNascimento.Mask = "00/00/0000";
            this.maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            this.maskedTextBoxDataNascimento.Size = new System.Drawing.Size(77, 25);
            this.maskedTextBoxDataNascimento.TabIndex = 2;
            this.maskedTextBoxDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(404, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(436, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Admissão:";
            // 
            // dateTimePickerAdmissao
            // 
            this.dateTimePickerAdmissao.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerAdmissao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdmissao.Location = new System.Drawing.Point(513, 205);
            this.dateTimePickerAdmissao.Name = "dateTimePickerAdmissao";
            this.dateTimePickerAdmissao.Size = new System.Drawing.Size(110, 25);
            this.dateTimePickerAdmissao.TabIndex = 5;
            // 
            // groupBoxSetor
            // 
            this.groupBoxSetor.Controls.Add(this.checkBoxSetor6);
            this.groupBoxSetor.Controls.Add(this.checkBoxSetor5);
            this.groupBoxSetor.Controls.Add(this.checkBoxSetor4);
            this.groupBoxSetor.Controls.Add(this.checkBoxSetor3);
            this.groupBoxSetor.Controls.Add(this.checkBoxSetor2);
            this.groupBoxSetor.Controls.Add(this.checkBoxSetor1);
            this.groupBoxSetor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSetor.Location = new System.Drawing.Point(368, 257);
            this.groupBoxSetor.Name = "groupBoxSetor";
            this.groupBoxSetor.Size = new System.Drawing.Size(255, 136);
            this.groupBoxSetor.TabIndex = 10;
            this.groupBoxSetor.TabStop = false;
            this.groupBoxSetor.Text = "Setor:";
            this.groupBoxSetor.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBoxSetor6
            // 
            this.checkBoxSetor6.AutoSize = true;
            this.checkBoxSetor6.Location = new System.Drawing.Point(123, 91);
            this.checkBoxSetor6.Name = "checkBoxSetor6";
            this.checkBoxSetor6.Size = new System.Drawing.Size(71, 23);
            this.checkBoxSetor6.TabIndex = 14;
            this.checkBoxSetor6.Text = "Outros";
            this.checkBoxSetor6.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetor5
            // 
            this.checkBoxSetor5.AutoSize = true;
            this.checkBoxSetor5.Location = new System.Drawing.Point(123, 60);
            this.checkBoxSetor5.Name = "checkBoxSetor5";
            this.checkBoxSetor5.Size = new System.Drawing.Size(46, 23);
            this.checkBoxSetor5.TabIndex = 12;
            this.checkBoxSetor5.Text = "RH";
            this.checkBoxSetor5.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetor4
            // 
            this.checkBoxSetor4.AutoSize = true;
            this.checkBoxSetor4.Location = new System.Drawing.Point(123, 29);
            this.checkBoxSetor4.Name = "checkBoxSetor4";
            this.checkBoxSetor4.Size = new System.Drawing.Size(117, 23);
            this.checkBoxSetor4.TabIndex = 10;
            this.checkBoxSetor4.Text = "Administrativo";
            this.checkBoxSetor4.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetor3
            // 
            this.checkBoxSetor3.AutoSize = true;
            this.checkBoxSetor3.Location = new System.Drawing.Point(16, 91);
            this.checkBoxSetor3.Name = "checkBoxSetor3";
            this.checkBoxSetor3.Size = new System.Drawing.Size(88, 23);
            this.checkBoxSetor3.TabIndex = 13;
            this.checkBoxSetor3.Text = "Comercial";
            this.checkBoxSetor3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetor2
            // 
            this.checkBoxSetor2.AutoSize = true;
            this.checkBoxSetor2.Location = new System.Drawing.Point(16, 60);
            this.checkBoxSetor2.Name = "checkBoxSetor2";
            this.checkBoxSetor2.Size = new System.Drawing.Size(101, 23);
            this.checkBoxSetor2.TabIndex = 11;
            this.checkBoxSetor2.Text = "Operacional";
            this.checkBoxSetor2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetor1
            // 
            this.checkBoxSetor1.AutoSize = true;
            this.checkBoxSetor1.Location = new System.Drawing.Point(16, 29);
            this.checkBoxSetor1.Name = "checkBoxSetor1";
            this.checkBoxSetor1.Size = new System.Drawing.Size(90, 23);
            this.checkBoxSetor1.TabIndex = 9;
            this.checkBoxSetor1.Text = "Financeiro";
            this.checkBoxSetor1.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 485);
            this.Controls.Add(this.groupBoxSetor);
            this.Controls.Add(this.dateTimePickerAdmissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxDataNascimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systema Coruja ::: Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxSetor.ResumeLayout(false);
            this.groupBoxSetor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioGenero3;
        private System.Windows.Forms.RadioButton radioButtonGenero2;
        private System.Windows.Forms.RadioButton radioButtonGenero1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmissao;
        private System.Windows.Forms.GroupBox groupBoxSetor;
        private System.Windows.Forms.CheckBox checkBoxSetor4;
        private System.Windows.Forms.CheckBox checkBoxSetor3;
        private System.Windows.Forms.CheckBox checkBoxSetor2;
        private System.Windows.Forms.CheckBox checkBoxSetor1;
        private System.Windows.Forms.CheckBox checkBoxSetor6;
        private System.Windows.Forms.CheckBox checkBoxSetor5;
    }
}

