using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
            RegistraMudancaEstado(orcamento);
        }

        public void Aprova(Orcamento orcamento)
        {
            // desse estado posso ir para o estado de aprovado
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            // desse estado posso ir para o estado de reprovado tambem
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            // daqui não posso ir direto para finalizado
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }

        public void RegistraMudancaEstado(Orcamento orcamento)
        {
            orcamento.EstadoAlterado = true;
            throw new Exception("Falha ao lançar novo desconto! Orçamento já obteve desconto!");
        }
    }
}
