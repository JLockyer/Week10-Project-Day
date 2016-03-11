using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay_1
{
    class Magazine : Resources
    {
        public override void CheckOut()
        {
            Program exit = new Program();
            Console.WriteLine("Would you like to check the title out? (y/n)");
            string user = Console.ReadLine().ToString();
            string returnDate = DateTime.Now.AddDays(2).ToString();
            if (user == "y")
            {
                Status = "Checked out";
                Console.WriteLine("This title is due in by: " + returnDate);
                Console.WriteLine("{0} has been checked out", Title);
            }
            if (user == "n")
            {
                exit.Exit();
            }
        }
    }
}
