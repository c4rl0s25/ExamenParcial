using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDePersonas;
using InterfacesLaboratorio.Personas;
using InterfacesLaboratorio;
using InterfacesLaboratorio.Personas.Peticiones;
namespace ConsolaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            IGestorDePersonas gestorDePersonas = new GestorDePersonas();
            NuevaPersona nuevaPersona = new NuevaPersona();
            nuevaPersona.NombrePersonaMostrada = "Carlos";
            nuevaPersona.NombrePersonaTomaMuestra = "lucia";
            gestorDePersonas.CrearPersona(nuevaPersona);
        }
    }
}
