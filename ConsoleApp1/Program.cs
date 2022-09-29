using System;
public class MainClass
{
    public static void Main()
    {
        double a;
        Console.WriteLine("Введите значение a:");
        a = int.Parse(Console.ReadLine());
        if (-15 < a && a<= 12) 
            {
            Console.WriteLine("True");
            }
        else if (14< a&& a<17)
        {
            Console.WriteLine("True");
        }
        else if (19 <= a)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

}
