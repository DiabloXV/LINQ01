using Day_01_G03;
using static Day_01_G03.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operator
            ////Q1
            //var OutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine("Products Out Of Stock Are : \n");
            //foreach (var Product in OutOfStock)
            //{
            //    Console.WriteLine($"{Product.ProductID} : {Product.ProductName}\n");
            //}

            //Console.WriteLine("************************************************\n");

            ////Q2
            //var Result = ProductsList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine($"{Product.ProductID} : {Product.ProductName}\n");
            //}

            //Console.WriteLine("\n************************************************\n");
            ////Q3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result01 = Arr.Where((name, index) => name.Length < index);

            //Console.WriteLine(string.Join(", ", Result01));
            #endregion

            #region Ordering Operators
            ////Q1
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var Product in result)
            //{
            //    Console.WriteLine($"{Product}\n");
            //}

            ////Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedArr = Arr.OrderBy(word => word, new CaseInsensitiveComparer());
            //Console.WriteLine(string.Join(", ", sortedArr));

            ////Q3
            //result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var Product in result)
            //{
            //    Console.WriteLine($"{Product}\n");
            //}

            ////Q4
            //string[] Arr01 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedArr01 = Arr.OrderBy(word => word.Length).ThenBy(word => word);
            //Console.WriteLine(string.Join(", ", sortedArr01));

            ////Q5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr02 = Arr.OrderBy(word => word.Length).ThenBy(word => word, new CaseInsensitiveComparer());
            //Console.WriteLine(string.Join(", ", sortedArr02));

            ////Q6
            //result = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var Product in result)
            //{
            //    Console.WriteLine($"{Product.Category} : {Product.ProductName} : {Product.UnitPrice}\n");
            //}

            ////Q7
            //var sortedArr03 = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, new CaseInsensitiveComparer());
            //Console.WriteLine(string.Join(", ", sortedArr03));

            ////Q8
            //var Newlist = Arr01.Where(word => word.Length > 1 && word[1] == 'i').Reverse().ToList();
            //Console.WriteLine(string.Join(", ", Newlist));
        }

        #endregion


    }
}

