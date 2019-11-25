using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.DAL
{
    public class UsuarioDAL
    {

        MySQLPersistence _bd = new MySQLPersistence();
        public bool ValidarAutenticacao(string email, string senha)
        {
            string select = @"
                        SELECT COUNT(*)
                        FROM USUARIO
                        WHERE EMAIL = @EMAIL AND 
                              SENHA = @SENHA";

            Dictionary<string, object> ps = new Dictionary<string, object>();
            ps.Add("@EMAIL", email);
            ps.Add("@SENHA", senha);

            bool ok = ((Int64)_bd.ExecutarScalar(select,ps)) == 1;

            return ok;
        }

        public Models.Usuario ObterUsuario(int id)
        {
            Models.Usuario usuario = null;
            try
            {
                string sql = "SELECT * FROM USUARIO WHERE ID = " + id;

                DataTable dt = _bd.ExecutarSelect(sql);
                if (dt.Rows.Count > 0)
                    usuario = RowToObject(dt.Rows[0]);

            }
            catch(Exception ex)
            {
                throw new Exception("Erro em ObterUsuario!", ex);
            }

            return usuario;
        }

        public Models.Usuario ObterUsuario(string email)
        {
            Models.Usuario usuario = null;
            try
            {
                string sql = "SELECT * FROM USUARIO WHERE EMAIL = @EMAIL";
                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@EMAIL", email);

                DataTable dt = _bd.ExecutarSelect(sql, ps);
                if (dt.Rows.Count > 0)
                    usuario = RowToObject(dt.Rows[0]);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro em ObterUsuario!", ex);
            }

            return usuario;
        }

        public IEnumerable<Models.Usuario> PesqusiarUsuarioPorNome(string nome)
        {
            List<Models.Usuario> usuarios = new List<Models.Usuario>();
            
            string sql = "SELECT * FROM USUARIO WHERE NOME LIKE  @NOME";

            Dictionary<string, object> ps = new Dictionary<string, object>();
            ps.Add("@NOME", nome + "%");

            DataTable dt = _bd.ExecutarSelect(sql, ps);

            foreach (DataRow row in dt.Rows)
                usuarios.Add(RowToObject(row));
               
            return usuarios;
        }

        public IEnumerable<Models.Usuario> ObterTodos()
        {
            List<Models.Usuario> usuarios = new List<Models.Usuario>();

            string sql = "SELECT * FROM USUARIO";

            DataTable dt = _bd.ExecutarSelect(sql);

            foreach (DataRow row in dt.Rows)
                usuarios.Add(RowToObject(row));

            return usuarios;
        }


        public bool Gravar(Models.Usuario usuario)
        {
            string sql = "";
            if(usuario.Id == 0)
            {
                sql = @"
                    INSERT INTO USUARIO
                    (
                        NOME,
                        EMAIL,
                        SENHA
                    )
                    VALUES
                    (
                        @NOME,
                        @EMAIL,
                        @SENHA
                    )
                        ";
            }
            else
            {
                sql = @"
                    UPDATE USUARIO
                    SET NOME  = @NOME,
                        EMAIL = @EMAIL,
                        SENHA = @SENHA,
                    WHERE  ID = @ID";
            }

            Dictionary<string, object> ps = new Dictionary<string, object>();
            if(usuario.Id > 0)
                ps.Add("@ID", usuario.Id);

            ps.Add("@NOME", usuario.Nome);
            ps.Add("@EMAIL", usuario.Email);
            ps.Add("@SENHA", usuario.Senha);

            int linhasAfetadas = _bd.ExecutarComando(sql, ps);
            bool ok = false;

            if (linhasAfetadas > 0)
            {
                ok = true;

                if(_bd.LastInsertedId > 0)
                    usuario.Id = _bd.LastInsertedId;
            }

            return ok;
        }
        
        public bool CadastrarFoto(int usuarioId, string nomeFoto)
        {
            string sql = @"UPDATE USUARIO
                           SET FOTO = @FOTO
                           WHERE  ID = @ID";
          

            Dictionary<string, object> ps = new Dictionary<string, object>();
            ps.Add("@FOTO", nomeFoto);
            ps.Add("@ID", usuarioId);
            int linhasAfetadas = _bd.ExecutarComando(sql, ps);

            return linhasAfetadas > 0;

        }

        private Models.Usuario RowToObject(DataRow row)
        {
            Models.Usuario usuario = new Models.Usuario();

            usuario.Id = (int)row["id"];
            usuario.Nome = row["senha"].ToString();
            usuario.Email = row["email"].ToString();
            usuario.Senha = row["senha"].ToString();
            usuario.Foto = row["foto"].ToString();

            return usuario;
        }
    }
}
