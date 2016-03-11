using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay_1
{
    abstract class Resources
    {
        private string title;
        private int isbnNum = isbnGen();
        private int length;
        private string status;
        private bool check = false;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int ISBN { get; set; }
        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public bool Check
        {
            get { return this.check; }
            set { this.check = value; }
        }

        public static int isbnGen()
        {
            Random rand = new Random();
            int isbnRand = rand.Next(100000000, 1000000000);
            return isbnRand;
        }
        public virtual void ViewTitle()
        {
            Console.WriteLine(Title);
            Console.WriteLine(ISBN = isbnGen());
            Console.WriteLine(Length + " pages");
            Console.WriteLine(Status);
        }

        public virtual void AddTitle()
        {
            Console.WriteLine("What is the name of the Title?");
            Title = Console.ReadLine().ToLower();
            if (Check)
            {
                Status = "Available";
                Console.WriteLine(Title, ": is", Status);
            }
            Console.WriteLine("Enter page number of title: ");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} pages.", Length);
        }

        public virtual void CheckOut()
        {
            Console.WriteLine("Would you like to check the title out? (y/n)");
            string user = Console.ReadLine().ToString();
            string returnDate = DateTime.Now.AddDays(3).ToString();
            if (user == "y")
            {
                Status = "Checked out";
                Console.WriteLine("This title is due in by: " + returnDate);
                Console.WriteLine("{0} has been checked out", Title);
            }
            if (user == "n")
            {
                Console.WriteLine("Have a good day!");
            }
        }

        public virtual void CheckIn()
        {
            Program exit = new Program();
            Console.WriteLine("Would you like to return the title? (y/n)");
            string user = Console.ReadLine().ToLower();
            if (user == "y")
            {
                Status = "Available";
                Console.WriteLine("{0} has been checked back in!", Title);
            }
            if (user == "n")
            {
                exit.Exit();
            }
        }

    }
}
