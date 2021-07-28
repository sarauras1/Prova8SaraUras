using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Modelli
{
    public class Mostro
    {
        public string Categoria { get; set; }
        public Arma Arma { get; set; }
        public Mostro(string categoria, Arma arma)

        {
            Categoria = categoria;
            Arma = arma;
        }

     
    }
}
