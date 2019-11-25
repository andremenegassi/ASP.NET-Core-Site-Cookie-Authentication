using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.DAL
{
    public class Test
    {
        public void teste()
        {
            MySQLPersistence bd = new MySQLPersistence(false);

            string select = @"select * 
                              from usuario 
                              where nome like @nome || email like @email";

            Dictionary<string, object> ps = new Dictionary<string, object>();
            ps.Add("@nome", "andre");
            ps.Add("@email", "andre@unoeste");

            bd.ExecutarSelect(select, ps);

            DataTable dt = bd.ExecutarSelect(select, ps);

            string nome;
            string email;

            foreach (DataRow row in dt.Rows)
            {
                nome = row["nome"].ToString();
                email = row["email"].ToString();
                //DateTime dtNasc = Conver.ToDateTime(row["dtNasc"]);
            }

            nome = dt.Rows[0]["nome"].ToString();
            email = dt.Rows[0]["email"].ToString();





        }
    }
}
