using Framework.Core;

namespace Framework.Application
{
    public interface ICommandHandler { }

    public interface ICommandHandler<in T> : ICommandHandler where T : ICommand
    {
        void Handle(T handle);
    }
}
