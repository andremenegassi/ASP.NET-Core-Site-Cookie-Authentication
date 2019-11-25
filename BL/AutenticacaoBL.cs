using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.BL
{
    public class AutenticacaoBL
    {
        DAL.UsuarioDAL _udal = new DAL.UsuarioDAL();

        public (bool, string) ValidarAutenticacao(string email, string senha)
        {
            bool ok = false;
            string msg = "";
            email = email.Trim();
            senha = senha.Trim();

            if (email == "" || senha == "")
                msg = "Forneça todos os dados.";
            else 
            {
                try
                {
                    ok = _udal.ValidarAutenticacao(email, senha);

                    if (!ok)
                    {
                        msg = "Usuário não encontrado.";
                    }
                }
                catch (Exception ex)
                {
                    msg = "Um erro ocorreu. Tente novamente.";
                }
            }
            return (ok, msg);
        }



    }
}
