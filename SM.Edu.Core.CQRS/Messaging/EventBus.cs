using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Events;
using SM.Edu.Core.Dominio.Exceptions;
using SM.Edu.Core.Dominio.Utils;

namespace SM.Edu.Core.Dominio.Messaging
{
    public class EventBus:IEventBus
    {
        private IEventHandlerFactory _eventHandlerFactory;

        public EventBus(IEventHandlerFactory eventHandlerFactory)
        {
            _eventHandlerFactory = eventHandlerFactory;
        }
        
        public void Publish<T>(T @event) where T : Event
        {
            var handlers = _eventHandlerFactory.GetHandlers<T>();
            foreach (var eventHandler in handlers)
            {
                eventHandler.Handle(@event);
            }
        }
    }
}
