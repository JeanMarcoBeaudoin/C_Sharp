public class UserInput
{
    public void ReadResult()
    {
        string? readResult;
        Console.WriteLine("Enter a value:");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);

    }

}