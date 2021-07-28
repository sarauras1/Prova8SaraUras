using MostriVsEroi.MockRepository;
using MostriVsEroi.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Services
{
   public static class PartitaServices
    {
     
            static PartitaMockRepository umr = new PartitaMockRepository();

            public static List<Partita> ListaPartita(List<Partita> partita)
            {
                return umr.GetPartitas(partita);
            }

       
    }
}
