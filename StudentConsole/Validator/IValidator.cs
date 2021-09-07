namespace StudentConsole
{
    public interface IValidator
    {
        bool Validate();
        string ErrorMessage { get; }
    }
}