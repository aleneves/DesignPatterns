using Builder_E_Observer;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder()
                .ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .Com(new ItemDaNota("item 1", 100.0))
                .Com(new ItemDaNota("item 2", 200.0))
                .Com(new ItemDaNota("item 3", 300.0))
                .ComObservacoes("entregar nf pessoalmente")
                .NaDataAtual();


            criador.AdicionarAcao(new GravaNoBDcs());
            criador.AdicionarAcao(new EnviaPorEmail());
            criador.AdicionarAcao(new EnviaPorSMS());
            
            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
