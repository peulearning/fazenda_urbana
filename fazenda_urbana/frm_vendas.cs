using System;
using System.Windows.Forms;
using fazenda_urbana.Properties;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fazenda_urbana
{
    public partial class frm_vendas : Form
    {
        public frm_vendas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Add("ColumnIdVenda", "ID Venda");
            dataGridView1.Columns.Add("ColumnIdProduto", "ID Produto");
            dataGridView1.Columns.Add("ColumnClienteId", "ID Cliente");
            dataGridView1.Columns.Add("ColumnClienteTipo", "Tipo de Cliente");
            dataGridView1.Columns.Add("ColumnQuantidade", "Quantidade");
            dataGridView1.Columns.Add("ColumnDataVenda", "Data da Venda");
        }

        private void CarregarDados()
        {
            dataGridView1.Rows.Clear();
            if (Loader.Connect() == true)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Vendas", Loader.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["id_venda"], dataReader["id_produto"], dataReader["cliente_id"], dataReader["cliente_tipo"], dataReader["quantidade"], dataReader["data_venda"]);
                }

                dataReader.Close();
                Loader.Disconnect();
            }
        }

        private void InserirVenda(int idProduto, int clienteId, string clienteTipo, int quantidade, DateTime dataVenda)
        {
            if (Loader.Connect() == true)
            {
                string query = "INSERT INTO Vendas (id_produto, cliente_id, cliente_tipo, quantidade, data_venda) VALUES (@id_produto, @cliente_id, @cliente_tipo, @quantidade, @data_venda)";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@id_produto", idProduto);
                cmd.Parameters.AddWithValue("@cliente_id", clienteId);
                cmd.Parameters.AddWithValue("@cliente_tipo", clienteTipo);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@data_venda", dataVenda);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            // Implementação para inserir uma nova venda
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idVenda = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ColumnIdVenda"].Value);
                ExcluirVenda(idVenda);
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione a venda que deseja excluir.");
            }
        }

        private void ExcluirVenda(int idVenda)
        {
            if (Loader.Connect() == true)
            {
                string query = "DELETE FROM Vendas WHERE id_venda = @id_venda";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@id_venda", idVenda);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implementação para a label1, se necessário
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Implementação para a label5, se necessário
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementação para o evento CellContentClick do DataGridView
        }


        private void frm_vendas_Load(object sender, EventArgs e)
        {
            // Implementação para o evento Load do formulário, se necessário
        }

        private void btn_novo_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
