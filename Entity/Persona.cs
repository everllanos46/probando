using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public string Genero { get; set; }
        public string Ocupacion { get; set; }
        public string NumeroCelular { get; set; }
        public string Direccion { get; set; }
        public Tarjeta Tarjeta { get; set; }
        public Abono abono { get; set; }
    }
}
