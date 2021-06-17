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
                        Console.WriteLine($"Premi {count} per scegliere l'eroe {eroe.Nome}, di tipo {eroe.Categoria}= +" +
                         $" con arma {eroe.Arma} che ha {eroe.Arma.PuntiDanno} punti danno, di livello {eroe.Livello} e vita {eroe.PuntiVita}");
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
            List<Eroe> eroi = Services.EroeServices.GetEroi();
            foreach (var item in eroi)
            {
                Console.WriteLine(item);
            }

            do
            {
                Console.WriteLine($"Ciao inserici Categoria Eroe = Mago o Guerriero");

                string categoria = Console.ReadLine();
                Console.WriteLine("Inserici Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserici Nome Arma");
                string nomearma = Console.ReadLine();
                Console.WriteLine("Inserici Punti Arma");
                int puntidanno = Convert.ToInt32(Console.ReadLine());

                if (categoria != null && nome != null && puntidanno > 0)
                {
                    EroeDBRepository.AddEroe(categoria, nome, nomearma, puntidanno);
                    Console.WriteLine("Personaggio inserito");

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
                Console.WriteLine(item);
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

