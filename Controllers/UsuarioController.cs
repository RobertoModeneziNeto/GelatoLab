using GelatoLab.Models;
using GelatoLab.Services;
using System.Data;
using System.Data.SqlClient;

namespace GelatoLab.Controllers
{
    // Classe responsável por controlar as ações referentes ao usuário
    // Regras de negócio + comunicação com o banco
    public class UsuarioController
    {
        // Objeto de acesso ao banco de dados
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        // ============================================================
        // INSERIR USUÁRIO
        // ============================================================
        public int Inserir(Usuario usuario)
        {
            string query =
                "INSERT INTO Usuario (Nome, Login, Senha, Tipo) " +
                "VALUES (@Nome, @Login, @Senha, @Tipo)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", usuario.Nome);
            command.Parameters.AddWithValue("@Login", usuario.Login);
            command.Parameters.AddWithValue("@Senha", usuario.Senha);
            command.Parameters.AddWithValue("@Tipo", usuario.Tipo);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // ALTERAR USUÁRIO
        // ============================================================
        public int Alterar(Usuario usuario)
        {
            string query =
                "UPDATE Usuario SET " +
                "Nome = @Nome, " +
                "Login = @Login, " +
                "Senha = @Senha, " +
                "Tipo = @Tipo " +
                "WHERE IdUsuario = @Id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", usuario.Nome);
            command.Parameters.AddWithValue("@Login", usuario.Login);
            command.Parameters.AddWithValue("@Senha", usuario.Senha);
            command.Parameters.AddWithValue("@Tipo", usuario.Tipo);
            command.Parameters.AddWithValue("@Id", usuario.IdUsuario);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // EXCLUIR USUÁRIO
        // ============================================================
        public int Excluir(int id)
        {
            string query = "DELETE FROM Usuario WHERE IdUsuario = @Id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", id);

            return dataBase.ExecuteSQL(command);
        }

        // ============================================================
        // OBTER USUÁRIO POR ID
        // ============================================================
        public Usuario GetById(int id)
        {
            string query =
                "SELECT * FROM Usuario WHERE IdUsuario = @Id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", id);

            DataTable dt = dataBase.GetDataTable(command);

            if (dt.Rows.Count == 0)
                return null;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
            usuario.Nome = (string)dt.Rows[0]["Nome"];
            usuario.Login = (string)dt.Rows[0]["Login"];
            usuario.Senha = (string)dt.Rows[0]["Senha"];
            usuario.Tipo = (string)dt.Rows[0]["Tipo"];

            return usuario;
        }

        // ============================================================
        // OBTER TODOS OS USUÁRIOS
        // ============================================================
        public UsuarioCollection GetAll()
        {
            return GetByFilter();
        }

        // ============================================================
        // FILTRO GENÉRICO
        // ============================================================
        public UsuarioCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Usuario";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY Nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dt = dataBase.GetDataTable(command);

            UsuarioCollection usuarios = new UsuarioCollection();

            foreach (DataRow row in dt.Rows)
            {
                Usuario usuario = new Usuario();

                usuario.IdUsuario = (int)row["IdUsuario"];
                usuario.Nome = (string)row["Nome"];
                usuario.Login = (string)row["Login"];
                usuario.Senha = (string)row["Senha"];
                usuario.Tipo = (string)row["Tipo"];

                usuarios.Add(usuario);
            }

            return usuarios;
        }

        // ============================================================
        // CONSULTAR POR NOME
        // ============================================================
        public UsuarioCollection GetByName(string value)
        {
            return GetByFilter($"Nome LIKE '%{value}%'");
        }

        // ============================================================
        // CONSULTAR POR LOGIN
        // ============================================================
        public UsuarioCollection GetByLogin(string value)
        {
            return GetByFilter($"Login LIKE '%{value}%'");
        }

        // ============================================================
        // LOGIN (autenticação)
        // ============================================================
        public Usuario Login(string login, string senha)
        {
            string query =
                "SELECT * FROM Usuario WHERE Login = @Login AND Senha = @Senha";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Login", login);
            command.Parameters.AddWithValue("@Senha", senha);

            DataTable dt = dataBase.GetDataTable(command);

            if (dt.Rows.Count == 0)
                return null;

            Usuario usuario = new Usuario();

            usuario.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
            usuario.Nome = (string)dt.Rows[0]["Nome"];
            usuario.Login = (string)dt.Rows[0]["Login"];
            usuario.Senha = (string)dt.Rows[0]["Senha"];
            usuario.Tipo = (string)dt.Rows[0]["Tipo"];

            return usuario;
        }
    }
}
