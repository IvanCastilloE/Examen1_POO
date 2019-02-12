using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fiesta fiesta = new Fiesta( 8, 1000, 2500);
            fiesta.CostoTotal();

            FiestaInfantil fiestaInfantil = new FiestaInfantil(20, 800, 1500, "Pepito", 8);
            fiestaInfantil.CostoTotal();
            fiestaInfantil.Invitacion();

            FiestaDeGala fiestaDeGala = new FiestaDeGala(15, 3000, 5000, "Efectivo", 25);
            fiestaDeGala.CostoTotal();
            fiestaDeGala.Gala();
            Console.ReadKey();
        }
    }
}
