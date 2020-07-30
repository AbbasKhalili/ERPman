using System.Collections.Generic;
using System.Linq;

namespace Framework.Application
{
    public interface IQueryHandler { }

    public interface IQueryHandler<T> : IQueryHandler 
    {
        List<T> Handle();
    }
}


