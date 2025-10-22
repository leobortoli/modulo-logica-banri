using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_1
{
    class App
    {
        static void Main(string[] args)
        {
            const int MAX_SHOWS = 1000;
            int ingressos_vendidos = 75;
            int ingressos_restantes = MAX_SHOWS - ingressos_vendidos;

            System.Console.WriteLine($"Ingressos Vendidos: {ingressos_vendidos} de {MAX_SHOWS}");
            System.Console.WriteLine($"Ingressos Restantes: {ingressos_restantes}");
        }
    }
}
