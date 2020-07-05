using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados podem apenas ser finalizados!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void RegistraMudancaEstado(Orcamento orcamento)
        {
            orcamento.EstadoAlterado = true;
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados podem apenas ser finalizados!");
        }
    }
}
