using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class FiestaDeGala : Fiesta
    {
        public string Regalo { get; set; }
        public int Edad { get; set; }

        public FiestaDeGala(int noPersona, decimal costoDeco, decimal costoComida, string regalo, int edad) : base( noPersona ,  costoDeco ,  costoComida)
        {
            Regalo = regalo;
            Edad = edad;
        }
        public override void CostoTotal()
        {
            Console.WriteLine("El costo de la decoración de una fiesta de gala para {0} personas es de: ${1} y de comida {2}"
                , NoPersona, CostoDeco, CostoComida);
        }
        public void Gala()
        {
            Console.WriteLine("Debes traer un regalo en {0} y tener {1} años para asistir \n",Regalo,Edad);
        }


    }
}
