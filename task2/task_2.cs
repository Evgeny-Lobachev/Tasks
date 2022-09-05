internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(num3, Math.Max(num1, num2));
        Console.WriteLine($"Большее число : {max}");
    }
}