using System.Collections.Generic;
using System.Diagnostics;
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

            #endregion



        }
    }
}
