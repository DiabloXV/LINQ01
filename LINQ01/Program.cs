using Day_01_G03;
using static Day_01_G03.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operator
            //Q1
            var OutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            Console.WriteLine("Products Out Of Stock Are : \n");
            foreach (var Product in OutOfStock)
            {
                Console.WriteLine($"{Product.ProductID} : {Product.ProductName}\n");
            }

            Console.WriteLine("************************************************\n");

            //Q2
            var Result = ProductsList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);
            foreach (var Product in Result)
            {
                Console.WriteLine($"{Product.ProductID} : {Product.ProductName}\n");
            }

            Console.WriteLine("\n************************************************\n");
            //Q3
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result01 = Arr.Where((name, index) => name.Length < index);

            Console.WriteLine(string.Join(", ", Result01));
            #endregion


        }
    }
}
