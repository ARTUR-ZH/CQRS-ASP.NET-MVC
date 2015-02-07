using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Messaging;
using SM.Edu.Core.Dominio.Reporting;
using SM.Edu.Core.Dominio.Storage;
using SM.Edu.Core.Dominio.Utils;
using StructureMap;

namespace SM.Edu.Core
{
    public sealed class ServiceLocator
    {
        private static ICommandBus _commandBus;
        private static IReportDatabase _reportDatabase;
        private static bool _isInitialized;
        private static readonly object _lockThis = new object();

        static ServiceLocator()
        {
            if (!_isInitialized)
            {
                lock (_lockThis)
                {
                    ContainerBootstrapper.BootstrapStructureMap();
                    _commandBus = ObjectFactory.GetInstance<ICommandBus>();
                    _reportDatabase = ObjectFactory.GetInstance<IReportDatabase>();
                    _isInitialized = true;
                }
            }
        }

        public static ICommandBus CommandBus
        {
            get { return _commandBus; }
        }

        public static IReportDatabase ReportDatabase
        {
            get { return _reportDatabase; }
        }
    }
}
