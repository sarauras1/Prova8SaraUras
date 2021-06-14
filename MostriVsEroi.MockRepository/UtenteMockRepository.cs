using MostriVsEroi.Modelli;
using System;

namespace MostriVsEroi.MockRepository
{
    public class UtenteMockRepository
    {
        public static Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            return utente;
        }
    }
}
