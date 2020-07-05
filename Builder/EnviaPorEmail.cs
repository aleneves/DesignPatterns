using Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_E_Observer
{
    public class EnviaPorEmail : AcoesParaGerarNF
    {
        public void Executa(NotaFiscal notafiscal)
        {
            Console.WriteLine("E-mail enviado com sucesso!");
        }
    }
}
