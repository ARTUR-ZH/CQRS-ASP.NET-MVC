using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Events;
using SM.Edu.Core.Dominio.Reporting;

namespace SM.Edu.Core.Dominio.EventHandlers
{
    public class ItemToChangedEventHandler : IEventHandler<ItemToChangedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemToChangedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemToChangedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            item.To = handle.To;
            item.Version = handle.Version;
        }
    }
}
