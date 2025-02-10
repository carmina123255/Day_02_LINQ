using System.Collections.Generic;
using System.Diagnostics;
using static Assignment.ListGenerators;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operator 
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



                #endregion
        }
        }
}
