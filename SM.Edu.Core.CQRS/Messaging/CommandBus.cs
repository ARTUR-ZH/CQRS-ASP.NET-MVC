using System;
using System.Collections.Generic;
using SM.Edu.Core.Dominio.Commands;
using SM.Edu.Core.Dominio.Exceptions;
using SM.Edu.Core.Dominio.Utils;

namespace SM.Edu.Core.Dominio.Messaging
{
    public class CommandBus:ICommandBus
    {
        private readonly ICommandHandlerFactory _commandHandlerFactory;

        public CommandBus(ICommandHandlerFactory commandHandlerFactory)
        {
            _commandHandlerFactory = commandHandlerFactory;
        }

        public void Send<T>(T command) where T : Command
        {
            var handler = _commandHandlerFactory.GetHandler<T>();
            if (handler != null)
            {
                handler.Execute(command);
            }
            else
            {
                throw new UnregisteredDomainCommandException("no handler registered");
            }
        }        
    }
}
