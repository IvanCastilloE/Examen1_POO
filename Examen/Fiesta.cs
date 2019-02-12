using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Fiesta
    {
        public int NoPersona { get; set; }
        public decimal CostoDeco { get; set; }
        public decimal CostoComida { get; set; }

        public Fiesta (int noPersona, decimal costoDeco, decimal costoComida)
        {
            NoPersona = noPersona;
            CostoComida = costoComida;
            CostoDeco = CostoDeco;
        }
        public virtual void CostoTotal()
        {
            Console.WriteLine("El costo de la decoración de una fiesta para {0} personas es de: ${1} y de comida {2} \n"
                , NoPersona, CostoDeco, CostoComida);
        }
    }
}
//ivanfernandezv@outlook.com