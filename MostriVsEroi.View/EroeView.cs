using MostriVsEroi.Modelli;
using MostriVSEroi.DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
  public  class EroeView
    {
     

        internal static Eroe ScegliEroe()
        {

            Console.WriteLine("Scegli eroe");
            List<Eroe> eroi = Services.EroeServices.GetEroi();

            if (eroi.Count > 0)
            {

                int count = 1;
                bool conversione = false;
                int eroeScelto;
                do
                {

                    foreach (Eroe eroe in eroi)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Premi {count++} per scegliere l'eroe {eroe.Nome}, di tipo {eroe.Categoria}= +" +
                         $" con arma {eroe.Arma} che ha {eroe.Arma.PuntiDanno}");
                        Console.WriteLine("");
                    }





                 conversione = int.TryParse(Console.ReadLine(), out eroeScelto);
                } while (!conversione || eroeScelto < 1 || eroeScelto > eroi.Count);
               
                
                return eroi[--eroeScelto];
               
            }
          
            else
            {
                Console.WriteLine("Nessun eroe in lista");
                return null; //return new Eroe
            }

        }




        internal static void CreateEroe()
           
        {
            Utente utente = new Utente();
            List<Eroe> eroi = Services.EroeServices.GetEroi();
            foreach (var item in eroi)
            {
                Console.WriteLine();
                Console.WriteLine($"Categoria -> {item.Categoria}");
                Console.WriteLine($"Nome -> {item.Nome}");              
                Console.WriteLine();
            }

            do
            {
                
                Console.WriteLine($"Ciao inserici Categoria Eroe = Mago o Guerriero");
                string categoria = Console.ReadLine();
                Console.WriteLine("Inserici Nome");
                string nome = Console.ReadLine();
              
                foreach (var item in eroi)
                {
                    Console.WriteLine();                  
                    Console.WriteLine($"Nome Arma {item.Arma.Nome}");
                    Console.WriteLine($"Punti danno Arma {item.Arma.PuntiDanno}");
                    Console.WriteLine();
                }

                Console.WriteLine("Inserici Nome Arma");
                string nomearma = Console.ReadLine();
                Console.WriteLine("Inserici Punti Arma");
                int puntidanno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci Username");
                string username = Console.ReadLine();
                if (categoria != null && nome != null && puntidanno > 0)
                {
                    EroeDBRepository.AddEroe(categoria, nome, nomearma, puntidanno, username);
                    Console.WriteLine("Personaggio inserito");
                    Menu.MenuNonAdmin(utente);

                }
                else
                {
                    Console.WriteLine("Non Hai inserito il personaggio");
                }
            } while (true);

        }

        public static void EliminaEroe()
        {
           
            List<Eroe> eroi = Services.EroeServices.GetEroi();
            foreach (var item in eroi)
            {
                Console.WriteLine();
                Console.WriteLine($"Categoria -> {item.Categoria}");
                Console.WriteLine($"Nome -> {item.Nome}");
                Console.WriteLine($"Nome Arma {item.Arma.Nome}");
                Console.WriteLine($"Punti danno Arma {item.Arma.PuntiDanno}");
                Console.WriteLine();
            }


            do
            {
                //visualizza eroi
                Console.WriteLine("Elimina Eroe");
                Console.WriteLine("Inserisci Nome Eroe");
                string nome = Console.ReadLine();

                if (nome != null)
                {
                    Console.WriteLine("eroe Eliminato");
                    EroeDBRepository.EliminaEroe(nome);
                }
                else
                {
                    Console.WriteLine("reinserisci nome valido");
                }
            } while (true);

        }
    }
}

