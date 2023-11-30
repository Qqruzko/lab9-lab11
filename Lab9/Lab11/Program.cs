using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance distance1 = new Distance();
            Distance distance2 = new Distance();
            Distance distminus = new Distance();
            Distance distplus = new Distance();

            Console.WriteLine("Enter foot 1");
            distance1.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter foot 2");
            distance2.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches 1");
            distance1.inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches 2");
            distance2.inches = double.Parse(Console.ReadLine());

            distminus.feet = distance1.feet - distance2.feet;
            distminus.inches= distance1.inches - distance2.inches;
            distplus.feet = distance1.feet + distance2.feet;
            distplus.inches = distance1.inches - distance2.inches;
            distplus.sravnit(distance1, distance2);
            distplus.sravnit(distance1.feet, distance2.feet);
            Console.WriteLine(distplus);
            Console.WriteLine(distminus);
            Console.Read();


        }
    }
}
