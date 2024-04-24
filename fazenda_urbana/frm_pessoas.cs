using System;
using System.Data;
using System.Windows.Forms;
using fazenda_urbana.Properties;
using MySql.Data.MySqlClient;

namespace fazenda_urbana
{
    public partial class frm_pessoas : Form
    {
        public frm_pessoas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Add("ColumnID", "ID");
            dataGridView1.Columns.Add("ColumnNome", "Nome");
            dataGridView1.Columns.Add("ColumnCPF", "CPF");
            dataGridView1.Columns.Add("ColumnCNPJ", "CNPJ");
            dataGridView1.Columns.Add("ColumnEmail", "E-mail");
            dataGridView1.Columns.Add("ColumnEndereco", "Endereço");
            dataGridView1.Columns.Add("ColumnCargo", "Cargo");
        }

        private void CarregarDados()
        {
            dataGridView1.Rows.Clear();
            if (Loader.Connect() == true)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Pessoas", Loader.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["id"], dataReader["nome"], dataReader["cpf"], dataReader["cnpj"], dataReader["email"], dataReader["endereco"], dataReader["cargo"]);
                }

                dataReader.Close();
                Loader.Disconnect();
            }
        }

        private void InserirPessoa(string nome, string cpf, string cnpj, string email, string endereco, string cargo)
        {
            if (Loader.Connect() == true)
            {
                string query = "INSERT INTO Pessoas (nome, cpf, cnpj, email, endereco, cargo) VALUES (@nome, @cpf, @cnpj, @email, @endereco, @cargo)";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@cargo", cargo);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }
        private void AtualizarPessoa(int id, string nome, string cpf, string cnpj, string email, string endereco, string cargo)
        {
            if (Loader.Connect() == true)
            {
                string query = "UPDATE Pessoas SET nome = @nome, cpf = @cpf, cnpj = @cnpj, email = @email, endereco = @endereco, cargo = @cargo WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@cargo", cargo);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }

        private void DeletarPessoa(int id)
        {
            if (Loader.Connect() == true)
            {
                string query = "DELETE FROM Pessoas WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                Loader.Disconnect();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void LimparCampos()
        {
            txt_nome.Text = "";
            txt_cpf.Text = "";
            txt_cnpj.Text = "";
            txt_email.Text = "";
            txt_endereco.Text = "";
            txt_cargo.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_nome.Text = row.Cells["ColumnNome"].Value.ToString();
                txt_cpf.Text = row.Cells["ColumnCPF"].Value.ToString();
                txt_cnpj.Text = row.Cells["ColumnCNPJ"].Value.ToString();
                txt_email.Text = row.Cells["ColumnEmail"].Value.ToString();
                txt_endereco.Text = row.Cells["ColumnEndereco"].Value.ToString();
                txt_cargo.Text = row.Cells["ColumnCargo"].Value.ToString();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string cpf = txt_cpf.Text;
            string cnpj = txt_cnpj.Text;
            string email = txt_email.Text;
            string endereco = txt_endereco.Text;
            string cargo = txt_cargo.Text;

            InserirPessoa(nome, cpf, cnpj, email, endereco, cargo);
            CarregarDados();
            LimparCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ColumnID"].Value);
                string nome = txt_nome.Text;
                string cpf = txt_cpf.Text;
                string cnpj = txt_cnpj.Text;
                string email = txt_email.Text;
                string endereco = txt_endereco.Text;
                string cargo = txt_cargo.Text;

                AtualizarPessoa(id, nome, cpf, cnpj, email, endereco, cargo);
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione a pessoa que deseja editar.");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ColumnID"].Value);
                DeletarPessoa(id);
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione a pessoa que deseja excluir.");
            }
        }
    }
}
