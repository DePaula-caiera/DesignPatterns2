﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap3
{
    class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}
