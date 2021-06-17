using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Modelli
{
    public interface IUtenteRepository
    {
        public Utente GetUser(Utente utente);
      public List<Utente> FetchUtenti();
        public bool CheckUsername(Utente utente);
        public Utente UpdateUtenti(Utente utente);

    }
}
