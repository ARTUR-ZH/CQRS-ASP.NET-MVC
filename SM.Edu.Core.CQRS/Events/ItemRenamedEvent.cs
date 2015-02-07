using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Edu.Core.Dominio.Events
{
    public class ItemRenamedEvent : Event
    {
        public string Title { get; internal set; }
        public ItemRenamedEvent(Guid aggregateId, string title)
        {
			AggregateId = aggregateId;
            Title = title;
        }
    }
}
