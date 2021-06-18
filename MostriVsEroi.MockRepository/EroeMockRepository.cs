using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.MockRepository
{
    public class EroeMockRepository 
    {
       

        public List<Eroe> FetchEroe()
        {
            List<Eroe> categorie = new List<Eroe>();
            categorie.Add(new Eroe("guerriro", new Arma("Alabarda", 15),"Boora"));
            categorie.Add(new Eroe("guerriro", new Arma("Ascia", 8),"Muratoa"));
            categorie.Add(new Eroe("guerriero", new Arma("Mazza", 5), "Erutor"));
            categorie.Add(new Eroe("guerriro", new Arma("Spada", 10),"Captur"));
            categorie.Add(new Eroe("guerriero", new Arma("Spadone", 5), "Spadator"));
            categorie.Add(new Eroe("Mago", new Arma("Arco e Freccie", 8),"Merlino"));
            categorie.Add(new Eroe("Mago", new Arma("Bachetta", 5),"Magomao"));
            categorie.Add(new Eroe("Mago", new Arma("Bastone Magico", 10), "Bason"));
            categorie.Add(new Eroe("Mago", new Arma("Onda D urto", 15), "Ondor"));
            categorie.Add(new Eroe("mago", new Arma("Pugnale", 5), "Traditor"));
          
            return categorie;
        }

       
    }
}
