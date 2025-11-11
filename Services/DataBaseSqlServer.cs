using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoLab.Services
{
    public class DataBaseSqlServer
    {
        private SqlConnection GetConnection()
        {
            //Variavel q ira armazenar a conexão
            SqlConnection connection = new SqlConnection();

            //Definindo a string de conexão
            //Dados para conectar co o servidor
            //Precisamos do Host (Nome/IP)
            //Nome do banco de dados
            //Autenticação (Usuario e Senha ou Autenticação do Windows)
            connection.ConnectionString =
                "Data Source=DESKTOP-B3K4KKV\\MSSQLSERVER01;" + //Nome do Servidor (RAPAZIADA MUDAR O NOME DO SERVIDOR AQUI)
                "Initial Catalog=GelatoLab;" + //Nome do Banco
                "Integrated Security=SSPI;";// Autenticação pelo Windows

            //Abrir a conexão com o banco
            connection.Open();
            //Retornar a conexão aberta
            return connection;
        }


        //Metodo Publico para a execução de comandos
        //de manipulação (Insert, Update, Delete)
        //Retornar a quantidade de linhas afetadas
        public int ExecuteSQL(SqlCommand command)
        {
            //Recuperar a conexão com o banco
            command.Connection = GetConnection();
            //Executar o comando e retornar o resultado
            return command.ExecuteNonQuery();
        }

        //Método publico que executa comando SELECT no banco de dados
        //Retorna apenas a primeira coluna da primeira linha do banco
        //Utilizamos o tipo de dados object pois não sabemos o tipo
        //de dados que será retornado
        public object ExecuteScalar(SqlCommand command)
        {
            command.Connection = GetConnection();
            return command.ExecuteScalar();
        }

        //Método publico que executa comando SQL 
        //Retorna todas as linhas e colunas da consult
        public DataTable GetDataTable(SqlCommand command)
        {
            // Criando o objeto DataTable
            DataTable dataTable = new DataTable();

            // Definindo a conexão do comando SQL
            command.Connection = GetConnection();
            // Criando o objeto SqlDataAdapter e vinculando o comando
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            // Preenchendo o DataTable com os dados do banco
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

    }
}
