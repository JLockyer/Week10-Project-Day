using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay_1
{
    class DVD : Resources
    {
        public override void ViewTitle()
        {
            Console.WriteLine(Title);
            Console.WriteLine(ISBN = isbnGen());
            Console.WriteLine(Length + " minutes");
            Console.WriteLine(Status);
        }
        public override void AddTitle()
        {
            Console.WriteLine("What is the name of the Title?");
            Title = Console.ReadLine().ToLower();
            if (Check)
            {
                Status = "Available";
                Console.WriteLine(Title, ": is", Status);
            }
            Console.WriteLine("Enter number of minutes of title: ");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} minutes.", Length);
        }
    }
}
