using System;
 class tehtava9
{
    public static void Main()
    {
        int x, y;
        char operation;

        Console.Write("Syötä ensimmäinen luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Syötä toiminto: ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (operation == '+')
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        else if (operation == '-')
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        else if ((operation == 'x') || (operation == '*'))
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        else if (operation == '/')
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        else
            Console.WriteLine("Väärä luku");
    }
}
