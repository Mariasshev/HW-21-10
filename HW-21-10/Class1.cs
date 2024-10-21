using HW_21_10;
using System;
namespace ConsoleApp7
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            #region 1 Task
            //Magazine magazine1 = new Magazine("NewYorkTime", 1987, "short descr", 562874785, "newyorktimes@gmail.com", 10);
            //Magazine magazine2 = new Magazine("Life", 1999, "short descr 2", 746204676, "life@gmail.com", 5);

            //magazine1.Employee_count += 2;
            //magazine2.Employee_count += 7;

            //magazine1.ShowInf();
            //magazine2.ShowInf();

            //if(magazine1 == magazine2 )
            //    Console.WriteLine("Magazines have equal amount of employees");
            //else
            //    Console.WriteLine("Magazines have different amount of employees");

            //if (magazine1 > magazine2)
            //    Console.WriteLine("Magazine 1 has more employees");
            //else
            //    Console.WriteLine("Magazine 2 has more employees");

            #endregion

            #region 2 Task
            //Shop shop1 = new Shop("Grocery", "Baker St", "short descr", 562874785, "groceryincity@gmail.com", 10);
            //Shop shop2 = new Shop("Flower", "Neddle St", "short descr 2", 746204676, "flowers@gmail.com", 5);

            //shop1.Square += 3;
            //shop2.Square -= 5;

            //shop1.ShowInf();
            //shop2.ShowInf();

            //if (shop1 == shop2)
            //    Console.WriteLine("Shops have equal square");
            //else
            //    Console.WriteLine("Shops have different square");

            //if (shop1 > shop2)
            //    Console.WriteLine("Shop 1 has more square");
            //else
            //    Console.WriteLine("Shop 2 has more square");

            #endregion

            #region 3 Task

            BooksToRead book = new BooksToRead();
            book.ShowList();
            book += "New One";
            book.ShowList();

            book -= 2;
            book.ShowList();

            book.CheckBook("1984");

            #endregion
        }

    }
}