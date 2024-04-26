using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fazenda_urbana.Properties;
using MySql.Data.MySqlClient;

namespace fazenda_urbana
{
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Add("ColumnIdProduto", "ID Produto");
            dataGridView1.Columns.Add("ColumnDescricao", "Descrição");
            dataGridView1.Columns.Add("ColumnValor", "Valor");
            dataGridView1.Columns.Add("ColumnCategoria", "Categoria");
        }

        private void CarregarDados()
        {
            dataGridView1.Rows.Clear();
            if (Loader.Connect() == true)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM produtos", Loader.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["Id_Produto"], dataReader["desc_produto"], dataReader["valor"], dataReader["Id_categoria"]);
                }

                dataReader.Close();
                Loader.Disconnect();
            }
        }

        private void LimparCampos()
        {
            txt_descricao.Text = "";
            txt_valor.Text = "";
            cb_categoria.SelectedIndex = -1;
        }

        private void InserirProduto(string descricao, decimal valor, string categoria)
        {
            if (Loader.Connect() == true)
            {
                string query = "INSERT INTO produtos (desc_produto, valor, Id_categoria) VALUES (@desc_produto, @valor, @Id_categoria)";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@desc_produto", descricao);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@Id_categoria", categoria);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            string descricao = txt_descricao.Text.Trim();
            decimal valor = decimal.Parse(txt_valor.Text);
            string categoria = cb_categoria.Text.Trim();

            if (!string.IsNullOrEmpty(descricao) && valor > 0 && !string.IsNullOrEmpty(categoria))
            {
                InserirProduto(descricao, valor, categoria);
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idProduto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ColumnIdProduto"].Value);
                DeletarProduto(idProduto);
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione o produto que deseja excluir.");
            }
        }

        private void DeletarProduto(int idProduto)
        {
            if (Loader.Connect() == true)
            {
                string query = "DELETE FROM produtos WHERE id_Produto = @id_produto";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@id_produto", idProduto);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }
    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}