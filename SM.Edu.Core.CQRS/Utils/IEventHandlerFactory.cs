using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.EventHandlers;
using SM.Edu.Core.Dominio.Events;

namespace SM.Edu.Core.Dominio.Utils
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event;
    }
}
