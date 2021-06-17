using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.SchermataServices
{
   public static class ArmaSchermataServices
    {
        public static Arma GetArma(string nome, int puntiDanno)
        {
            return new Arma(nome, puntiDanno);
        }
        public static Arma GetArmaMago(string nome, int puntiDanno)
        {
            return new Arma(nome, puntiDanno);

        }
        public static Arma GetArmaCultista(string nome, int puntiDanno)
        {
            return new Arma(nome, puntiDanno);

        }
        public static Arma GetArmaSignoreDelMale(string nome, int puntiDanno)
        {
            return new Arma(nome, puntiDanno);

        }

        public static Arma GetArmaOrco(string nome, int puntiDanno)
        {
            return new Arma(nome, puntiDanno);

        }
       
    }
}
