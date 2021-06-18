using MostriVsEroi.Modelli;
using MostriVsEroi.Services;
using MostriVSEroi.DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
    class GiocaView
    {
        internal static void Gioca()//avanza solo al livello 2 non memorizza problema da risolvere
            //non salva nel database 
        {
            Partita partita = new Partita();
            Console.WriteLine("Gioca Partita");
            //Scelta eroe
            Eroe eroe = EroeView.ScegliEroe();
            Console.WriteLine("");
            Console.WriteLine($"Hai scelto l eroe {eroe.Nome} con punti {eroe.Arma.PuntiDanno}");
            if (eroe.Categoria != null)
            {
                Mostro mostro = MostroView.CreaNuovoMostro();
                if (eroe.Arma.PuntiDanno < mostro.Arma.PuntiDanno )
                {
                   
                    Console.WriteLine("Hai Perso");
                    partita.PuntiVita = 20;
                    int calcolo = eroe.Arma.PuntiDanno - mostro.Arma.PuntiDanno;
                    partita.PuntiAccumulati = calcolo;
                    
                    Console.WriteLine($"Il Mostro ti ha tolto {partita.PuntiAccumulati} punti" +
                        $" mi dispice devi rimanere allo stesso livello hai ancora " +
                        $"{partita.PuntiVita - partita.PuntiAccumulati}");
                    Console.WriteLine("----------------------");
                    InserisciRecords();


                    Giocaredinuovo();
                }
                if (eroe.Arma.PuntiDanno > mostro.Arma.PuntiDanno)
                {
                    Console.WriteLine("Hai Vinto");
                    partita.PuntiVita = 20;
                    int calcolo = eroe.Arma.PuntiDanno + mostro.Arma.PuntiDanno;                   
                    partita.PuntiAccumulati = calcolo + partita.PuntiVita;
                    Console.WriteLine($"Hai accumulato punti {partita.PuntiAccumulati}");
                    InserisciRecords();

                    if (partita.PuntiAccumulati >= 30)
                    {
                        partita.PuntiVita = 40;
                        calcolo = eroe.Arma.PuntiDanno + mostro.Arma.PuntiDanno;
                        partita.PuntiAccumulati = calcolo + partita.PuntiVita;

                        Console.WriteLine($"Complimenti questo hai accumulato punti {partita.PuntiAccumulati}");
                        partita.Livello = 2;
                        Console.WriteLine($"Sei Passato al livello {partita.Livello}");
                        int aggiorna = partita.PuntiAccumulati;
                        InserisciRecords();
                        Giocaredinuovo();
                        if (aggiorna >= 60)
                        {
                            partita.PuntiVita = 60;
                            calcolo = eroe.Arma.PuntiDanno + mostro.Arma.PuntiDanno;
                            partita.PuntiAccumulati = calcolo + partita.PuntiVita;

                            partita.Livello = 3;
                            Console.WriteLine($"Sei Passato al livello {partita.Livello}");
                            Console.WriteLine($"punti accumulati {partita.PuntiAccumulati}");
                            Giocaredinuovo();
                            InserisciRecords();
                        }
                        if (partita.PuntiAccumulati >= 80)
                        {
                            partita.PuntiVita = 80;
                            calcolo = eroe.Arma.PuntiDanno + mostro.Arma.PuntiDanno;
                            partita.PuntiAccumulati = calcolo + partita.PuntiVita;

                            partita.Livello = 4;
                            Console.WriteLine($"Sei Passato al livello {partita.Livello}");
                            Console.WriteLine($"punti accumulati {partita.PuntiAccumulati}");
                            Giocaredinuovo();
                            InserisciRecords();
                        }
                        if (partita.PuntiAccumulati >= 100)
                        {
                            partita.PuntiVita = 100;
                            calcolo = eroe.Arma.PuntiDanno + mostro.Arma.PuntiDanno;
                            partita.PuntiAccumulati = calcolo + partita.PuntiVita;

                            partita.Livello = 5;
                            Console.WriteLine($"Sei Passato al livello {partita.Livello}");
                            Console.WriteLine($"punti accumulati {partita.PuntiAccumulati}");
                            Giocaredinuovo();
                        }
                        Giocaredinuovo();
                        InserisciRecords();
                    }
                   
                 
                   
                }
                else if (mostro.Arma.PuntiDanno == eroe.Arma.PuntiDanno)
                {
                    Console.WriteLine("Pareggio non cambia nulla");
                    Giocaredinuovo();
                    InserisciRecords();
                }
              
            }
      

    }

        private static void InserisciRecords()
        {
            EroeView.CreateEroe();
            Console.WriteLine("Inserisci Livello raggiunto");
            int livello = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci Punti Vita");
             int puntivita = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci punti accumulati");
            int puntiacc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci username");
            string user = Console.ReadLine();
            PartitaRepository.InserisciRisultatiPartita(livello, puntivita,
                    puntiacc, user);
        }
    private static void Giocaredinuovo() {
        Console.WriteLine("Vuoi Giocare dinuovo?");
        Console.WriteLine("Premi 1 per SI");
        Console.WriteLine("Premi 2 per No");
        do
        {
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    Gioca();
                    break;
                case "2":
                    Console.WriteLine("GoodBye");
                    return;
                default:
                    Console.WriteLine("Scelta sbagliata");
                    break;
            }
        } while (true);
    }

     

    }

}