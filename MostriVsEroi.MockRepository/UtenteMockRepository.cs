using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;

namespace MostriVsEroi.MockRepository
{
    public class UtenteMockRepository: IUtenteRepository
    {
      

        public List<Utente> FetchUtenti()
        {
            List<Utente> utenti = new List<Utente>();
            utenti.Add(new Utente("SaraU", 1234));
            utenti.Add(new Utente("MariaT", 1235));

            return utenti;
        }

        public Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            
            return utente;
        }

      

       

        
    }
}
