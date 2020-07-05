using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface EstadoDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
        void RegistraMudancaEstado(Orcamento orcamento);
    }
}
