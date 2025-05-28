using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Usuários
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public void cadastrar()
        {
            try {
                using (MySqlConnection conexao = new ConexaoDB().Conectar()) {
                    string query = "INSERT INTO usuarios (nome, email, senha) VALUES (@nome, @email, @senha)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", Nome);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@senha", Senha);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Usuário cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao cadastrar usuário.");
                        }
                    }
                }    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
            }
        }
        public void logar()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "SELECT * FROM usuarios WHERE email = @Email AND senha = @Senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Senha", Senha);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ID = reader.GetInt32("id");
                                Nome = reader.GetString("nome");
                                Console.WriteLine("Usuário logado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Email ou senha incorretos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao logar: " + ex.Message);
            }
        }
    }
}
