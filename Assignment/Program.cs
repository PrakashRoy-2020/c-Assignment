using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            PropClass obj = new PropClass();
            obj.Date = Convert.ToInt32(Console.ReadLine());
            obj.Month = Convert.ToInt32(Console.ReadLine());
            obj.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}/{1}/{2}",obj.Date,obj.Month,obj.Year);

        }
    }
}
