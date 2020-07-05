using Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_E_Observer
{
    public class GravaNoBDcs : AcoesParaGerarNF
    {
        public void Executa(NotaFiscal notafiscal)
        {
            Console.WriteLine("Nota Fiscal foi gravada com sucesso!");
        }
    }
}
