using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Domain;
using SM.Edu.Core.Dominio.Domain.Mementos;
using SM.Edu.Core.Dominio.Events;

namespace SM.Edu.Core.Dominio.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T: BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}
