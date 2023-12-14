using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_17
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public void AdicionarRegisto(string nome)
        {
            Registos.Items.Add(nome);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
