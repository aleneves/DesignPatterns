using Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_E_Observer
{
    public class EnviaPorSMS : AcoesParaGerarNF
    {
        public void Executa(NotaFiscal notafiscal)
        {
            Console.WriteLine("SMS enviado com sucesso!");
        }
    }
}
