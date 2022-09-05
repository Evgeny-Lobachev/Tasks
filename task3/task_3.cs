
internal class Program
{
    private static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.Write("Четное число");
        }
        else
        {
            Console.Write("Нечетное число");
        }
    }
}