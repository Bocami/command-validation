using Bocami.Practices.Validation;

namespace Bocami.Practices.Command.Validation
{
    public interface ICommandValidator<TCommand> : IValidator<TCommand>
        where TCommand : class, ICommand
    {
    }
}
