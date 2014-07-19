using Bocami.Practices.Validation;

namespace Bocami.Practices.Command.Validation
{
    public class NullCommandValidator<TCommand> : NullValidator<TCommand>, ICommandValidator<TCommand> 
        where TCommand : ICommand
    {
    }
}
