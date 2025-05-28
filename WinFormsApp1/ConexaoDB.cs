using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    class ConexaoDB
    {
        private string conexao = "Server=localhost;Database=Compromissos;Uid=root;Pwd=;";

        public MySqlConnection Conectar()
        {
            try {
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();
                Console.WriteLine("Conexão estabelecida com sucesso!");
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }
    }
}
