using MostriVsEroi.Modelli;
using MostriVsEroi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
    class GiocaView
    {
        internal static void Gioca()
        {
            //Scelta eroe
            Eroe eroe = EroeView.ScegliEroe();
            Console.WriteLine($"Hai scelto l eroe {eroe.Nome} con punti {eroe.Arma.PuntiDanno}");
            if (eroe.Categoria != null)
            {
              Mostro mostro = MostroView.CreaNuovoMostro();
                if(mostro.Arma.PuntiDanno > eroe.Arma.PuntiDanno)
                {
                    Console.WriteLine("Hai Perso");
                }
                if (mostro.Arma.PuntiDanno < eroe.Arma.PuntiDanno)
                {
                    Console.WriteLine("Hai Vinto");
                }
            }
           

            //Scelta mostro
            //Partita

        }
    }
}
