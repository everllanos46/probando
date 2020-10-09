using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Tarjeta
    {
        public double Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public double TasaInteres { get; set; }
        public double TotalPagar { get; set; }
        public string TipoPago { get; set; }
        public double PagoCuota { get; set; }
        public Persona persona { get; set; }


        public abstract void CalcularPagoCuotas();
        public  void CalcularTotalPagar() {
            TasaInteres = 0.2;
            TotalPagar = Monto + (Monto * TasaInteres);
            CalcularPagoCuotas();
        }
        
    }
}
