using System.Collections.Generic;
using Framework.Core;

namespace Framework.Application
{
    public class CommandBus : ICommandBus
    {
        void ICommandBus.Dispatch<T>(T command)
        {
            var execute = ServiceLocator.Current.GetInstance<ICommandHandler<T>>();
            execute.Handle(command);
            ServiceLocator.Current.Release(execute);
        }
        
        public List<T> GetData<T>() where T : ICommand
        {
            var execute = ServiceLocator.Current.GetInstance<IQueryHandler<T>>();
            var result = execute.Handle();
            ServiceLocator.Current.Release(execute);
            return result;
        }
    }
}
