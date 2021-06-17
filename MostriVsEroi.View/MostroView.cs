using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
   public class MostroView
    {
        internal static Mostro CreaNuovoMostro()
        {          
          List<Mostro> mostro = Services.MostroServices.GetMostro();

            var random = new Random();

            int index = random.Next(mostro.Count);
            Console.WriteLine($"Categoria Mostro = {mostro[index].Categoria}");
            Console.WriteLine($"Nome Arma {mostro[index].Arma.Nome}");
            Console.WriteLine($"Punti Toglie {mostro[index].Arma.PuntiDanno}");
            return mostro[index];
        }
    }
}
