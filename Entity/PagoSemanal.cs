﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class PagoSemanal : Tarjeta
    {
        public override void CalcularPagoCuotas()
        {
            PagoCuota = TotalPagar / 4;
        }
    }
}
