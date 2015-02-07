using System;

namespace SM.Edu.Core.Dominio.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
