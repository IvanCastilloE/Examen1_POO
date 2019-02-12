using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class FiestaInfantil:Fiesta
    {
        public string Cumpleanero { get; set; }
        public int AnosCumplidos { get; set; }

        public FiestaInfantil(int noPersona, decimal costoDeco, decimal costoComida, string cumpleanero, int anosCumplidos): base( noPersona,  costoDeco,  costoComida)
        {
            Cumpleanero = cumpleanero;
            AnosCumplidos = anosCumplidos;
        }
        public void Invitacion()
        {
            Console.WriteLine("Ven a festejar los {0} años de {1} en su fiesta \n", AnosCumplidos, Cumpleanero);
        }
        public override void CostoTotal()
        {
            Console.WriteLine("El costo de la decoración de una fiesta infantil para {0} personas es de: ${1} y de comida {2}"
                , NoPersona, CostoDeco, CostoComida);
        }

    }
}
