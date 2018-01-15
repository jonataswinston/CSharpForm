using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CBanco
    {
        private static string servidor = "localhost";
        private static string banco = "test";
        private static string usuario = "applet";
        private static string senha = "";
        private static string tabela = "alunos";

        public static void CadastrarAlunoSQL(string nome, string endereco, string telefone, string celular, string email)
        {
            var url = "Server="+servidor+";Database="+banco+";Uid="+usuario+";Pwd="+senha;
            var connection = new MySqlConnection(url);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                //command.CommandText = "INSERT INTO " + tabela + " ('NOME','ENDERECO','TELEFONE','CELULAR','EMAIL') VALUES ('"+nome+"','"+endereco+"','"+telefone+"','"+celular+"','"+email+"')";
                command = new MySqlCommand("INSERT INTO " + tabela + " (NOME, ENDERECO, TELEFONE, CELULAR, EMAIL) VALUES (@nome, @endereco, @telefone, @celular, @email)", connection);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@endereco", endereco);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@celular", celular);
                command.Parameters.AddWithValue("@email", email);
                //command.ExecuteReader();
                //

                command.ExecuteNonQuery();

            }
            finally
            {

            }
        }
    }
}
