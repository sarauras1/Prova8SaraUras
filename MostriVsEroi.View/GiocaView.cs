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
       
        internal static void Gioca()

        {
            List<int> p = new List<int>();
            
            int puntivita = 20;
            p.Add(puntivita);

          
            Console.WriteLine("Gioca Partita");
            //Scelta eroe
            Eroe eroe = EroeView.ScegliEroe();
            Console.WriteLine("");
            Console.WriteLine($"Hai scelto l eroe {eroe.Nome} con punti {eroe.Arma.PuntiDanno}");
            if (eroe.Categoria != null)
            {


                Mostro mostro = MostroView.CreaNuovoMostro();
                if (eroe.Arma.PuntiDanno < mostro.Arma.PuntiDanno)
                {
                    int valore;

                    try
                    {
                        do
                        {    
                             valore = mostro.Arma.PuntiDanno - eroe.Arma.PuntiDanno;
                            Console.WriteLine("-----Hai Perso-------");
                            Console.WriteLine("----------------------");
                            Console.WriteLine($"Il Mostro ti ha tolto {valore} punti");
                            Console.WriteLine("----------------------");
                            p.Add(valore);



                            Console.WriteLine($"Ti rimangono {CalcoloPuntimeno(p)} punti");
                            if (valore <= 0)
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("-------Game Over--------");
                                Console.WriteLine("----------------------");
                            }
                        } while (valore <= 0);
                                                

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Giocaredinuovo();

                }

                

                if (eroe.Arma.PuntiDanno > mostro.Arma.PuntiDanno)
                {
                    int v;
                    try
                    {
                        do
                        {

                            Console.WriteLine("-------Hai Vinto---------");
                            v = eroe.Arma.PuntiDanno - mostro.Arma.PuntiDanno;
                            Console.WriteLine($"Hai vinto {v} punti");
                          
                            p.Add(v);
                            Console.WriteLine($"Punti accumulati {p.Sum()}");
                            if (v > 40)
                            {
                                Console.WriteLine($"Complimenti passi al livello 2");
                                puntivita = 40;
                                p.Add(puntivita);
                               
                            }

                        } while (v == 41);

                        
                    }


                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }


                  



            }
            else if (mostro.Arma.PuntiDanno == eroe.Arma.PuntiDanno)
            {
                Console.WriteLine("Pareggio non cambia nulla");

               

            }




        }

           
        }

     
        private static object CalcoloPuntimeno(List<int> p)
        {
            var pun = 0;
            foreach (var item in p)
            {
                pun = p[0] -= p[item];
            }
            return pun;
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