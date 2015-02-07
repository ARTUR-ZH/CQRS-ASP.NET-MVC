using System;

namespace SM.Edu.Core.Dominio.Domain.Mementos
{
    public class BaseMemento
    {
        public Guid Id { get; internal set; }
        public int Version { get; set; }
    }
}
