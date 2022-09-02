internal class task_2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Max = " + num1);
        }
        else if (num1 < num2)
        {
            Console.WriteLine("Max = " + num2);
        }
    }
}
