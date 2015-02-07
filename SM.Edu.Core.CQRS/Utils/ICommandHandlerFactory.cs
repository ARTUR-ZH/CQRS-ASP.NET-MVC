using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.CommandHandlers;
using SM.Edu.Core.Dominio.Commands;

namespace SM.Edu.Core.Dominio.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
