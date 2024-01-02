using System;

namespace Project21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, r;
            double area = 0, parameter = 0;
            int ch, chh;
            Console.WriteLine("What you Opt To Select Among : ");
            Console.WriteLine("1. Square 2. Circle 3. Rectangle 4. Quit");
            ch = int.Parse(Console.ReadLine());
            do
            {
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("You Have Opted Square : ");

                        Console.WriteLine("Now What Do You Wish To Perform For ! ");
                        Console.WriteLine("1.Calculate Area 2.Calculate Parameter 3.Calculate Both 4.You opted For Wrong Choice By Mistake ");
                        chh = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (chh)
                            {
                                case 1:
                                    Console.WriteLine("You Opted To Find Area So you need Its Length and Breadth ! ");
                                    Console.WriteLine("Length : ");
                                    l = int.Parse(Console.ReadLine());
                                    area = l * l;
                                    Console.WriteLine($"Area Is : {area}");
                                    break;
                                case 2:
                                    Console.WriteLine("You Opted To Find Area So you need Its Length and Breadth ! ");
                                    Console.WriteLine("Length : ");
                                    l = int.Parse(Console.ReadLine());
                                    parameter = 4 * l;
                                    Console.WriteLine($"Parameter Is : {parameter}");
                                    break;
                                case 3:
                                    Console.WriteLine("You Opted To Find Area and Parameter So you need Its Length and Breadth ! ");
                                    Console.WriteLine("Length : ");
                                    l = int.Parse(Console.ReadLine());
                                    area = l * l;
                                    parameter = 4 * l;
                                    Console.WriteLine($"Area Is : {area} and Parameter Is : {parameter}");
                                    break;
                                default:
                                    Console.WriteLine("You Opted The Wrong Choice So I Think You Wish to Quit ! ");
                                    chh = 4;
                                    break;
                            }
                        } while (chh != 4);
                        break;
                    case 2:
                        Console.WriteLine("You Have Opted Circle : ");

                        Console.WriteLine("Now What Do You Wish To Perform For ! ");
                        Console.WriteLine("1.Calculate Area 2.Calculate Parameter 3.Calculate Both 4.You opted For Wrong Choice By Mistake ");
                        chh = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (chh)
                            {
                                case 1:
                                    Console.WriteLine("You Opted To Find Area So you need Its radius ! ");
                                    Console.WriteLine("radius : ");
                                    r = int.Parse(Console.ReadLine());
                                    area = 3.14 * r * r;
                                    Console.WriteLine($"Area Is : {area}");
                                    break;
                                case 2:
                                    Console.WriteLine("You Opted To Find Area So you need Its Radius ! ");
                                    Console.WriteLine("Radius : ");
                                    r = int.Parse(Console.ReadLine());
                                    parameter = 2 * 3.14 * r;
                                    Console.WriteLine($"Parameter Is : {parameter}");
                                    break;
                                case 3:
                                    Console.WriteLine("You Opted To Find Area So you need Its Radius ! ");
                                    Console.WriteLine("Radius : ");
                                    r = int.Parse(Console.ReadLine());
                                    area = 3.14 * r * r;
                                    parameter = 2 * 3.14 * r;
                                    Console.WriteLine($"Area Is : {area} and Parameter Is : {parameter}");
                                    break;
                                default:
                                    Console.WriteLine("You Opted The Wrong Choice So I Think You Wish to Quit ! ");
                                    chh = 4;
                                    break;
                            }
                        } while (chh != 4);
                        break;
                    case 3:
                        Console.WriteLine("You Have Opted Rectangle : ");

                        Console.WriteLine("Now What Do You Wish To Perform For ! ");
                        Console.WriteLine("1.Calculate Area 2.Calculate Parameter 3.Calculate Both 4.You opted For Wrong Choice By Mistake ");
                        chh = int.Parse(Console.ReadLine());
                        do
                        {

                            switch (chh)
                            {
                                case 1:
                                    Console.WriteLine("You Opted To Find Area So you need Its Length and Breadth ! ");
                                    Console.WriteLine("Length : ");
                                    l = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Bredth : ");
                                    b = int.Parse(Console.ReadLine());
                                    area = l * b;
                                    Console.WriteLine($"Area Is : {area}");
                                    break;
                                case 2:
                                    Console.WriteLine("You Opted To Find Area So you need Its Length and Breadth ! ");
                                    Console.WriteLine("Length : ");
                                    l = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Bredth : ");
                                    b = int.Parse(Console.ReadLine());
                                    parameter = 2 * (l + b);
                                    Console.WriteLine($"Parameter Is : {parameter}");
                                    break;
                                case 3:
                                    Console.WriteLine("You Opted To Find Area and Parameter So you need Its Length and Breadth ! ");
                                    Console.WriteLine("Length : ");
                                    l = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                    parameter = 2 * (l + b);
                                    area = l * b;
                                    parameter = 4 * l;
                                    Console.WriteLine($"Area Is : {area} and Parameter Is : {parameter}");
                                    break;
                                default:
                                    Console.WriteLine("You Opted The Wrong Choice So I Think You Wish to Quit ! ");
                                    chh = 4;
                                    break;
                            }
                        } while (chh != 4);
                        break;
                    case 4:
                        Console.WriteLine("You Have Opted To Quit : ");
                        break;
                    default:
                        Console.WriteLine("You Have Opted Worng Option ! ");
                        ch = 4;
                        break;
                }
            } while (ch != 4);
        }
    }
}
