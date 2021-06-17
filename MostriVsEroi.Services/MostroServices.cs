using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Services
{
   public static class MostroServices
    {
        static MostroMockRepository emr = new MostroMockRepository();
        public static List<Mostro> GetMostro()
        {
            return emr.FetchMostro();

        }
    }
}
