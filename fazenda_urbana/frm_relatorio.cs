using System;
using System.Data;
using System.Windows.Forms;
using fazenda_urbana.Properties;
using MySql.Data.MySqlClient;

namespace fazenda_urbana
{
    public partial class frm_relatorio : Form
    {
        public frm_relatorio()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarDadosProdutos();
        }

        private void ConfigurarListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID Produto", 100);
            listView1.Columns.Add("Descrição", 200);
            listView1.Columns.Add("Valor", 100);
            listView1.Columns.Add("Categoria", 100);
        }

        private void CarregarDadosProdutos()
        {
            listView1.Items.Clear();
            if (Loader.Connect() == true)
            {
                string query = "SELECT * FROM produtos";
                MySqlCommand cmd = new MySqlCommand(query, Loader.Connection);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id_Produto"].ToString());
                            item.SubItems.Add(reader["desc_produto"].ToString());
                            item.SubItems.Add(reader["valor"].ToString());
                            item.SubItems.Add(reader["Id_categoria"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados de produtos: " + ex.Message);
                }

                Loader.Disconnect();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
