using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Compartido;
namespace Inventario.Modelos
{
    public class Persona :EntidadBase
    {
        public string NombrePersonaMuestra { get; set; }
        public string NombrePersonaTomaMuestra { get; set; }

        public DateTime FechaToma { get; set; }

    }
}
