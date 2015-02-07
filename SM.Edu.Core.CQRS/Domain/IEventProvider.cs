using System.Collections.Generic;
using SM.Edu.Core.Dominio.Events;

namespace SM.Edu.Core.Dominio.Domain
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<Event> history);
        IEnumerable<Event> GetUncommittedChanges();
    }
}
