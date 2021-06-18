﻿using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.SchermataServices
{
   public static class EroeSchermataServices
    {
        public static Eroe GetEroe(string categoria, Arma arma, string nome)
        {
            return new Eroe(categoria, arma, nome);
        }
    }
}
