using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PropClass
    {
        private int date;
        private int month;
        protected internal int year;

        public int Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    date = value;
                }
                else
                {
                    
                    Console.WriteLine("in b/w 1 to 31");
                }
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if ((value >= 1) && (value <= 12))
                {
                    month = value;
                }
                else
                {
                    
                    Console.WriteLine("in b/w 1 to 12");
                }
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if ((value >= 2018) && (value <= 2020))
                {
                    year = value;
                }
                else
                {
                    
                    Console.WriteLine("in b/w 2018 to 2020");
                }
            }
        }
    }
    class AssignmentLib
    {
       
    }
    //class PropClass
    //{
    //}
}
