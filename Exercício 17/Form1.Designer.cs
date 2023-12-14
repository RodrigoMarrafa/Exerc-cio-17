namespace Exercício_17
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_Nome = new Label();
            label_Email = new Label();
            label_Password = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cbPassword = new CheckBox();
            btnRegistar = new Button();
            btnFechar = new Button();
            btnVerRegistos = new Button();
            SuspendLayout();
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.BackColor = Color.Transparent;
            label_Nome.ForeColor = Color.White;
            label_Nome.Location = new Point(63, 50);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(43, 15);
            label_Nome.TabIndex = 0;
            label_Nome.Text = "Nome:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.BackColor = Color.Transparent;
            label_Email.ForeColor = Color.White;
            label_Email.Location = new Point(67, 92);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(39, 15);
            label_Email.TabIndex = 1;
            label_Email.Text = "Email:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.BackColor = Color.Transparent;
            label_Password.ForeColor = Color.White;
            label_Password.Location = new Point(46, 134);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(60, 15);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password:";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(112, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(148, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(112, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(112, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(148, 23);
            txtPassword.TabIndex = 5;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.BackColor = Color.Transparent;
            cbPassword.BackgroundImageLayout = ImageLayout.Center;
            cbPassword.ForeColor = Color.White;
            cbPassword.Location = new Point(266, 133);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(67, 19);
            cbPassword.TabIndex = 6;
            cbPassword.Text = "Mostrar";
            cbPassword.UseVisualStyleBackColor = false;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // btnRegistar
            // 
            btnRegistar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistar.Location = new Point(142, 170);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(85, 36);
            btnRegistar.TabIndex = 7;
            btnRegistar.Text = "Registar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.Location = new Point(281, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(66, 32);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnVerRegistos
            // 
            btnVerRegistos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerRegistos.Location = new Point(233, 192);
            btnVerRegistos.Name = "btnVerRegistos";
            btnVerRegistos.Size = new Size(114, 32);
            btnVerRegistos.TabIndex = 9;
            btnVerRegistos.Text = "Ver Registos";
            btnVerRegistos.UseVisualStyleBackColor = true;
            btnVerRegistos.Click += btnVerRegistos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(359, 236);
            Controls.Add(btnVerRegistos);
            Controls.Add(btnFechar);
            Controls.Add(btnRegistar);
            Controls.Add(cbPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label_Password);
            Controls.Add(label_Email);
            Controls.Add(label_Nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Nome;
        private Label label_Email;
        private Label label_Password;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox cbPassword;
        private Button btnRegistar;
        private Button btnFechar;
        private Button btnVerRegistos;
    }
}