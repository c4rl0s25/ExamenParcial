using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesLaboratorio.Personas;
using InterfacesLaboratorio.Personas.Peticiones;
using InterfacesLaboratorio.Personas.Respuestas;
using InterfacesLaboratorio;
using Inventario.Compartido;
using Inventario.Contextos;
using Inventario.Modelos;
namespace GestionDePersonas
{
    public class GestorDePersonas : IGestorDePersonas
    {

        public List<PersonaRegistrada> ListarTodasLasPersonas()
        {
            using (Laboratorio laboratorio = new Laboratorio())
            {
                return laboratorio.Personas.ToList().Select(x => ConvertirPersonaA_DTO(x)).ToList();
            }
        }
        public PersonaRegistrada CrearPersona(NuevaPersona nuevaPersona)
        {
            using (Laboratorio laboratorio = new Laboratorio())
            {
                Persona persona = new Persona();
                persona.NombrePersonaMuestra = nuevaPersona.NombrePersonaMostrada;
                persona.NombrePersonaTomaMuestra = nuevaPersona.NombrePersonaTomaMuestra;
                persona.FechaToma = nuevaPersona.FechaToma;
                laboratorio.Personas.Add(persona);
                laboratorio.SaveChanges();
                return ConvertirPersonaA_DTO(persona);
            }
        }

        public PersonaRegistrada ConvertirPersonaA_DTO(Persona persona)
        {
            PersonaRegistrada personaRegistrada = new PersonaRegistrada();
            personaRegistrada.Id = persona.Id;
            personaRegistrada.NombrePersonaMuestra = persona.NombrePersonaMuestra;
            personaRegistrada.NombrePersonaTomaMuestra = persona.NombrePersonaTomaMuestra;
            personaRegistrada.FechaToma = persona.FechaToma;
            return personaRegistrada;
        }
    }
}
