public class Validation
{
    public bool IsValid(string input)
    {
        return !string.IsNullOrWhiteSpace(input);
    }
}