using System.Linq;

namespace Framework.Domain
{
    public interface IRepository
    {

    }

    public interface IRepository<T> : IRepository where T : IAggregateRoot
    {
        long Create(T aggregate);

        void Delete(T aggregate);

        void Update(T aggregate);

        IQueryable<T> GetAll();
    }
}
