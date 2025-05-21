using System;
using ConsoleApp1;


namespace Idf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gbfh");
            Uman u1 = new Uman("dfgf",5);
            Terrorist t1 = new Terrorist(5, ["dfs", "df"], "live","dfs",20);
            Console.WriteLine(t1.Rank);
        }
    }
}