using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500);
            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();

        }
    }
}
