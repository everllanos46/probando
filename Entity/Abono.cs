﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Abono
    {
        public double TotalAbono { get; set; }
        public DateTime FechaAbono { get; set; }
        public Persona persona { get; set; }
    }
}
