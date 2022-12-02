using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil a = new ExcelentPupil();
            GoodPupil b = new GoodPupil();
            BadPupil c = new BadPupil();

            ClassRoom class1 = new ClassRoom(a, b, c, a);
            Console.Read();
        }
    }
}
