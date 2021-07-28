using MostriVsEroi.Modelli;
using System.Collections.Generic;

namespace MostriVsEroi.View
{
   public class Partita
    {
       

        public Utente Utente { get; set; }
        public int Livello { get; set; }
        public Punti Punti { get; set; }
        public Mostro Mostro { get; set; }
        public Eroe Eroe { get; set; }
        public Partita(Utente utente, int livello, Punti punti, Mostro mostro, Eroe eroe)
        {
            Utente = utente;
            Livello = livello;
            Punti = punti;
            Mostro = mostro;
            Eroe = eroe;
        }
        public Partita()
        {

        }
       
    }
}