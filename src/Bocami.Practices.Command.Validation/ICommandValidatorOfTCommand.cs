using Bocami.Practices.Validation;

namespace Bocami.Practices.Command.Validation
{
    public interface ICommandValidator<in TCommand> : IValidator<TCommand>
        where TCommand : ICommand
    {
    }
}
