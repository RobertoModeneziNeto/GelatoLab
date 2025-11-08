using GelatoLab.Models;
using GelatoLab.Services;
using System.Data;
using System.Data.SqlClient;

namespace GelatoLab.Controllers
{
    public class CategoriaController
    {
        // Conexão com o banco
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        // ============================================================
        // INSERIR CATEGORIA
        // ============================================================
        public int Inserir(Categoria categoria)
        {
            string query =
                "INSERT INTO Categoria (Nome, Descricao, Ativo) " +
                "VALUES (@Nome, @Descricao, @Ativo)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", categoria.Nome);
            command.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            command.Parameters.AddWithValue("@Ativo", categoria.Ativo);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // ALTERAR CATEGORIA
        // ============================================================
        public int Alterar(Categoria categoria)
        {
            string query =
                "UPDATE Categoria SET " +
                "Nome = @Nome, " +
                "Descricao = @Descricao, " +
                "Ativo = @Ativo " +
                "WHERE IdCategoria = @IdCategoria";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", categoria.Nome);
            command.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            command.Parameters.AddWithValue("@Ativo", categoria.Ativo);
            command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // EXCLUIR CATEGORIA
        // ============================================================
        public int Excluir(int idCategoria)
        {
            string query = "DELETE FROM Categoria WHERE IdCategoria = @IdCategoria";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdCategoria", idCategoria);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // OBTER CATEGORIA POR ID
        // ============================================================
        public Categoria GetById(int idCategoria)
        {
            string query =
                "SELECT * FROM Categoria WHERE IdCategoria = @IdCategoria";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdCategoria", idCategoria);

            DataTable dt = dataBase.GetDataTable(command);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            Categoria categoria = new Categoria();

            categoria.IdCategoria = (int)row["IdCategoria"];
            categoria.Nome = (string)row["Nome"];
            categoria.Descricao = (string)row["Descricao"];
            categoria.Ativo = (int)row["Ativo"];

            return categoria;
        }

        // ============================================================
        // OBTER TODAS
        // ============================================================
        public CategoriaCollection GetAll()
        {
            return GetByFilter();
        }

        // ============================================================
        // FILTRO GENÉRICO
        // ============================================================
        public CategoriaCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Categoria";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY Nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dt = dataBase.GetDataTable(command);

            CategoriaCollection categorias = new CategoriaCollection();

            foreach (DataRow row in dt.Rows)
            {
                Categoria categoria = new Categoria();

                categoria.IdCategoria = (int)row["IdCategoria"];
                categoria.Nome = (string)row["Nome"];
                categoria.Descricao = (string)row["Descricao"];
                categoria.Ativo = (int)row["Ativo"];

                categorias.Add(categoria);
            }

            return categorias;
        }

        // ============================================================
        // CONSULTAR POR NOME
        // ============================================================
        public CategoriaCollection GetByName(string value)
        {
            return GetByFilter($"Nome LIKE '%{value}%'");
        }

        // ============================================================
        // CONSULTAR APENAS CATEGORIAS ATIVAS
        // ============================================================
        public CategoriaCollection GetAtivas()
        {
            return GetByFilter("Ativo = 1");
        }
    }
}
