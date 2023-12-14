namespace Exercício_17
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Registos = new ListBox();
            btnFechar = new Button();
            btnRegistar = new Button();
            SuspendLayout();
            // 
            // Registos
            // 
            Registos.FormattingEnabled = true;
            Registos.ItemHeight = 15;
            Registos.Location = new Point(122, 50);
            Registos.Name = "Registos";
            Registos.Size = new Size(120, 124);
            Registos.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.Location = new Point(281, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(66, 32);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnRegistar
            // 
            btnRegistar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistar.Location = new Point(261, 192);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(86, 32);
            btnRegistar.TabIndex = 10;
            btnRegistar.Text = "Registar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(359, 236);
            Controls.Add(btnRegistar);
            Controls.Add(btnFechar);
            Controls.Add(Registos);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Registos;
        private Button btnFechar;
        private Button btnRegistar;
    }
}