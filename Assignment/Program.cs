using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
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

            #endregion



        }
    }
}
