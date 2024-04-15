using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int current = 0;

        do
        {

            current = random.Next(1, 11);
            Console.WriteLine(current); 
        } while (current != 7);

        while (current != 7)
        {

            Console.WriteLine(current); 
            current = random.Next(1,11);
        };
    }
}