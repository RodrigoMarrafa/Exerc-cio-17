namespace Exercício_17
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            f2=new Form2(this);
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" | txtEmail.Text == "" | txtPassword.Text == "")
                MessageBox.Show("Preencha todas as caixas para registar","Erro de Validação",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            else 
            {
                Utilizador.Nome = txtNome.Text;
                Utilizador.Email = txtEmail.Text;
                Utilizador.Password = txtPassword.Text;
                f2.AdicionarRegisto(Utilizador.Nome);
                MessageBox.Show("Utilizador " + Utilizador.Nome + " registado com sucesso!");
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnVerRegistos_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }
    }
}