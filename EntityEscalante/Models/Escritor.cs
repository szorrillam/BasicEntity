using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityEscalante.Models
{
    public class Escritor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public List<Libro> Libros { get; set; }//Navigation property
    }
}
