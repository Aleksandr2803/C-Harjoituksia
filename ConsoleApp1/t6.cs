using System;
public class funcexer3
{
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    public static void Main()
    {
        Console.Write("\n\n Ohjelma, joka laskee kaksi numeroa yhteen.  :\n");
        Console.Write("---------\n");
        Console.Write("Syöyä numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Syötä toinen numero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nKahden numeron summa on : {0} \n", Sum(n1, n2));
    }
}
