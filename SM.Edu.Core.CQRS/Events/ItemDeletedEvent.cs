using System;

namespace SM.Edu.Core.Dominio.Events
{
    public class ItemDeletedEvent:Event
    {
        public ItemDeletedEvent(Guid aggregateId)
        {
			AggregateId = aggregateId;
        }
    }
}
