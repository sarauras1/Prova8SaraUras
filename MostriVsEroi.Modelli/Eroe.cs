using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Modelli
{
          
    public class Eroe
    {

        public Arma Arma { get; set; }
        public string Nome { get; set; }
   
        public string Categoria { get; set; }

        public Eroe(string categoria, Arma arma, string nome)
        {

            Nome = nome;          
            Arma = arma;
            Categoria = categoria;

        }

      
    }
}
