using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Xml.Schema;
using static Assignment.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators 
            #region Q01

            /// 1.Get first Product out of Stock
            /// 

            /// var Result =ProductList.FirstOrDefault(P=>P.UnitsInStock == 0);
            ///
            ///     Result =(from p in ProductList 
            ///             where p.UnitsInStock == 0
            ///             select p).FirstOrDefault();
            ///
            /// Console.WriteLine(Result);

            #endregion

            #region Q02

            ///  2.Return the first product whose
            /// Price > 1000, unless there is no match, in which case null is returned.
            /// 

            ///   var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            ///
            ///   Result = (from p in ProductList
            ///           where p.UnitPrice>1000
            ///           select p).FirstOrDefault();
            ///   Console.WriteLine(Result);

            #endregion

            #region Q03
            //  3.Retrieve the second number greater than 5

            /// int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ///
            ///  var Result = Arr.Where(p => p > 5).ElementAt(1);
            /// 
            ///  Result =(from p in Arr
            ///          .Where(p => p > 5)
            ///          select p).ElementAt(1);
            /// 
            ///  Console.WriteLine(Result);

            #endregion

            #endregion


            #region Aggregate Operators

            #region Q01
            /// 1.Uses Count to get the number of odd numbers in the array
            /// 

            ///  int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ///
            ///   var Result = Arr.Count(p => p % 2 == 1);
            ///
            ///      Result = (from p in Arr
            ///                where p % 2 == 1
            ///                select p).Count();
            ///
            ///   Console.WriteLine(Result);



            #endregion

            #region Q02
            // 2.Return a list of customers and how many orders each has.

            ///  var Result = CustomerList.GroupBy(c => c.CustomerName,(Key,Product)=>new {Customer=Key,Count=Product.Count()}).ToList();
            ///
            ///  foreach (var item in Result)
            ///  {
            ///    Console.WriteLine(item);
            ///  }


            #endregion

            #region Q03
            // Return a list of categories and how many products each has

            ///  var Result =ProductList.GroupBy(P=>P.Category,(Key,k)=>new {Category =Key, Count=k.Count()}).ToList();
            ///
            ///  Result =
            ///          (from p in ProductList
            ///           group p by p.Category into g
            ///           select new { Category = g.Key, Count = g.Count() })
            ///          .ToList();
            ///
            ///  foreach (var item in Result) Console.WriteLine(item);


            #endregion


            #region Q04 
            /// 4.Get the total of the numbers in an array.
            /// 


            /// int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ///
            ///  var Result = Arr.Sum();
            ///
            ///  Result = (from a in Arr
            ///            select a).Sum();
            ///
            ///  Console.WriteLine(Result);



            #endregion

            #region Q05
            //Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt
            //into Array of String First).

            ///  string filePath = @"D:\Route\LINQ\Session02\Day_02_LINQ\dictionary_english.txt";
            ///  if (File.Exists(filePath))
            ///  {
            ///      string[] dictionary = File.ReadAllLines(filePath);
            ///      
            ///      var Result = dictionary.Sum(x => x.Length);
            ///
            ///      Result = (from d in dictionary
            ///                select d.Length).Sum();
            ///
            ///      Console.WriteLine(Result);  
            ///
            ///    
            ///  } else Console.WriteLine("Number is not foune\n");




            #endregion

            #region Q06 

            /// 6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            /// 


            ///  string filePath = @"D:\Route\LINQ\Session02\Day_02_LINQ\dictionary_english.txt";
            ///  if (File.Exists(filePath))
            ///  {
            ///      string[] dictionary = File.ReadAllLines(filePath);
            ///      
            ///      var Result = dictionary.Min(x=>x.Length);
            ///
            ///       Result = (from d in dictionary
            ///                 select d.Length).Min();
            ///
            ///      Console.WriteLine(Result);  
            ///
            ///    
            ///  } else Console.WriteLine("There is no word\n"); 
            #endregion

            #region Q07 

            ///7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            ///


            ///    string filePath = @"D:\Route\LINQ\Session02\Day_02_LINQ\dictionary_english.txt";
            ///      if (File.Exists(filePath))
            ///      {
            ///          string[] dictionary = File.ReadAllLines(filePath);
            ///          
            ///          var Result = dictionary.Max(x=>x.Length);
            ///    
            ///           Result = (from d in dictionary
            ///                     select d.Length).Max();
            ///    
            ///          Console.WriteLine(Result);  
            ///    
            ///        
            ///      } else Console.WriteLine("There is no word\n"); 

            #endregion

            #region Q08 

            ///8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            ///  string filePath = @"D:\Route\LINQ\Session02\Day_02_LINQ\dictionary_english.txt";
            ///    if (File.Exists(filePath))
            ///    {
            ///        string[] dictionary = File.ReadAllLines(filePath);
            ///        
            ///        var Result = dictionary.Average(x=>x.Length);
            ///  
            ///         Result = (from d in dictionary
            ///                   select d.Length).Average();
            ///  
            ///        Console.WriteLine(Result);  
            ///  
            ///      
            ///    } else Console.WriteLine("There is no word\n"); 



            #endregion

            #region Q09
            ///9. Get the total units in stock for each product category.
            ///

            ///   var Result = ProductList.GroupBy(p => p.Category)
            ///                             .Select(g => new
            ///                             {
            ///                                 Category = g.Key,
            ///                                 TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            ///                             })
            ///                             .ToList();
            ///
            ///  foreach ( var result in Result )
            ///  {
            ///     Console.WriteLine(result);
            ///  }


            #endregion

            #region Q10
            ///10. Get the cheapest price among each category's products
            ///


            ///   var Result = ProductList.GroupBy(p => p.Category).Select(g => new
            ///   {
            ///       Category = g.Key,
            ///       CheapestPrice= g.Min(p=>p.UnitPrice)
            ///   });
            ///   
            ///   foreach (var item in Result) Console.WriteLine(item);
            #endregion

            #region Q11
            ///1. Get the products with the cheapest price in each category (Use Let)
            ///

            ///  var Result = (from p in ProductList
            ///                group p by p.Category
            ///              into g
            ///                let minprice = g.Min(P => P.UnitPrice)
            ///                select new
            ///                {
            ///                    Category = g.Key
            ///                        ,
            ///                    CheapestPric = minprice
            ///                }).ToList();
            /// 
            ///         foreach(var item in Result) Console.WriteLine(item);


            #endregion


            #region Q012
            ///12. Get the most expensive price among each category's products.
            ///

            ///   var Result =( ProductList.GroupBy(p => p.Category).Select(g => new
            ///   {
            ///       Category = g.Key 
            ///       , ExpensivePrice =  g.Max(P=>P.UnitPrice)
            ///   })).ToList();
            /// 
            ///   Result =( from p in ProductList
            ///            group p by p.Category
            ///            into g
            ///            let MaxPrice = g.Max(p => p.UnitPrice)
            ///            select new
            ///            {
            ///                Category = g.Key
            ///                      ,
            ///                ExpensivePrice = MaxPrice
            ///            }).ToList();
            /// 
            ///   foreach (var item in Result) Console.WriteLine(item);
            #endregion

            ///// 
            #region Q13
            ///13. Get the products with the most expensive price in each category.

            ///  var Result = from p in ProductList
            ///               group p by p.Category
            ///               into g
            ///               let MaxPrice = g.Max(p => p.UnitPrice)
            ///               from gn in g
            ///               where gn.UnitPrice == MaxPrice
            ///               select new
            ///               {
            ///                   Category = gn.Category,
            ///                   UnitPrice = gn.ProductName,
            ///               };
            ///                           
            ///
            ///  foreach(var item in Result) Console.WriteLine(item); 
            #endregion

            #region Q14
            ///14. Get the average price of each category's products.

            ///  var Result = ProductList.GroupBy(a => a.Category)
            ///                          .Select(b => new
            ///                          {
            ///                              Category =b.Key,
            ///                              AveragePrice =b.Average(a=>a.UnitPrice)
            /// 
            ///                          }).ToList();
            /// 
            ///  Result = (from a in ProductList
            ///           group a by a.Category
            ///           into b
            ///           let c = b.Average(a => a.UnitPrice)
            ///           select new
            ///           {
            ///               Category = b.Key,
            ///               AveragePrice = b.Average(a => a.UnitPrice)
            ///           }).ToList();
            /// 
            ///  foreach(var result in Result) Console.WriteLine(result);
            #endregion

            #endregion

            #region Set Operators 

            #region Q01
            ///1. Find the unique Category names from Product List

            ///   var Result = ProductList.DistinctBy(p => p.Category);
            ///
            ///   Result = from p in ProductList
            ///            group p by p.Category into g
            ///            select g.First();
            ///
            ///
            ///   foreach (var item in Result) Console.WriteLine(item.Category);




            #endregion

            #region Q02
            ///Produce a Sequence containing the unique first letter from both product and customer names.

            ///  var Result = ProductList.Select(x => x.ProductName[0]).Union(CustomerList.Select(y => y.CustomerName[0]));
            ///
            ///  Result =(from p  in ProductList select p.ProductName[0])
            ///        .Union(from C in CustomerList select C.CustomerName[0]);
            ///
            ///  foreach (var item in Result) Console.WriteLine(item);
            ///
            #endregion

            #region Q03
            ///3. Create one sequence that contains the common first letter from both product and customer names.

            ///   var Result = (ProductList.Select(x => x.ProductName[0])).Intersect(CustomerList.Select(C => C.CustomerName[0]));
            ///
            ///   Result = (from p in ProductList select p.ProductName[0])
            ///       .Intersect(from c in CustomerList select c.CustomerName[0]);
            ///
            ///   foreach(var result in Result) Console.WriteLine(result);
            #endregion

            #region Q04
            ///4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            ///


            ///   var Result = ProductList.Select(x => x.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            ///
            ///   Result = (from P in ProductList select P.ProductName[0])
            ///             .Except(from c in CustomerList select c.CustomerName[0]);
            ///
            ///   foreach (var item in Result) Console.WriteLine(item);

            #endregion

            #region Q05
            ///5. Create one sequence that contains the last Three Characters in each name of all 
            ///customers and products, including any duplicates
            ///

            ///   var Result = ProductList.Select(p => p.ProductName.Length>3 ? p.ProductName.Substring(p.ProductName.Length-3):p.ProductName)
            ///               .Concat(CustomerList.Select(c => c.CustomerName.Length>3 ? c.CustomerName.Substring(c.CustomerName.Length-3):c.CustomerName));
            ///
            ///   Result =
            ///           (from p in ProductList
            ///            select p.ProductName.Length >= 3
            ///                ? p.ProductName.Substring(p.ProductName.Length - 3)
            ///                : p.ProductName)
            ///           .Concat(
            ///               from c in CustomerList
            ///               select c.CustomerName.Length >= 3
            ///                   ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            ///                   : c.CustomerName
            ///           );
            ///
            ///
            ///
            ///   foreach (var item in Result) Console.WriteLine(item);
            ///

            #endregion
            #endregion

            #region  Partitioning Operators

            #region Q01
            ///1. Get the first 3 orders from customers in Washington
            ///

            ///  var Result = CustomerList.Where(c => c.Country == "Washington").Take(3);
            ///
            ///  Result =( from c in CustomerList
            ///           where c.Country == "Washington"
            ///           select c).Take(3);
            ///
            ///  foreach (var Customer in Result) Console.WriteLine(Customer.CustomerName);
            #endregion

            #region Q02
            ///2. Get all but the first 2 orders from customers in Washington.
            ///

            ///   var Result = CustomerList.Where(c => c.Country == "Washington").Skip(2);
            ///
            ///   Result =( from c in CustomerList
            ///            where c.Address == "Washington"
            ///            select c).Skip(2);
            ///
            ///   foreach (var Customer in Result) Console.WriteLine(Customer.CustomerName);  


            #endregion

            #region Q03

            // 3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            ///   int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ///
            ///   var Result = numbers.TakeWhile((number, index) => index < number);
            ///
            ///   Result = from n in numbers
            ///           .TakeWhile((number, index) => index < number)
            ///           select n;
            ///
            ///   foreach(var number in Result)Console.WriteLine(number);

            #endregion

            #region Q04
            /// 4.Get the elements of the array starting from the first element divisible by 3.
            /// 

            ///      int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ///
            ///     var Result = numbers.SkipWhile(x => x % 3 != 0);
            ///
            ///    Result = from n in numbers
            ///           .SkipWhile(x => x % 3 != 0)
            ///            select n;
            ///
            ///   foreach( var x in Result)Console.WriteLine(x);


            #endregion

            #region Q05
            /// 5.Get the elements of the array starting from the first element less than its position.
            /// 

            ///   int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ///
            ///   var Result = numbers.SkipWhile((number, index) => number>index );
            ///
            ///   Result = from n in numbers
            ///           .SkipWhile((number, index) => number > index)
            ///            select n;
            ///
            ///   foreach (var item in Result)Console.WriteLine(item);


            #endregion
            #endregion

            #region Quantifiers 

            #region Q01
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt
            //into Array of String First) contain the substring 'ei'.


            ///   string filePath = @"D:\Route\LINQ\Session02\Day_02_LINQ\dictionary_english.txt";
            ///   if (File.Exists(filePath))
            ///   {
            ///       string[] dictionary = File.ReadAllLines(filePath);
            ///
            ///     bool Result = dictionary.Any(p => p.Contains("ei"));
            ///
            ///     Console.WriteLine(Result);
            /// 
            ///     
            ///   } else Console.WriteLine("There is no word\n");  
            #endregion

            #region Q02

            ///  2.Return a grouped a list of products only for categories that have at least one product that is out of stock.
            ///  

            ///    var Result =ProductList.GroupBy(p=>p.Category).Where(p=>p.Any(c=>c.UnitsInStock==0));
            ///
            ///    Result = from p in ProductList
            ///             group p by p.Category
            ///            into g
            ///             where g.Any(p=>p.UnitsInStock==0)
            ///             select g;
            ///
            ///
            ///
            ///    foreach (var item in Result)
            ///    {
            ///        Console.WriteLine(item.Key);
            ///        foreach(var item2 in item) Console.WriteLine($"--{item2.ProductName}");
            ///    }



            #endregion

            #region Q03
            //3. Return a grouped a list of products only for categories that have all of their products in stock.

            ///   var Result =ProductList.GroupBy(p=>p.Category).Where(p=>p.Any(c=>c.UnitsInStock>0));
            ///
            ///   Result = from p in ProductList
            ///            group p by p.Category
            ///           into g
            ///            where g.Any(p=>p.UnitsInStock>0)
            ///            select g;
            ///
            ///
            ///
            ///   foreach (var item in Result)
            ///   {
            ///       Console.WriteLine(item.Key);
            ///       foreach(var item2 in item) Console.WriteLine($"--{item2.ProductName}");
            ///   }
            ///
            #endregion

            #endregion

            #region grouping 

            #region Q01
            ///Use group by to partition a list of numbers by their remainder when divided by 5
            ///



        ///   List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        ///
        ///   var Result = numbers.GroupBy(x => x % 5);
        ///
        ///   Result = from n in numbers
        ///            group n by n % 5;
        ///           
        ///
        ///   foreach( var result in Result )
        ///   {
        ///       Console.WriteLine(result.Key);
        ///       foreach (var item in result) Console.WriteLine($"...{item}");
        ///   }


            #endregion


            #endregion



        }
    }
}
