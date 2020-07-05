using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class NotaFiscal
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }
        private DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        private IList<ItemDaNota> Itens { get; set; }
        private String Observacoes { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao,
                    double valorBruto, double impostos, IList<ItemDaNota> itens,
                    String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}
