using System.Collections.Generic;
using Framework.Core;

namespace Framework.Application
{
    public interface ICommandBus
    {
        void Dispatch<T>(T command) where T : ICommand;

        List<T> GetData<T>() where T : ICommand;
    }

}
