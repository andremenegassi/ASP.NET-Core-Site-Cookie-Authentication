using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class FamiliaDonald
    {
        public string Tio { get; set; }
        public int Idade { get; set; }
        public List<FamiliaDonaldSobrinhos> Sobrinhos { get; set; }


        public FamiliaDonald()
        {
            Sobrinhos = new List<FamiliaDonaldSobrinhos>();
        }

    }

    public class FamiliaDonaldSobrinhos
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public FamiliaDonaldSobrinhos()
        {

        }
    }

}
