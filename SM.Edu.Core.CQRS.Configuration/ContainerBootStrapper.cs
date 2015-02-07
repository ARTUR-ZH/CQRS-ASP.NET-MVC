using SM.Edu.Core.Dominio.Messaging;
using SM.Edu.Core.Dominio.Reporting;
using SM.Edu.Core.Dominio.Storage;
using SM.Edu.Core.Dominio.Utils;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Edu.Core
{
    static class ContainerBootstrapper
    {
        public static void BootstrapStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.For(typeof(IRepository<>)).Singleton().Use(typeof(Repository<>));
                x.For<IEventStorage>().Singleton().Use<InMemoryEventStorage>();
                x.For<IEventBus>().Use<EventBus>();
                x.For<ICommandHandlerFactory>().Use<StructureMapCommandHandlerFactory>();
                x.For<IEventHandlerFactory>().Use<StructureMapEventHandlerFactory>();
                x.For<ICommandBus>().Use<CommandBus>();
                x.For<IEventBus>().Use<EventBus>();
                x.For<IReportDatabase>().Use<ReportDatabase>();
            });
        }
    }
}
