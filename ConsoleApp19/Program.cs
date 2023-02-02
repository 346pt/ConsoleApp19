using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(String[] args)
    {
        List<int> Virables = new List<int>();
        Console.WriteLine("Введите кол-во участников и голоса");
        for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            Virables.Add(int.Parse(Console.ReadLine()));

        foreach (var Line in from g in Virables
                             group g by g into ng
                             orderby ng.Key
                             select new
                             {
                                 Count = ng.Count(),
                                 Key = ng.Key
                             })
            Console.WriteLine("{0} {1}", Line.Key, Line.Count);
    }
}
