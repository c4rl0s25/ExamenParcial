using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesLaboratorio.Personas;
using InterfacesLaboratorio.Personas.Peticiones;
using InterfacesLaboratorio.Personas.Respuestas;
namespace InterfacesLaboratorio
{
    public interface IGestorDePersonas
    {
        PersonaRegistrada CrearPersona(NuevaPersona nuevaPersona);

        List<PersonaRegistrada> ListarTodasLasPersonas();

     //   PersonaRegistrada ActualizarPersona(PersonaActualizado PersonaActualizado);

       // bool BorrarPersona(int idDelPersona);
    }
}
