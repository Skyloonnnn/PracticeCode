using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantian object for Regular Student class
            RegularStudent regularStudent = new RegularStudent("Aian cuyos", "BSIT", "IT306");
            //Call the method to display Regular student info
            regularStudent.SectionEnrolled();

            //Instantian object for Irreegular Student class
            IrregularStudent irregularStudent = new IrregularStudent("Sky Loon", "BSIT", 18);
            //Call the method to display Irregular Student info
            irregularStudent.EnrolledSemUnits();

            Console.ReadKey();
        }
    }
}
