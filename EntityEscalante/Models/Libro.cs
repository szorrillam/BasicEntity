using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityEscalante.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ISBN { get; set; }
        public int EscritorId { get; set; }
        public Escritor Escritor { get; set; } //Navigation Property
    }
}
