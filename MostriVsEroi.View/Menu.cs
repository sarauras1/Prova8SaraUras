using MostriVsEroi.Modelli;
using System;

namespace MostriVsEroi.View
{
    public class Menu
    {


        public static void MainMenu()
        {
            bool vuoiContinuare = true;

            do
            {
                Console.WriteLine("Bentornato!");
                Console.WriteLine();
                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("Premi 1 per accedere");
                Console.WriteLine("Premi 2 per registrarti");
                Console.WriteLine("Premi 0 per uscire");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        AccediView.Accedi();
                        break;
                    case "2":
                        RichiestaDati.InserisciUsernamePassword();
                        //Devo far registrare l'utente
                        break;
                    case "0":
                        Console.WriteLine("Ciao alla prossima");
                        vuoiContinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata...Riprova");
                        break;
                }
            } while (vuoiContinuare == true);
        }

        internal static void MenuAdmin(Utente utente)
        {

            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("Premi 1 per giocare");
            Console.WriteLine("Premi 2 per creare nuovo eroe");
            Console.WriteLine("Premi 3 per eliminare eroe");
            Console.WriteLine("Premi 4 per creare nuovo mostro");
            Console.WriteLine("Premi 5 per Mostrare Classifica Globale");
            Console.WriteLine("Premi 0 Uscire");

            bool vuoiContinuare = true;
            do
            {
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        //Giocare
                        GiocaView.Gioca();
                        break;
                    case "2":
                        //aggiunge nel db

                        EroeView.CreateEroe();
                        break;
                    case "3":
                        EroeView.EliminaEroe();
                        //Elimina eroe dal data base utente
                        break;
                    case "4":

                        MostroView.CreaNuovoMostro();
                        //Crea Ramdom Mostro
                        break;
                    case "5":
                        ClassificaGlobaleView.MostraClassificaGlobale();
                        //Elimina eroe dal data base utente
                        break;
                    case "0":

                        Console.WriteLine("Ciao alla prossima");
                        vuoiContinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata...Riprova");
                        break;
                }
            } while (vuoiContinuare == true);
        }



        public static void MenuNonAdmin(Utente utente)
        {
            bool vuoiContinuare = true;

            do
            {
                Console.WriteLine($"Bentornato {utente.Username}");
                Console.WriteLine();
                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("Premi 1 per giocare");
                Console.WriteLine("Premi 2 per creare nuovo eroe");
                Console.WriteLine("Premi 3 per eliminare eroe");
                Console.WriteLine("Premi 0 per tornare al menu principale");

               string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        //Giocare
                        GiocaView.Gioca();
                        break;
                    case "2":
                        //aggiunge nel db

                        EroeView.CreateEroe();
                        break;
                    case "3":
                        EroeView.EliminaEroe();
                        //Elimina eroe dal data base utente
                        break;
                    case "0":

                        Console.WriteLine("Ciao alla prossima");
                        vuoiContinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata...Riprova");
                        break;
                }
            } while (vuoiContinuare == true);
        }
    }
}
