using MostriVsEroi.Modelli;
using MostriVsEroi.SchermataServices;
using MostriVSEroi.DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
    class RichiestaDati
    {
        
        internal static Utente InserisciUsernamePassword()
        {
          
                Console.WriteLine("Inserisci il tuo username");
                string username = Console.ReadLine();

                Console.WriteLine("Inserisci la password");
                int password = Convert.ToInt32(Console.ReadLine());
                UtenteDBRepository.RegistraUtente(username, password);
                return UtenteSchermataServices.GetUtente(username, password);
          
               

        }
    }
}
