using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.MockRepository
{
   public class MostroMockRepository
    {
        public List<Mostro> FetchMostro()
        {
            List<Mostro> mostro = new List<Mostro>();
            mostro.Add(new Mostro("Signore Del Male", new Arma("Alabarda del drago", 30)));
            mostro.Add(new Mostro("Signore Del Male", new Arma("Divinazione", 15)));
            mostro.Add(new Mostro("Signore Del Male", new Arma("Fulmine", 10)));
            mostro.Add(new Mostro("Signore Del Male", new Arma("Fulmine celeste", 30)));
            mostro.Add(new Mostro("Orco", new Arma("Arco", 7)));
            mostro.Add(new Mostro("Orco", new Arma("Clava", 5)));
            mostro.Add(new Mostro("Orco", new Arma("Spada rotta", 3)));
            mostro.Add(new Mostro("Orco", new Arma("Mazza Chiodata", 10)));
            mostro.Add(new Mostro("Cultista", new Arma("Alabarda", 15)));
            mostro.Add(new Mostro("Cultista", new Arma("Ascia", 8)));
            mostro.Add(new Mostro("Cultista", new Arma("Mazza", 5)));
            mostro.Add(new Mostro("Cultista", new Arma("Spada", 10)));
            mostro.Add(new Mostro("Cultista", new Arma("Spadone", 5)));

         
              
           
            return mostro;
        }
    }
}
