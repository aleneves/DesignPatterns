using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
            RegistraMudancaEstado(orcamento);
        }

        public void Aprova(Orcamento orcamento)
        {
            // jah estou em aprovacao
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            // nao pode ser reprovado agora!
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            // daqui posso ir para o estado de finalizado
            orcamento.EstadoAtual = new Finalizado();
        }

        public void RegistraMudancaEstado(Orcamento orcamento)
        {
            orcamento.EstadoAlterado = true;
            throw new Exception("Falha ao lançar novo desconto! Orçamento já obteve desconto!");
        }
    }
}
