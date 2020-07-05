﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.ChainOfResponsability
{
    public class DescontoPorValor : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
