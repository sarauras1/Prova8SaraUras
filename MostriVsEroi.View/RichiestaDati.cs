using MostriVsEroi.Modelli;
using MostriVsEroi.SchermataServices;
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
            //Controllare che l'utente sia valido

            //Servizio che mappi il mio utente
            //Mappare username e password a utente
            return UtenteSchermataServices.GetUtente(username, password);
        }
    }
}
