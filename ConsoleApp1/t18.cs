
using System;
 class t18
{

    
    static void result(int N)
    {
        for (int num = 0; num < N; num++)
        {
            if (num % 3 == 0 )
                Console.Write(num + " ");
        }
    }

    static public void Main()
    {
        int N = 100;

        result(N);
    }

}
