using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Distance
    {
        public int feet { get; set; }
        public double inches { get; set; }
        public override string ToString()
        {
            return String.Format("{0} - {1}",feet,inches);
        }
        public void sravnit(object a, object b)
        {
            bool c = a == b;
            Console.WriteLine("Objects are the same: {0}",c);
            
        }
        public void sravnit(int a, int b)
        {
            bool c = a == b;
            Console.WriteLine("Feet 1 and 2 are the same: {0}", c);
            
        }
    }
}
