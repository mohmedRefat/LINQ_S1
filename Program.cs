using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var ProductList = Source.ProductList;

        // Q1
        var q1 = ProductList.Where(p => p.Category == "Seafood");
        foreach (var p in q1)
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

        Console.WriteLine("-----------------------Q2---------------------------");

        //  Q2
        var q2 = ProductList.Select(p => p.ProductName);
        foreach (var name in q2)
            Console.WriteLine(name);
        Console.WriteLine("-----------------------Q3---------------------------");


        //     Q3
        var q3 = ProductList.OrderBy(p => p.UnitPrice);
        foreach (var p in q3)
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        Console.WriteLine("-----------------------Q4---------------------------");

        // Q4
        var q4 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
        foreach (var p in q4)
            Console.WriteLine(p.ProductName);
        Console.WriteLine("-----------------------Q5---------------------------");

        // Q5
        var q5 = ProductList.Where(p =>
            p.UnitsInStock > 0 && p.Category.Contains("Condiments"));
        foreach (var p in q5)
            Console.WriteLine(p.ProductName);
        Console.WriteLine("-----------------------Q6---------------------------");
        //      Q6
        var q6 = ProductList.Select(p => new
        {
            Name = p.ProductName,
            Price = p.UnitPrice,
            StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
        });
        foreach (var p in q6)
            Console.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");

        Console.WriteLine("-----------------------Q7---------------------------");
        //     Q7
        var q7 = ProductList.Select((p, i) =>
            new { Position = i + 1, Name = p.ProductName });
        foreach (var p in q7)
            Console.WriteLine($"{p.Position}. {p.Name}");

        Console.WriteLine("-----------------------Q8---------------------------");
        // Q8
        var q8 = ProductList.OrderBy(p => p.Category)
                            .ThenByDescending(p => p.UnitPrice);
        foreach (var p in q8)
            Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");

        Console.WriteLine("-----------------------Q9---------------------------");
        //      Q9
        var q9 = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);
        foreach (var p in q9)
            Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
        Console.WriteLine("-----------------------Q10---------------------------");
        //     Q10
        var q10 =
            from customer in Source.CustomerList
            from order in customer.Orders
            where order.OrderDate.Year >= 1997
            select new { customer.CustomerID, order.OrderDate };

        foreach (var order in q10)
            Console.WriteLine($"{order.CustomerID} - {order.OrderDate:d}");
        Console.WriteLine("-----------------------Q11---------------------------");

        //      Q11
        var q11 = ProductList.Select((p, i) =>
            new { Position = i + 1, ProductName = p.ProductName });
        foreach (var p in q11)
            Console.WriteLine($"{p.Position} - {p.ProductName}");

        Console.WriteLine("-----------------------Q12---------------------------");

        //      Q12
        string[] Arr = {
                 "aPPLE", "AbAcUs", "bRaNcH",
                 "BlUeBeRrY", "ClOvEr", "cHeRry"
             };

        var q12 = Arr.OrderBy(s => s.Length)
                     .ThenBy(s => s, StringComparer.OrdinalIgnoreCase);
        foreach (var s in q12)
            Console.WriteLine(s);

        Console.WriteLine("-----------------------Q13---------------------------");
        //     Q13



        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var q13 = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse().ToList();
        foreach (var d in q13)
            Console.WriteLine(d);

    }
}
