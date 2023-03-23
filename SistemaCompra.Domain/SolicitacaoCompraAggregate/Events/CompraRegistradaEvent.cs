using SistemaCompra.Domain.Core;
using SistemaCompra.Domain.Core.Model;
using System;
using System.Collections.Generic;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate.Events
{
    public class CompraRegistradaEvent : Event
    {
        public Guid Id { get; }
        public IEnumerable<Item> Itens { get; }
        public Money TotalGeral { get; }

        public CompraRegistradaEvent(Guid id, IEnumerable<Item> itens, Money TotalGeral)
        {
            Id = id;
            Itens = itens;
            this.TotalGeral = TotalGeral;
        }
    }
}
