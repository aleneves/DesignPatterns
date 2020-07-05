using CursoDesignPatterns.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto PrimeiraFase = new DescontoPorItens();
            IDesconto SegundaFase = new DescontoPorValor();
            IDesconto TerceiraFase = new SemDesconto();

            PrimeiraFase.Proximo = SegundaFase;
            SegundaFase.Proximo = TerceiraFase;

            return PrimeiraFase.Desconta(orcamento);
        }        
    }
}
