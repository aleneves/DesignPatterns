﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6 + CalculoDoOutroImposto(orcamento);
        }
    }
}
