using System;
using System.Windows.Forms;

namespace fazenda_urbana
{
    public partial class frm_sair : Form
    {
        public frm_sair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Código para o label1, se necessário
        }

        private void frm_sair_Load(object sender, EventArgs e)
        {
            // Código para o evento Load do formulário, se necessário
        }
    }
}
