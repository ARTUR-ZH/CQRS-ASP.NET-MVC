using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Events;
using SM.Edu.Core.Dominio.Reporting;

namespace SM.Edu.Core.Dominio.EventHandlers
{
    public class ItemFromChangedEventHandler : IEventHandler<ItemFromChangedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemFromChangedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemFromChangedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            item.From = handle.From;
            item.Version = handle.Version;
        }
    }
}
