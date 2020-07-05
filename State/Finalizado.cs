using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void RegistraMudancaEstado(Orcamento orcamento)
        {
            throw new NotImplementedException("Orçamentos finalizados não podem ser alterados!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }
    }
}
