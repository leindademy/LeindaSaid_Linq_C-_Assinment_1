using System.Threading;
using static LeindaSaid_Linq_C__Assinment1.ListGenerator;
namespace LeindaSaid_Linq_C__Assinment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ( LINQ - Restriction Operators )
            #region Ques_1

            // 1- Find all products that are out of stock 

            // Using Query Syntax
            //var products = from product in ProductList
            //               where product.UnitsInStock == 0
            //               select product;

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Ques_2
            // 2. Find all products that are in stock and cost more than 3.00 per unit
            // Using Query Syntax

            //var products = from product in ProductList
            //               where product.UnitsInStock >0 
            //               && product.UnitPrice >3
            //                select product;

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Ques_3

            //Returns digits whose name is shorter than their value.
            // String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // Use a Query syntax

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var selectedDigits = from digit in Arr

            //                     where digit.Length < Array.IndexOf(Arr, digit)
            //                     select digit;
            //foreach (var X in selectedDigits)
            //{
            //    Console.WriteLine(X);
            //}
            #endregion

            //2 ( LINQ - Ordering Operators )
            #region Ques_1
            // 1. Sort all products by name
            // Use a Query syntax
            //var X = from product in ProductList
            //        orderby product.ProductName
            //        select product;
            //foreach (var Y in X)
            //{
            //    Console.WriteLine(Y);
            //}

            #endregion

            #region Ques_2
            // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // Flunt Syntax
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //    var OrderdArray = arr
            //       .OrderBy(word => word, StringComparer.OrdinalIgnoreCase); // OrdinalIgnoreCase (function is buld in)

            //    foreach (var Allwords in OrderdArray)
            //   {
            //       Console.WriteLine(Allwords);
            //   }

            #endregion

            #region Ques_3

            // 3. Sort a list of products by units in stock from highest to lowest.
            // use a flunt syntax
            //var OrderByDescending = ProductList.OrderByDescending(product => product.UnitsInStock);

            //foreach (var Descendingproducts in OrderByDescending)
            //{
            //    Console.WriteLine(Descendingproducts);
            //}
            #endregion

            #region Ques_4
            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine "};

            //var sortADigits = from digit in Arr
            //                   orderby digit.Length descending
            //                   select digit;

            //    foreach (var digit in sortADigits)
            //    {
            //        Console.WriteLine(digit);
            //    }

            #endregion

            // 3 (LINQ – Transformation Operators )
            #region Ques_1
            // 1- Return a sequence of just the names of a list of products.
            // use a flunt syntax

            //var NameOfProduct = from product in ProductList
            //         select product.ProductName;


            //foreach (var name in NameOfProduct)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Ques_2
            // 2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry"};

            // use a Query syntax
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Upper_Lower = from word in words
            //             select new { org = word, low = word.ToLower(),  upp = word.ToUpper() };

            //foreach (var word in Upper_Lower)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region Ques_3
            //3. Produce a sequence containing some properties of Products,
            // including UnitPrice which is renamed to Price in the resulting type.
            // use a flunt syntax

            var Price = from product in ProductList
                        select new {name = product.ProductName, Price = product.UnitPrice };

            foreach (var product in Price)
            {
                Console.WriteLine (product);
            }
            #endregion



        }
    }
}
