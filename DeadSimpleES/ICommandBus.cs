using System;

namespace DeadSimpleES
{
    public interface ICommandBus
    {
        void Send<TCommand>(string id, TCommand command) where TCommand : ICommand;
    }
}
