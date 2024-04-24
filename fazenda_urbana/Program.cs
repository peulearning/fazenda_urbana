using fazenda_urbana.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_urbana
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Conexão com o banco de dados
            if (Loader.Connect())
            {
                Application.Run(new frm_menu());
            }
            else
            {
                MessageBox.Show("Erro ao conectar-se ao banco de dados. Verifique o console para mais detalhes.");
            }

            // Desconexão do banco de dados
            Loader.Disconnect();
        }
    }
}