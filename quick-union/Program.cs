using System;

namespace quick_union
{
    class Program
    {
        static void Main(string[] args)
        {
            var quickUnion = new QuickUnion(10);
            quickUnion.Union(4, 3);
            quickUnion.Union(3, 8);
            quickUnion.Union(6, 5);
            quickUnion.Union(9, 4);
            quickUnion.Union(2, 1);


            Console.WriteLine(quickUnion);
        }
    }
}
