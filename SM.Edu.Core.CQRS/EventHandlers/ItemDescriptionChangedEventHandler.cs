using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Events;
using SM.Edu.Core.Dominio.Reporting;

namespace SM.Edu.Core.Dominio.EventHandlers
{
    public class ItemDescriptionChangedEventHandler : IEventHandler<ItemDescriptionChangedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemDescriptionChangedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemDescriptionChangedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            item.Description = handle.Description;
            item.Version = handle.Version;
        }
    }
}
