using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.SchermataServices
{
   public static class MostroSchermataServices
    {
        public static Mostro GetMostro(string categoria, Arma arma)
        {
            return new Mostro(categoria, arma);
        }
    }
}
