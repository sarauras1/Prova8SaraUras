using System;

namespace MostriVsEroi.Modelli
{
    public class Utente
    {
        public string Username { get; set; }
        public int Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAdmin { get; set; }
      

        public Utente(string username, int password)
        {
            Username = username;
            Password = password;
            IsAuthenticated = false;
            IsAdmin = false;
        }
    }
}
