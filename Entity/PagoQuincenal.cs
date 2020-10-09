using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class PagoQuincenal : Tarjeta
    {
        public override void CalcularPagoCuotas()
        {
            PagoCuota = TotalPagar / 2;
        }
    }
}
