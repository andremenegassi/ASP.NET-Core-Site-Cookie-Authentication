using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.BL
{
    public class UsuarioBL
    {
        public DAL.UsuarioDAL _uDal = new DAL.UsuarioDAL();

        public Models.Usuario ObterUsuario(int id)
        {
            return _uDal.ObterUsuario(id);
        }

        public (bool, string) Gravar(Models.Usuario usuario)
        {
            bool ok = false;
            string msg = "";

            //Regra negócio.

            Models.Usuario uExiste = _uDal.ObterUsuario(usuario.Email);

            if(uExiste != null)
            {
                if(usuario.Id != uExiste.Id)
                {
                    msg = "E-mal já utilizado. Tente outro.";
                }
            }

            if(msg == "")
            {
                try
                {
                    ok = _uDal.Gravar(usuario);

                    if (!ok)
                        msg = "Erro ao gravar usuário.";
                    else
                        msg = "Usuário cadastrado com sucesso.";
                }
                catch
                {
                    msg = "Um erro ocorreu.";
                }
            }

            

            return (ok, msg);
        }

        public bool CadastrarFoto(int usuarioId, string nomeFoto)
        {
            return _uDal.CadastrarFoto(usuarioId, nomeFoto);
        }

        public IEnumerable<Models.Usuario> ObterTodos()
        {
            return _uDal.ObterTodos();
        }

    }
}
