using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.Edu.Core.Dominio.Commands;
using SM.Edu.Core.Dominio.Domain;
using SM.Edu.Core.Dominio.Storage;

namespace SM.Edu.Core.Dominio.CommandHandlers
{
    public class DeleteItemCommandHandler : ICommandHandler<DeleteItemCommand>
    {
        private readonly IRepository<DiaryItem> _repository;

        public DeleteItemCommandHandler(IRepository<DiaryItem> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var aggregate = _repository.GetById(command.Id);
            aggregate.Delete();
            _repository.Save(aggregate,aggregate.Version);
            
        }
    }
}
