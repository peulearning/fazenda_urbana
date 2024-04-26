using System;
using System.Data;
using System.Windows.Forms;
using fazenda_urbana.Properties;
using MySql.Data.MySqlClient;

namespace fazenda_urbana
{
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
        }

        private void CarregarDados()
        {
            dataGridView1.Rows.Clear();
            if (Loader.Connect() == true)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categoria", Loader.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["Id_Categoria"], dataReader["desc_categoria"]);
                }

                dataReader.Close();
                Loader.Disconnect();
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Add("ColumnIdCategoria", "ID Categoria");
            dataGridView1.Columns.Add("ColumnDescCategoria", "Descrição");
        }

        private void LimparCampos()
        {
            txt_categoria.Text = ""; // Limpa o campo de texto de categoria
        }

        private void InserirCategoria(string desc_categoria)
        {
            if (Loader.Connect() == true)
            {
                string query = "INSERT INTO categoria (desc_categoria) VALUES (@desc_categoria)";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@desc_categoria", desc_categoria);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }

        private void AtualizarCategoria(int Id_categoria, string desc_categoria)
        {
            if (Loader.Connect() == true)
            {
                string query = "UPDATE Categoria SET desc_categoria = @desc_categoria, WHERE Id_categoria = @Id_categoria";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@desc_categoria", desc_categoria);
 

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            CarregarDados(); // Carrega os dados das categorias no DataGridView ao carregar o formulário
        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {
            // Não é necessário implementar nada aqui, já que estamos lidando com a alteração do texto no campo de categoria
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            try
            {
                string desc_categoria = txt_categoria.Text; // Obtém o texto da caixa de texto de categoria

                if (!string.IsNullOrEmpty(desc_categoria))
                {
                    InserirCategoria(desc_categoria); // Insere a nova categoria no banco de dados
                    CarregarDados(); // Recarrega os dados no DataGridView após inserir a nova categoria
                    LimparCampos(); // Limpa os campos de entrada após cadastrar a nova categoria
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma descrição de categoria válida."); // Exibe uma mensagem de erro se o campo estiver vazio
                }
            }
            catch (Exception ex)
            {
                // Se ocorrer algum erro, exiba uma mensagem para o usuário
                MessageBox.Show("Ocorreu um erro ao tentar cadastrar a categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_categoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ColumnIdCategoria"].Value);
                DeletarCategoria(id_categoria);
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione a categoria que deseja excluir.");
            }
        }

        private void DeletarCategoria(int id_categoria)
        {
            if (Loader.Connect() == true)
            {
                string query = "DELETE FROM categoria WHERE Id_Categoria = @id_categoria";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@id_categoria", id_categoria);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                // Aqui você poderia preencher campos de edição com os dados da categoria selecionada se necessário
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int Id_categoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Categoria"].Value);
                string desc_categoria = txt_categoria.Text;
                

                AtualizarCategoria(Id_categoria, desc_categoria);
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione a categoria que deseja editar.");
            }
        }

    }
}
