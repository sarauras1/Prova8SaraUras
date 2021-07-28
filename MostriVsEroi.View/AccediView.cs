using MostriVsEroi.Modelli;
using MostriVsEroi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
    static class AccediView
    {
        public static void Accedi()
        {
            Utente utente = RichiestaDati.InserisciUsernamePassword();
            utente = UtenteServices.VerifyAuthentication(utente);
            if (utente.IsAuthenticated)
            {   // giocatore non admin
                Menu.MenuAdmin(utente);
           

            }
            else 
            {
                //menu giocatore normale
                Menu.MenuNonAdmin(utente);

            }
           
        }
    }
}
