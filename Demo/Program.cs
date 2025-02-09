
using System.Collections;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Element Operator -Immediate Execution 
            #region First,Last ,FirstOrDefault,LastOrDefault Part01 
            // var Result = ProductList.First();
            // Result = ProductList.Last();

            // var Result = ProductList.FirstOrDefault();
            //  Result=ProductList.LastOrDefault();

            // var Result = ProductList.FirstOrDefault(new Product { ProductName = "Coffe" });
            // Result = ProductList.LastOrDefault(new Product { ProductName = "Coffe" }); 
            #endregion

            #region First,Last,FirstOrDefault,LastOrDefault Part02

            // var Result = ProductList.First(p=>p.UnitsInStock==0);
            // Result = ProductList.Last(p=>p.UnitsInStock==0);

            // var Result = ProductList.FirstOrDefault(p=>p.UnitsInStock>1000);
            //  Result=ProductList.LastOrDefault(P=>P.UnitsInStock>1000);

            // var Result = ProductList.FirstOrDefault(P => P.UnitsInStock > 1000,new Product { ProductName = "Coffe" });
            // Result = ProductList.LastOrDefault(P => P.UnitsInStock > 1000,new Product { ProductName = "Coffe" });

            #endregion

            #region ElementAt()
            /// var Result = ProductList.ElementAt(10);
            ///  Result = ProductList.ElementAt(new Index(10,true));
            ///  Result = ProductList.ElementAt(^10); 
            #endregion

            #region Single and SingleOrDefault Part01
            ///List<Product> DifferentProduct = new List<Product>() { ProductList[0] };
            /// var Result = DifferentProduct.Single();
            /// Result = DifferentProduct.SingleOrDefault();
            /// Result = DifferentProduct.SingleOrDefault(new Product { ProductName="Coffee"}); 
            #endregion

            #region Single and SingleOrDefault Part02

            //var Result = ProductList.Single(P=>P.ProductID==1);
            //Result = ProductList.SingleOrDefault(P=>P.ProductID==1);
            //Result = ProductList.SingleOrDefault(P=>P.UnitsInStock==0,new Product { ProductName="Coffee"});  
            #endregion

            #region SingleOrDefault VS FirstOrDefault

            /// var Result = ProductList.FirstOrDefault(p => p.ProductID == 1);//Select Top(1) on sql query
            ///  Result = ProductList.SingleOrDefault(p => p.ProductID == 1);//Select Top(2) on sql query 
            #endregion

            #region Hybrid Syntax 
            /// var Result =(from P in ProductList
            ///              where P.ProductID==10
            ///              select P).FirstOrDefault();
            #endregion

            //  Console.WriteLine(Result?.ProductName ?? "NA"); 
            #endregion

            #region Aggregate Operation -Immediate Execution 

            /// var Result = ProductList.Count();
            /// Result = ProductList.Count;
            /// ProductList.TryGetNonEnumeratedCount(out Result);

            /// var numbers = Enumerable.Range(0, 100);
            /// var Result = numbers.Count();
            /// numbers.TryGetNonEnumeratedCount(out Result);

            /// var Result = ProductList.Where(P => P.UnitsInStock == 0).Count();//5
            ///   Result = ProductList.Count(P => P.UnitsInStock==0);   //5
            ///     ProductList.Where(P => P.UnitsInStock==0).TryGetNonEnumeratedCount(out Result);//0

            // Console.WriteLine(Result); 
            #endregion

            #region Aggregate Operation -[Sum,Average]
            /// var Result =  ProductList.Sum(p=>p.UnitPrice);
            ///     Result=ProductList.Average(p=>p.UnitPrice);
            /// Console.WriteLine(Result);   
            #endregion
        }
    }
}
