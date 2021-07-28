using MostriVsEroi.Modelli;
using MostriVsEroi.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.SchermataServices
{
   public class PartitaSchermataServices
    {
        public static Partita GetPartita(Utente utente, Mostro mostro, Eroe eroe, Punti punti, int livello)
        {
            return new Partita(utente, livello, punti, mostro, eroe);
        }
    }
}
