internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        int number_2 = 1;
        string Result = "";

        if (number_1 == 0 || number_1 == 1) 
        {
            Result = "  нет четных чисел в промежутке";
        }
        else
        {
            if (number_1 < 0)
            {
                while (number_2 >= number_1)
                {
                    if (number_1 % 2 == 0)
                    {
                        Result = Result + ", " + number_1; number_1++;
                    }
                    else
                    {
                        number_1++;
                    }
                }
            }
            else
            {
                while (number_2 <= number_1)
                {
                    if (number_2 % 2 == 0)
                    {
                        Result = Result + ", " + number_2;
                        number_2++;
                    }
                    else
                    {
                        number_2++;
                    }
                }
            }
        }
        Console.WriteLine(Result.Remove(0, 2));
    }
}