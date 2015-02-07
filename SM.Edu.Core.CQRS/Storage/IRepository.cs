using System;
using SM.Edu.Core.Dominio.Domain;

namespace SM.Edu.Core.Dominio.Storage
{
    public interface IRepository<T> where T : AggregateRoot, new()
    {
        void Save(AggregateRoot aggregate, int expectedVersion);
        T GetById(Guid id);
    }
}
