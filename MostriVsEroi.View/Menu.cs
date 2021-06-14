using System;

namespace MostriVsEroi.View
{
    public static class Menu
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
                        //Devo fare accedere l'utente
                        AccediView.Accedi();
                        break;
                    case "2":
                        //Devo far registrare l'utente
                        break;
                    case "0":
                        Console.WriteLine("Ciao alla prossima");
                        vuoiContinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata.... Rirova");
                        break;
                }
            } while (vuoiContinuare);
        }
    }
}
