using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Events;
using SM.Edu.Core.Dominio.Reporting;

namespace SM.Edu.Core.Dominio.EventHandlers
{
    public class ItemCreatedEventHandler : IEventHandler<ItemCreatedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemCreatedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemCreatedEvent handle)
        {
            DiaryItemDto item = new DiaryItemDto()
                {
                    Id = handle.AggregateId,
                    Description =  handle.Description,
                    From = handle.From,
                    Title = handle.Title,
                    To=handle.To,
                    Version =  handle.Version
                };

            _reportDatabase.Add(item);
        }
    }
}
