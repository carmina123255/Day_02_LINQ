
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static Demo.ListGenerator;
namespace Demo
{
    internal class EqualityComparerwithId : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            return x.ProductID.Equals(y.ProductID);
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
           return HashCode.Combine(obj.ProductID);
        }
    }
    internal class ProductComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x?.UnitsInStock.CompareTo(y.UnitsInStock) ?? (y is null ? 0 : -1);
        }
    }
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
            /// 
            #endregion

            #region Aggregate Operation [Min,Max,MinBy,MaxBy]

            ///   var MaxProduct = ProductList.Max();//class should implemetn ICombarable
            ///      MaxProduct = ProductList.Max(new ProductComparer());
            ///      MaxProduct = ProductList.MaxBy(p=>p.UnitsInStock);
            ///
            ///
            ///   var MinProduct = ProductList.Max();//class should implemetn ICombarable
            ///   MinProduct = ProductList.Max(new ProductComparer());
            ///   MinProduct = ProductList.MaxBy(p => p.UnitsInStock);


            ///  var MaxPrice=ProductList.Max(p=>p.UnitPrice);
            ///  var Result = ProductList.Max(p => p.ProductName); 
            ///  
            ///  
            ///   MaxPrice=ProductList.Min(p=>p.UnitPrice);
            ///   Result = ProductList.Min(p => p.ProductName);
            ///   

            #endregion

            #region Aggregate operator - Aggregate 
            /// string[] Name = ["Kermina", "Maged", "Matta", "Leweze"];
            /// string FullName = Name.Aggregate((str01, str02) => $"{str01} {str02}");
            ///  FullName = Name.Aggregate("Hello",(str01, str02) => $"{str01} {str02}");
            ///  FullName = Name.Aggregate("Hello",(str01, str02) => $"{str01} {str02}",(TAccumlate)=>TAccumlate.Replace(' ','*'));
            ///    
            /// Console.WriteLine(FullName); 
            #endregion
            #region aggregate  CountBy() ,AggregateBy() 

            ///  var orders = new List<Order>();
            ///
            ///  var data = orders.OrderBy(o => o.CustomerId).ToList()
            ///                 .CountBy(Order => Order.CustomerId); ; 
            #endregion


            #region Converstion (Casting) Operator 
            ///    List<Product> products = ProductList.Where(p=>p.UnitsInStock == 0).ToList();
            ///
            ///    Product[] array =ProductList.Where(p=>p.UnitsInStock==0).ToArray();
            ///
            ///
            ///    Dictionary<long, Product> dictionary01 = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            ///    Dictionary<long, string> dictionary02 = ProductList.Where(p => p.UnitsInStock == 0)
            ///        .ToDictionary(p => p.ProductID,p=>p.ProductName);
            ///    Dictionary<long, string> dictionary03 =ProductList.Where(p=>p.UnitsInStock != 0).ToDictionary(p=>p.ProductID,p=>p.ProductName, EqualityComparer<long>.Default);
            ///    Dictionary<long, Product> dictionary04 =ProductList.Where(p=>p.UnitsInStock != 0).ToDictionary(p=>p.ProductID ,EqualityComparer<long>.Default);
            ///
            ///    var SortedCollection = ProductList.Where(P=>P.UnitsInStock==0).ToImmutableSortedSet();
            ///
            ///    SortedCollection.Add(new Product { ProductName = "TEA" });
            ///
            ///    foreach (var product in SortedCollection)
            ///        Console.WriteLine(product); 
            #endregion


            #region Generation Operators 
            /// var Result = Enumerable.Range(0, 100);
            /// 
            /// Result = Enumerable.Repeat<int>(2, 100);
            /// var Result02 = Enumerable.Repeat<Product>(new Product() { ProductName = "Chicken" },100);
            /// 
            /// var Result03= Enumerable.Empty<Product>(); 
            #endregion

            #region Set Operator UnionFamiley

            #region Example 01 
            /// var Seq01 = Enumerable.Range(0, 100);
            /// var Seq02=Enumerable.Range(50,100);
            ///
            /// var Result = Seq01.Union(Seq02);
            /// Result=Seq01.Concat(Seq02);
            ///
            /// Result=Result.Distinct(); //Filteration Operator 
            /// Result=Seq01.Except(Seq02);
            /// Result=Seq01.Intersect(Seq02); 
            #endregion

        ///   var Seq01 = new List<Product>()
        ///   {
        ///
        ///       new Product(){ProductID=1,ProductName="chai",Category="Baverage",UnitPrice=18,UnitsInStock=100},
        ///       new Product(){ProductID=2,ProductName="DoubleShot",Category="Baverage",UnitPrice=19,UnitsInStock=17},
        ///       new Product(){ProductID=2,ProductName="DoubleShot",Category="Baverage",UnitPrice=19,UnitsInStock=17},
        ///       new Product(){ProductID=2,ProductName="DoubleShot",Category="Baverage",UnitPrice=19,UnitsInStock=17},
        ///       new Product(){ProductID=3,ProductName="White Mocka",Category="Condiments",UnitPrice=10,UnitsInStock=13},
        ///
        ///   };
        ///
        ///   var Seq02 = new List<Product>()
        ///   {
        ///         new Product(){ProductID=1,ProductName="chai",Category="Baverage",UnitPrice=18,UnitsInStock=100},
        ///         new Product(){ProductID=3,ProductName="Ice Mocha",Category="Baverage",UnitPrice=12,UnitsInStock=100},
        ///         new Product(){ProductID=4,ProductName="Frappe",Category="Condiments",UnitPrice=18,UnitsInStock=200},
        ///         new Product(){ProductID=5,ProductName="Milk",Category="Baverage",UnitPrice=8,UnitsInStock=10},
        ///         
        ///
        ///   };

            ///  var Result= Seq01.Union(Seq02);
            ///
            ///  Result = Seq01.Union(Seq02, new EqualityComparerwithId());
            ///  Result =Seq01.UnionBy(Seq02,p=>p.ProductID);
            /// 

            ///  var Result= Seq01.Intersect(Seq02);
            ///  Result =Seq02.Intersect(Seq01,new EqualityComparerwithId());
            ///  Result = Seq02.IntersectBy(Seq01.Select(p=>p.UnitPrice), P => P.UnitPrice);


            /// var Result= Seq01.Except(Seq02);
            /// Result =Seq02.Except(Seq01,new EqualityComparerwithId());
            /// Result = Seq02.ExceptBy(Seq01.Select(p=>p.ProductID), P => P.ProductID);
            /// 

            

            /// foreach (var item in Result) Console.WriteLine(item);
          
            
            
            
            
            #endregion




        }
    }
}
