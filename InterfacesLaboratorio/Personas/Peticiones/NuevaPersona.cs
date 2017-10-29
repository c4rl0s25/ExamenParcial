using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLaboratorio.Personas.Peticiones
{
    public class NuevaPersona
    {
        public string NombrePersonaMostrada { get; set; }

        public string NombrePersonaTomaMuestra { get; set; }

        public DateTime FechaToma { get; set; }

        public NuevaPersona()
        {
            this.NombrePersonaMostrada = "";
            this.NombrePersonaTomaMuestra = "";
            this.FechaToma = Convert.ToDateTime(DateTime.Now.ToString("G"));
        }
    }
}
