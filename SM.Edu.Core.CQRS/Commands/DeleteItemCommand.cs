using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Edu.Core.Dominio.Commands
{
    public class DeleteItemCommand : Command
    {
        public DeleteItemCommand(Guid id, int version) : base(id, version)
        {
        }
    }
}
