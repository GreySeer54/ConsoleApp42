using System;

public class Program
{
    public static string DetermineQuadrilateralType(double a, double b, double c, double d)
    {
        if (a <= 0 || b <= 0 || c <= 0 || d <= 0)
        {
            return "Сторона многоугольника не может быть <= 0";
        }

        if (a == b && a == c && a == d)
        {
            return "Четырехугольник является квадратом или ромбом";
        }
        else if (a == c && b == d && a != b)
        {
            return "Четырехугольник является прямоугольником";
        }
        else
        {
            return "Четырехугольник является трапецией или простым четырехугольником";
        }
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("Введите 4 стороны четырехугольника :");

            Console.Write("Сторона A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона D: ");
            double d = Convert.ToDouble(Console.ReadLine());

            string result = DetermineQuadrilateralType(a, b, c, d);
            Console.WriteLine(result);
        }
        catch
        {
            Console.WriteLine("Неверно введены переменные.\nПример ввода: 12 или 12,2.\nПопробуйте снова.");
        }
    }
}

