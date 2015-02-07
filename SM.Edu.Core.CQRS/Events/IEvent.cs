using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.Edu.Core.Dominio.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}
