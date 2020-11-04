using System;
using System.Collections.Generic;


class BankAccount
{
    public string name;
    int accountNum;
    public double balance = 0;
    double interest = 0;
    public BankAccount(string namae, double firstDep)
    {
        name = namae;
        balance += firstDep;
    }

    public void setIntRate(double per)
    {
        interest = per;
    }

    public double getBal()
    {
        return balance;
    }

    public string getName()
    {
        return this.name;
    }

    public void deposit(double addAmt)
    {
        balance += addAmt;
    }

    public bool withdraw(double outAmt)
    {
        bool chk = true;
        if (outAmt <= balance)
        {
            balance -= outAmt;
        }
        else if (outAmt > balance)
        {
            chk = false;
        }
        return chk;
    }

    public double getBalAfter(int mos)
    {
        double prin = balance;
        double intFeed;
        for (int g = 1; g <= mos; g++)
        {
            intFeed = prin * interest;
            prin += intFeed;
        }
        return prin;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> bank = new List<BankAccount>();
        while (true)
        {
            Console.Write("1. Määritä tili\n2. Tarkista saldo\n3. Tallettaa\n4. Nostaa\n5. Aseta korko \nX. Lopeta\n\nSelect Function: ");
            string selGo = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            if (selGo == "1")
            {
                Console.Write("Syötä nimesi: ");
                string name = Console.ReadLine();
                Console.Write("Syötä alkuperäinen saldo: ");
                double init = double.Parse(Console.ReadLine());
                bank.Add(new BankAccount(name, init));
                Console.WriteLine("Pankkitili lisätty!");
                Console.ReadLine();
            }
        }
    }
}
          
