using System;
public class t17
{
    public static void Main()
    {
        Console.WriteLine("parittomat luvut välillä 1-99.");
        for (int n = 1; n < (99 + 1); n++)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n.ToString());
            }
        }

    }
}
