using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C50_GSatTue_Basics04
{
    class Program
    {
        #region Question 4 - Method

        #region Question 5 - Method

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        #endregion
        #region Question 6 - Method

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        #endregion

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        #endregion
        #region Question 7 - Method

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        #endregion
        #region Question 8 - Method

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        #endregion
        #region Question 9 - Method

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }

        #endregion
        #region Question 10 - Method

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book: {title}, Pages: {pages}");
        }

        #endregion
        #region Question 12 - Method

        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }

        #endregion
        static void Main(string[] args)
        {
            #region Question 1

            // 1. Create a one-dimensional array double[] prices.
            // Print the second price (index 1).

            {
                double[] prices = { 25.5, 40.0, 33.75 };

                Console.WriteLine(prices[1]);
            }

            #endregion
            #region Question 2

            // 2. Create a 2x2 multidimensional array shelfCopies.
            // Print copies on shelf 1, slot 0.

            //{
            //    int[,] shelfCopies =
            //    {
            //    { 3, 5 },
            //    { 1, 4 }
            //};

            //    Console.WriteLine(shelfCopies[1, 0]);
            //}

            #endregion
            #region Question 3

            // 3. Write a method PrintWelcomeMessage()
            // that prints "Welcome to the Library!".
            // Call it from Main.
         
            PrintWelcomeMessage();

            #endregion
            #region Question 4

            // 4. Write a method PrintBookTitle(string title)
            // that prints "Book title: " + title.
            // Call it with "Clean Code".

            PrintBookTitle("Clean Code");

            #endregion
            #region Question 5

            // 5. Write AddBonusPages(int pages) that adds 50 to pages.
            // Call it with int pages = 400 and print pages afterward.
            // Expected result: 400 because int is passed by value.

            {
                int pages = 400;

                AddBonusPages(pages);

                Console.WriteLine(pages);
            }

            #endregion
            #region Question 6

            // 6. Write ApplyDiscount(double[] prices)
            // that subtracts 5 from prices[0].
            // Print prices[0] afterward.
            // Expected result: 20.5 because the array contents are modified.

            {
                double[] prices = { 25.5, 40.0 };

                ApplyDiscount(prices);

                Console.WriteLine(prices[0]);
            }

            #endregion
            #region Question 7

            // 7. Rewrite AddBonusPages using ref.
            // Call it and print pages afterward.
            // Expected result: 450 because ref allows modifying the original variable.

            {
                int pages = 400;

                AddBonusPagesByRef(ref pages);

                Console.WriteLine(pages);
            }

            #endregion
            #region Question 8

            // 8. Write ReplaceArray(ref double[] prices)
            // that replaces the array with a new array.
            // Print prices.Length afterward.

            {
                double[] prices = { 25.5, 40.0 };

                ReplaceArray(ref prices);

                Console.WriteLine(prices.Length);
            }

            #endregion
            #region Question 9

            // 9. Write TryGetPrice(string title, out double price).
            // Return true and set price to 25.5 if title is "Clean Code".
            // Otherwise return false and set price to 0.
            // Print the price if found.

            {
                double price;

                bool found = TryGetPrice("Clean Code", out price);

                if (found)
                {
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("Book not found");
                }
            }

            #endregion
            #region Question 10

            // 10. Write PrintBookInfo(string title, int pages = 300).
            // Call it once with only a title,
            // and once passing both title and pages.

            PrintBookInfo("Clean Code");

            PrintBookInfo("Refactoring", 464);

            #endregion
            #region Question 11

            // 11. Call PrintBookInfo using named parameters.
            // Pass pages before title.

            PrintBookInfo(pages: 500, title: "The Pragmatic Programmer");

            #endregion
            #region Question 12

            // 12. Write PrintAllTitles(params string[] titles).
            // Call it with three book titles.

            PrintAllTitles(
                "Clean Code",
                "The Pragmatic Programmer",
                "Refactoring"
            );

            #endregion
        }
        #region Question 3 - Method

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        #endregion
    }
}
