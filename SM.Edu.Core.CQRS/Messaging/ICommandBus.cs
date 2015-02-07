using System;
using SM.Edu.Core.Dominio.Commands;

namespace SM.Edu.Core.Dominio.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
