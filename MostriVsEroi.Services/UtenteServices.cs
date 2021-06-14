
using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;

namespace MostriVsEroi.Services
{
    public static class UtenteServices
    {
        public static Utente VerifyAuthentication(Utente utente)
        {
            return UtenteMockRepository.GetUser(utente);
        }
    }
}
