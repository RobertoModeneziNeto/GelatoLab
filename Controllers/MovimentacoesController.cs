using GelatoLab.Models;
using GelatoLab.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace GelatoLab.Controllers
{
    public class MovimentacaoController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        // ============================================================
        // INSERIR MOVIMENTAÇÃO (Entrada ou Saída)
        // ============================================================
        public int Inserir(Movimentacoes mov)
        {
            string query =
                "INSERT INTO Movimentacoes (Tipo, DataMovimentacao, IdProduto, Quantidade, Observacao) " +
                "VALUES (@Tipo, @DataMovimentacao, @IdProduto, @Quantidade, @Observacao)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Tipo", mov.Tipo);
            command.Parameters.AddWithValue("@DataMovimentacao", mov.DataMovimentacao);
            command.Parameters.AddWithValue("@IdProduto", mov.Produto.IdProduto);
            command.Parameters.AddWithValue("@Quantidade", mov.Quantidade);
            command.Parameters.AddWithValue("@Observacao", mov.Observacao);

            // 1️⃣ Registra a movimentação
            int linhasAfetadas = dataBase.ExecuteSQL(command);

            // 2️⃣ Atualiza o estoque automaticamente
            AtualizarEstoque(mov);

            return linhasAfetadas;
        }

        // ============================================================
        // ATUALIZAR ESTOQUE APÓS MOVIMENTAÇÃO
        // ============================================================
        private void AtualizarEstoque(Movimentacoes mov)
        {
            string sql = "";

            if (mov.Tipo == "Entrada")
            {
                sql =
                    "UPDATE Produto " +
                    "SET Quantidade = Quantidade + @Quantidade " +
                    "WHERE IdProduto = @IdProduto";
            }
            else if (mov.Tipo == "Saida")
            {
                sql =
                    "UPDATE Produto " +
                    "SET Quantidade = Quantidade - @Quantidade " +
                    "WHERE IdProduto = @IdProduto";
            }

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Quantidade", mov.Quantidade);
            cmd.Parameters.AddWithValue("@IdProduto", mov.Produto.IdProduto);

            dataBase.ExecuteSQL(cmd);
        }

        // ============================================================
        // EXCLUIR MOVIMENTAÇÃO
        // ============================================================
        public int Excluir(int idMovimentacao)
        {
            string query =
                "DELETE FROM Movimentacoes WHERE IdMovimentacao = @IdMovimentacao";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdMovimentacao", idMovimentacao);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // OBTER POR ID
        // ============================================================
        public Movimentacoes GetById(int idMovimentacao)
        {
            string query =
                "SELECT m.*, p.Nome AS ProdutoNome " +
                "FROM Movimentacoes m " +
                "INNER JOIN Produto p ON p.IdProduto = m.IdProduto " +
                "WHERE m.IdMovimentacao = @IdMovimentacao";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdMovimentacao", idMovimentacao);

            DataTable dt = dataBase.GetDataTable(command);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            Movimentacoes mov = new Movimentacoes();

            mov.IdMovimentacao = (int)row["IdMovimentacao"];
            mov.Tipo = (string)row["Tipo"];
            mov.DataMovimentacao = (DateTime)row["DataMovimentacao"];
            mov.Quantidade = (int)row["Quantidade"];
            mov.Observacao = row["Observacao"].ToString();

            mov.Produto = new Produtos()
            {
                IdProduto = (int)row["IdProduto"],
                Nome = row["ProdutoNome"].ToString()
            };

            return mov;
        }

        // ============================================================
        // GET ALL
        // ============================================================
        public MovimentacoesCollection GetAll()
        {
            return GetByFilter();
        }

        // ============================================================
        // FILTRO GENÉRICO
        // ============================================================
        public MovimentacoesCollection GetByFilter(string filtro = "")
        {
            string query =
                "SELECT m.*, p.Nome AS ProdutoNome " +
                "FROM Movimentacoes m " +
                "INNER JOIN Produto p ON p.IdProduto = m.IdProduto";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY m.DataMovimentacao DESC";

            SqlCommand command = new SqlCommand(query);

            DataTable dt = dataBase.GetDataTable(command);

            MovimentacoesCollection list = new MovimentacoesCollection();

            foreach (DataRow row in dt.Rows)
            {
                Movimentacoes mov = new Movimentacoes();

                mov.IdMovimentacao = (int)row["IdMovimentacao"];
                mov.Tipo = (string)row["Tipo"];
                mov.DataMovimentacao = (DateTime)row["DataMovimentacao"];
                mov.Quantidade = (int)row["Quantidade"];
                mov.Observacao = row["Observacao"].ToString();

                mov.Produto = new Produtos()
                {
                    IdProduto = (int)row["IdProduto"],
                    Nome = row["ProdutoNome"].ToString()
                };

                list.Add(mov);
            }

            return list;
        }

        // ============================================================
        // CONSULTAR POR TIPO (Entrada / Saída)
        // ============================================================
        public MovimentacoesCollection GetByTipo(string tipo)
        {
            return GetByFilter($"m.Tipo = '{tipo}'");
        }

        // ============================================================
        // CONSULTAR POR PRODUTO
        // ============================================================
        public MovimentacoesCollection GetByProduto(int idProduto)
        {
            return GetByFilter($"m.IdProduto = {idProduto}");
        }
    }
}
