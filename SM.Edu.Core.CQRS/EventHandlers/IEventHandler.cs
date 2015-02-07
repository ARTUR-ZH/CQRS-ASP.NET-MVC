using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Events;

namespace SM.Edu.Core.Dominio.EventHandlers
{
    public interface IEventHandler<TEvent> where TEvent : Event
    {
        void Handle(TEvent handle);
    }
}
