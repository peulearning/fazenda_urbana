using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fazenda_urbana.Properties
{
    public static class Loader
    {
        public static MySqlConnection Connection { get; private set; }

        public static bool Connect()
        {
            string connectionString = "Server=localhost;Database=fazenda_urbana;Uid=root;Pwd=;";
            Connection = new MySqlConnection(connectionString);

            try
            {
                Connection.Open();
                Console.WriteLine("Conexão bem-sucedida!");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write("Erro ao conectar-se ao banco de dados: " + ex.Message);
                return false;
            }
        }

        public static void Disconnect()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
                Console.WriteLine("Conexão Encerrada !");
            }
        }
    }
}
