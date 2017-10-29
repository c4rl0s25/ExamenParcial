using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Inventario.Modelos;
namespace Inventario.Contextos
{
    public class Laboratorio: DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public Laboratorio() : base("BaseDeDatosLaboratorio") { }
    }
}
