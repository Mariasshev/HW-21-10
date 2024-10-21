using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_21_10
{
    public class Magazine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Descr { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public int Employee_count { get; set; }

        public Magazine()
        {
            
        }

        public Magazine(string name, int year, string desc, int phone, string mail, int emp)
        {
            this.Name = name;
            this.Year = year;
            this.Descr = desc;
            this.Phone = phone;
            this.Mail = mail;
            this.Employee_count = emp;
        }

        public void AddInf()
        {
            Console.WriteLine("Enter magazine`s name: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter year: ");
            this.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter description: ");
            this.Descr = Console.ReadLine();

            Console.WriteLine("Enter phone: ");
            this.Phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter mail: ");
            this.Mail = Console.ReadLine();

            Console.WriteLine("Enter empoyees amount: ");
            this.Employee_count = int.Parse(Console.ReadLine());
        }

        public void ShowInf()
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"Magazine {this.Name}");
            Console.WriteLine($"Year: {this.Year}");
            Console.WriteLine($"Description: {this.Descr}");
            Console.WriteLine($"Phone number: {this.Phone}");
            Console.WriteLine($"Mail: {this.Mail}");
            Console.WriteLine($"Emplyees amount: {this.Employee_count}");
            Console.WriteLine("----------------");
            Console.WriteLine(" ");
        }

        public static Magazine operator +(Magazine magazine, int a)
        {
            Magazine result = new Magazine();
            result.Employee_count = magazine.Employee_count + a;
            return result;
        }

        public static Magazine operator -(Magazine magazine, int a)
        {
            Magazine result = new Magazine();
            result.Employee_count = magazine.Employee_count - a;
            return result;
        }

        public static bool operator ==(Magazine lhs, Magazine rhs)
        {
            if (lhs.Employee_count == rhs.Employee_count)
                return true;
            else
                return false;
        }

        public static bool operator !=(Magazine lhs, Magazine rhs)
        {
            if (lhs.Employee_count == rhs.Employee_count)
                return false;
            else
                return true;
        }

        public static bool operator <(Magazine lhs, Magazine rhs)
        {
            if (lhs.Employee_count < rhs.Employee_count)
                return true;
            else
                return false;
        }

        public static bool operator >(Magazine lhs, Magazine rhs)
        {
            if (lhs.Employee_count > rhs.Employee_count)
                return true;
            else
                return false;
        }



    }

    public class Shop
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Descr { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public int Square { get; set; }

        public Shop()
        {

        }

        public Shop(string name, string location, string desc, int phone, string mail, int square)
        {
            this.Name = name;
            this.Location = location;
            this.Descr = desc;
            this.Phone = phone;
            this.Mail = mail;
            this.Square = square;
        }

        public void AddInf()
        {
            Console.WriteLine("Enter shop`s name: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter year: ");
            this.Location = Console.ReadLine();

            Console.WriteLine("Enter description: ");
            this.Descr = Console.ReadLine();

            Console.WriteLine("Enter phone: ");
            this.Phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter mail: ");
            this.Mail = Console.ReadLine();

            Console.WriteLine("Enter square: ");
            this.Square = int.Parse(Console.ReadLine());
        }

        public void ShowInf()
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"Shop {this.Name}");
            Console.WriteLine($"Location: {this.Location}");
            Console.WriteLine($"Description: {this.Descr}");
            Console.WriteLine($"Phone number: {this.Phone}");
            Console.WriteLine($"Mail: {this.Mail}");
            Console.WriteLine($"Square: {this.Square}");
            Console.WriteLine("----------------");
            Console.WriteLine(" ");
        }

        public static Shop operator +(Shop shop, int a)
        {
            Shop result = new Shop();
            result.Square = shop.Square + a;
            return result;
        }

        public static Shop operator -(Shop shop, int a)
        {
            Shop result = new Shop();
            result.Square = shop.Square - a;
            return result;
        }

        public static bool operator ==(Shop lhs, Shop rhs)
        {
            if (lhs.Square == rhs.Square)
                return true;
            else
                return false;
        }

        public static bool operator !=(Shop lhs, Shop rhs)
        {
            if (lhs.Square == rhs.Square)
                return false;
            else
                return true;
        }

        public static bool operator <(Shop lhs, Shop rhs)
        {
            if (lhs.Square < rhs.Square)
                return true;
            else
                return false;
        }

        public static bool operator >(Shop lhs, Shop rhs)
        {
            if (lhs.Square > rhs.Square)
                return true;
            else
                return false;
        }

    }


    public class BooksToRead
    {
        private string[] books = new string[10];
        private int count = 0;

        public BooksToRead()
        {
            this.books[0] = "To Kill a Mockingbird";
            this.books[1] = "1984";
            this.books[2] = "Pride and Prejudice";
            this.books[3] = "The Great Gatsby";
            this.books[4] = "Moby Dick";

            this.count = 5;
        }

        public BooksToRead(string[] books)
        {
            
            for (int i = 0; i < this.books.Length; i++)
            {
                this.books[i] = books[i];
                this.count++;
            }
        }

        public void ShowList()
        {
            Console.WriteLine("---------");
            Console.WriteLine("Books List: ");
            for(int i = 0; i < this.count; i++)
            {
                Console.WriteLine($"{i+1}. {this.books[i]}") ;
            }
            Console.WriteLine("---------");
            Console.WriteLine("    ");
        }

        public static BooksToRead operator +(BooksToRead bookList, string name)
        {
            if(bookList.count < bookList.books.Length)
            {
                bookList.books[bookList.count++] = name;
                return bookList;
            }
            else
            {
                Console.WriteLine("Error! There is no place for new book!");
                return null;
            }
            
        }

        public static BooksToRead operator -(BooksToRead bookList, int index)
        {
            if (bookList.count <= bookList.books.Length && (index <= bookList.count) && (index > 0))
            {
                int newIndex = 0;
                int myInd = 0;
                for(int i = 0; i < bookList.count; i++)
                {
                    if(i == index-1)
                    {
                        newIndex = i+1;
                        bookList.books[i] = bookList.books[newIndex];
                        myInd = i+1;
                        newIndex++;
                    }
                    if( i > index)
                    {
                        bookList.books[myInd] = bookList.books[newIndex];
                        myInd++;
                        newIndex++;
                    }
                    
                }
                bookList.count--;
                return bookList;
            }
            else
            {
                Console.WriteLine("Error! There is no such book!");
                return null;
            }

        }

        public string this [int index]
        {
            get
            {
                return this.books[index];
            }
            set
            {
                this.books[index] = value;
            }
        }

        public void CheckBook(string name)
        {
            bool check = false;
            for(int i = 0; i < this.count; i++)
            {
                if (this[i] == name)
                {
                    check = true;
                    Console.WriteLine($"book {name} is in the list!");
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine($"There is no book name {name}");
            }
        }


    }


}
