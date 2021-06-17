using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Services
{
    class ArmaService
    {
        static ArmaMockRepository emr = new ArmaMockRepository();
        static ArmaMockRepository emr1 = new ArmaMockRepository();
        static ArmaMockRepository emr2 = new ArmaMockRepository();
        static ArmaMockRepository emr3 = new ArmaMockRepository();
        static ArmaMockRepository emr4 = new ArmaMockRepository();
        public static List<Arma> GetArma()
        {
            return emr.FetchArmiGuerriero();
          
        }
        public static List<Arma> GetArmaMago()
        {
            return emr1.FetchArmiMago();
            
        }
        public static List<Arma> GetArmaCultista()
        {
            return emr2.FetchArmiMostroCultista();

        }
        public static List<Arma> GetArmaSignoreDelMale()
        {
            return emr3.FetchArmiMostroSignoreMale();

        }
        public static List<Arma> GetArmaOrco()
        {
            return emr4.FetchArmiMostroOrco();

        }

      
      
    
}
}
