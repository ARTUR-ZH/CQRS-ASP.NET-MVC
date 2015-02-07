using SM.Edu.Core.Dominio.Commands;

namespace SM.Edu.Core.Dominio.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
