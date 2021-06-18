using MostriVsEroi.Modelli;

namespace MostriVsEroi.View
{
    internal class Partita
    {

        public Utente Utente { get; set; }
        public int PuntiAccumulati { get; set; }
        public int Livello { get; set; }
        public int PuntiVita { get; set; }
        public Mostro Mostro { get; set; }
        public Eroe Eroe { get; set; }
        public Partita(int puntiacc, Utente utente, int puntiVita, Eroe eroe, Mostro mostro, int livello)
        {
          
            PuntiAccumulati = puntiacc;
            Utente = utente;
            Livello = livello;
            PuntiVita = puntiVita;
            Eroe = eroe;
            Mostro = mostro;
        }
        public Partita()
        {

        }
       
        
        
    }
}