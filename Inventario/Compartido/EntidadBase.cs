using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Compartido
{
   public class EntidadBase
    {
        public int Id { get; set; }
        public DateTime FechaToma { get; set; }
     
        public EntidadBase()
        {
            this.FechaToma = DateTime.Now;
           
        }
    }
}
