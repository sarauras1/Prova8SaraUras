using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Services
{
   public class EroeServices
    {
        static EroeMockRepository emr = new EroeMockRepository();

        public static List<Eroe> GetEroi()
        {
            return emr.FetchEroe();
        }

    }
}
