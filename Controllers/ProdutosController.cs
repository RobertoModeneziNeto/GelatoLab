using GelatoLab.Models;
using GelatoLab.Services;
using System.Data;
using System.Data.SqlClient;

namespace GelatoLab.Controllers
{
    public class ProdutosController
    {
        // Conexão com o banco de dados
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        // ============================================================
        // INSERIR PRODUTO
        // ============================================================
        public int Inserir(Produtos produto)
        {
            string query =
                "INSERT INTO Produto (Nome, Quantidade, Preco, codBarras, TipoUnidade, IdCategoria, IdFornecedor) " +
                "VALUES (@Nome, @Quantidade, @Preco, @CodBarras, @TipoUnidade, @IdCategoria, @IdFornecedor)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@CodBarras", produto.codBarras);
            command.Parameters.AddWithValue("@TipoUnidade", produto.TipoUnidade);
            command.Parameters.AddWithValue("@IdCategoria", produto.Categoria.IdCategoria);
            command.Parameters.AddWithValue("@IdFornecedor", produto.Fornecedor.IdFornecedor);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // ALTERAR PRODUTO
        // ============================================================
        public int Alterar(Produtos produto)
        {
            string query =
                "UPDATE Produto SET " +
                "Nome = @Nome, " +
                "Quantidade = @Quantidade, " +
                "Preco = @Preco, " +
                "codBarras = @CodBarras, " +
                "TipoUnidade = @TipoUnidade, " +
                "IdCategoria = @IdCategoria, " +
                "IdFornecedor = @IdFornecedor " +
                "WHERE IdProduto = @IdProduto";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@CodBarras", produto.codBarras);
            command.Parameters.AddWithValue("@TipoUnidade", produto.TipoUnidade);
            command.Parameters.AddWithValue("@IdCategoria", produto.Categoria.IdCategoria);
            command.Parameters.AddWithValue("@IdFornecedor", produto.Fornecedor.IdFornecedor);
            command.Parameters.AddWithValue("@IdProduto", produto.IdProduto);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // EXCLUIR PRODUTO
        // ============================================================
        public int Excluir(int idProduto)
        {
            string query = "DELETE FROM Produto WHERE IdProduto = @IdProduto";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdProduto", idProduto);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // OBTER PRODUTO POR ID
        // ============================================================
        public Produtos GetById(int idProduto)
        {
            string query =
                "SELECT p.*, c.Nome AS CategoriaNome, f.Nome AS FornecedorNome " +
                "FROM Produto p " +
                "INNER JOIN Categoria c ON p.IdCategoria = c.IdCategoria " +
                "INNER JOIN Fornecedor f ON p.IdFornecedor = f.IdFornecedor " +
                "WHERE p.IdProduto = @IdProduto";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdProduto", idProduto);

            DataTable dt = dataBase.GetDataTable(command);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            Produtos produto = new Produtos();

            produto.IdProduto = (int)row["IdProduto"];
            produto.Nome = (string)row["Nome"];
            produto.Quantidade = (int)row["Quantidade"];
            produto.Preco = (decimal)row["Preco"];
            produto.codBarras = row["codBarras"].ToString();
            produto.TipoUnidade = row["TipoUnidade"].ToString();

            // Categoria
            produto.Categoria = new Categoria()
            {
                IdCategoria = (int)row["IdCategoria"],
                Nome = row["CategoriaNome"].ToString()
            };

            // Fornecedor
            produto.Fornecedor = new Fornecedor()
            {
                IdFornecedor = (int)row["IdFornecedor"],
                Nome = row["FornecedorNome"].ToString()
            };

            return produto;
        }

        // ============================================================
        // GET ALL
        // ============================================================
        public ProdutosCollection GetAll()
        {
            return GetByFilter();
        }

        // ============================================================
        // MÉTODO GENÉRICO COM FILTRO
        // ============================================================
        public ProdutosCollection GetByFilter(string filtro = "")
        {
            string query =
                "SELECT p.*, c.Nome AS CategoriaNome, f.Nome AS FornecedorNome " +
                "FROM Produto p " +
                "INNER JOIN Categoria c ON p.IdCategoria = c.IdCategoria " +
                "INNER JOIN Fornecedor f ON p.IdFornecedor = f.IdFornecedor";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY p.Nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dt = dataBase.GetDataTable(command);

            ProdutosCollection produtos = new ProdutosCollection();

            foreach (DataRow row in dt.Rows)
            {
                Produtos produto = new Produtos();

                produto.IdProduto = (int)row["IdProduto"];
                produto.Nome = (string)row["Nome"];
                produto.Quantidade = (int)row["Quantidade"];
                produto.Preco = (decimal)row["Preco"];
                produto.codBarras = row["codBarras"].ToString();
                produto.TipoUnidade = row["TipoUnidade"].ToString();

                produto.Categoria = new Categoria()
                {
                    IdCategoria = (int)row["IdCategoria"],
                    Nome = row["CategoriaNome"].ToString()
                };

                produto.Fornecedor = new Fornecedor()
                {
                    IdFornecedor = (int)row["IdFornecedor"],
                    Nome = row["FornecedorNome"].ToString()
                };

                produtos.Add(produto);
            }

            return produtos;
        }

        // ============================================================
        // CONSULTAR POR NOME
        // ============================================================
        public ProdutosCollection GetByName(string value)
        {
            return GetByFilter($"p.Nome LIKE '%{value}%'");
        }

        // ============================================================
        // CONSULTAR POR CÓDIGO DE BARRAS
        // ============================================================
        public ProdutosCollection GetByCodBarras(string value)
        {
            return GetByFilter($"p.codBarras LIKE '%{value}%'");
        }
    }
}
