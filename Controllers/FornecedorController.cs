using GelatoLab.Models;
using GelatoLab.Services;
using System.Data;
using System.Data.SqlClient;

namespace GelatoLab.Controllers
{
    public class FornecedorController
    {
        // Acesso ao banco
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        // INSERIR FORNECEDOR
        public int Inserir(Fornecedor fornecedor)
        {
            string query =
                "INSERT INTO Fornecedor (Nome, Cnpj, Telefone, Email) " +
                "VALUES (@Nome, @Cnpj, @Telefone, @Email)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);

            return dataBase.ExecuteSQL(command);
        }

        // ALTERAR FORNECEDOR
        public int Alterar(Fornecedor fornecedor)
        {
            string query =
                "UPDATE Fornecedor SET " +
                "Nome = @Nome, " +
                "Cnpj = @Cnpj, " +
                "Telefone = @Telefone, " +
                "Email = @Email " +
                "WHERE IdFornecedor = @IdFornecedor";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);
            command.Parameters.AddWithValue("@IdFornecedor", fornecedor.IdFornecedor);

            return dataBase.ExecuteSQL(command);
        }

        // EXCLUIR FORNECEDOR
        public int Excluir(int idFornecedor)
        {
            string query =
                "DELETE FROM Fornecedor WHERE IdFornecedor = @IdFornecedor";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdFornecedor", idFornecedor);

            return dataBase.ExecuteSQL(command);
        }

        // OBTER FORNECEDOR POR ID
        public Fornecedor GetById(int idFornecedor)
        {
            string query =
                "SELECT * FROM Fornecedor WHERE IdFornecedor = @IdFornecedor";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdFornecedor", idFornecedor);

            DataTable dt = dataBase.GetDataTable(command);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            Fornecedor fornecedor = new Fornecedor();

            fornecedor.IdFornecedor = (int)row["IdFornecedor"];
            fornecedor.Nome = (string)row["Nome"];
            fornecedor.Cnpj = (string)row["Cnpj"];
            fornecedor.Telefone = (string)row["Telefone"];
            fornecedor.Email = (string)row["Email"];

            return fornecedor;
        }

        // OBTER TODOS
        public FornecedorCollection GetAll()
        {
            return GetByFilter();
        }

        // FILTRO GENÉRICO
        public FornecedorCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Fornecedor";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY Nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dt = dataBase.GetDataTable(command);

            FornecedorCollection fornecedores = new FornecedorCollection();

            foreach (DataRow row in dt.Rows)
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.IdFornecedor = (int)row["IdFornecedor"];
                fornecedor.Nome = (string)row["Nome"];
                fornecedor.Cnpj = (string)row["Cnpj"];
                fornecedor.Telefone = (string)row["Telefone"];
                fornecedor.Email = (string)row["Email"];

                fornecedores.Add(fornecedor);
            }

            return fornecedores;
        }

        // CONSULTAR POR NOME
        public FornecedorCollection GetByName(string value)
        {
            return GetByFilter($"Nome LIKE '%{value}%'");
        }

        // CONSULTAR POR CNPJ
        public FornecedorCollection GetByCnpj(string value)
        {
            return GetByFilter($"Cnpj LIKE '%{value}%'");
        }
    }
}
