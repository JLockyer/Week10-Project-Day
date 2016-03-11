using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Menu();
        }

        public void Menu()
        {
            DVD dvd = new DVD();
            Book book = new Book();
            Magazine mag = new Magazine();
            Program pro = new Program();
            List<string> menu = new List<string> { "1. Dvd", "2. Book", "3. Magazine", "4. Exit" };

            Console.WriteLine("*****Check Out Library System*****");
            Console.WriteLine("What would you like to check out?");
            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }

            string menuOptions = Console.ReadLine().ToLower();

            switch (menuOptions)
            {
                case "1":
                case "dvd":
                    dvd.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    dvd.AddTitle();
                    dvd.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    dvd.CheckOut();
                    dvd.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    dvd.CheckIn();
                    dvd.ViewTitle();
                    break;
                case "2":
                case "book":
                    book.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    book.AddTitle();
                    book.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    book.CheckOut();
                    book.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    book.CheckIn();
                    book.ViewTitle();
                    break;
                case "3":
                case "magazine":
                    mag.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    mag.AddTitle();
                    mag.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    mag.CheckOut();
                    mag.ViewTitle();
                    Console.ReadKey();
                    Console.Clear();
                    mag.CheckIn();
                    mag.ViewTitle();
                    break;
                case "4":
                case "exit":
                    pro.Exit();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        public void Exit()
        {
            Console.WriteLine("Thank you have a nice day!");
            Console.ReadKey();
        }

    }
}
