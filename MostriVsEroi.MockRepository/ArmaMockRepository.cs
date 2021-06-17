using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.MockRepository
{
    public class ArmaMockRepository
    {
        public List<Arma> FetchArmiGuerriero()
        {
            List<Arma> armi = new List<Arma>();
            armi.Add(new Arma("Alabarda", 15));
            armi.Add(new Arma("Ascia", 8));
            armi.Add(new Arma("Mazza", 5));
            armi.Add(new Arma("Spada", 10));
            armi.Add(new Arma("Spadone", 5));

            return armi;

        }


        public List<Arma> FetchArmiMago()
        {
            List<Arma> armi = new List<Arma>();
            armi.Add(new Arma("Arco e Freccie", 8));
            armi.Add(new Arma("Bachetta", 5));
            armi.Add(new Arma("Bastone Magico", 10));
            armi.Add(new Arma("Onda D urto", 15));
            armi.Add(new Arma("Pugnale", 5));

            return armi;
        }

        public List<Arma> FetchArmiMostroCultista()
        {
            List<Arma> armi = new List<Arma>();
            armi.Add(new Arma("Alabarda", 15));
            armi.Add(new Arma("Ascia", 8));
            armi.Add(new Arma("Mazza", 5));
            armi.Add(new Arma("Spada", 10));
            armi.Add(new Arma("Spadone", 5));

            return armi;
        }
        public List<Arma> FetchArmiMostroOrco()
        {
            List<Arma> armi = new List<Arma>();
            armi.Add(new Arma("Arco", 7));
            armi.Add(new Arma("Clava", 5));
            armi.Add(new Arma("Spada rotta", 3));
            armi.Add(new Arma("MazzaChiodata", 10));


            return armi;
        }
        public List<Arma> FetchArmiMostroSignoreMale()
        {
            List<Arma> armi = new List<Arma>();
            armi.Add(new Arma("Alabarda del drago", 30));
            armi.Add(new Arma("Divinazione", 15));
            armi.Add(new Arma("Fulmine", 10));
            armi.Add(new Arma("Fulmine celeste", 15));
            return armi;
        }
    }
}
