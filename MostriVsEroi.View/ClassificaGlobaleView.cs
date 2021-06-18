using System;
using MostriVSEroi.DBRepository;
namespace MostriVsEroi.View
{
    internal class ClassificaGlobaleView
    {
        internal static void MostraClassificaGlobale()
        {
            Console.WriteLine("Classifica Globale");
            PartitaRepository.ClassificaGlobale();
        }
    }
}