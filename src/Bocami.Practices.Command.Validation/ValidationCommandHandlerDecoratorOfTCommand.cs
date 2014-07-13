using Bocami.Practices.DecoratorPattern;

namespace Bocami.Practices.Command.Validation
{
    public abstract class ValidationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>, IDecorator<ICommandHandler<TCommand>>
            where TCommand : class, ICommand
    {
        private ICommandHandler<TCommand> commandHandler;
        private ICommandValidator<TCommand> commandValidator;

        public ValidationCommandHandlerDecorator(ICommandHandler<TCommand> commandHandler, ICommandValidator<TCommand> commandValidator)
        {
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
