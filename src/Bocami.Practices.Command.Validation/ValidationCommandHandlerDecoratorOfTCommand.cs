using System;
using Bocami.Practices.Decorator;

namespace Bocami.Practices.Command.Validation
{
    public class ValidationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>, IDecorator<ICommandHandler<TCommand>>
            where TCommand : class, ICommand
    {
        private readonly ICommandHandler<TCommand> commandHandler;
        private readonly ICommandValidator<TCommand> commandValidator;

        public ValidationCommandHandlerDecorator(ICommandHandler<TCommand> commandHandler, ICommandValidator<TCommand> commandValidator)
        {
            if (commandHandler == null)
                throw new ArgumentNullException("commandHandler");

            if (commandValidator == null)
                throw new ArgumentNullException("commandValidator");

            this.commandHandler = commandHandler;
            this.commandValidator = commandValidator;
        }

        public void Handle(TCommand command)
        {
            commandValidator.Validate(command);

            commandHandler.Handle(command);
        }
    }
}
