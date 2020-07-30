using Framework.Core;

namespace Framework.Application
{
    public class TransactionalCommandHandlerDecorator<T> : ICommandHandler<T> where T : ICommand
    {
        private readonly IUnitofwork _unitofwork;
        private readonly ICommandHandler<T> _commandHandler;
        public TransactionalCommandHandlerDecorator(IUnitofwork unitofwork, ICommandHandler<T> commandHandler)
        {
            _unitofwork = unitofwork;
            _commandHandler = commandHandler;
        }

        public void Handle(T handle)
        {
            try
            {
                _unitofwork.Begin();
                _commandHandler.Handle(handle);
            }
            catch
            {
                _unitofwork.Rollback();
            }
            finally
            {
                _unitofwork.Commit();
            }
        }
    }
}
