using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_urbana
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm_pessoas frm = new frm_pessoas();
            frm.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pessoas frm = new frm_pessoas();
            frm.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            frm_relatorio frm = new frm_relatorio();
            frm.Show();
        }

        private void btn_cad_vendas_Click(object sender, EventArgs e)
        {
            frm_vendas frm = new frm_vendas();
            frm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            frm_sair frm = new frm_sair();
            frm.Show();
        }
    }
}
