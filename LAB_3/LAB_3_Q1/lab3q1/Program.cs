using System;
using System.Collections.Generic;
using LAB_3class;

namespace LAB_3
{

    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter employee ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter foundation marks:");
            int fm = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter web basic marks:");
            int wbm = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter dotnet marks:");
            int dnm = int.Parse(Console.ReadLine());
            Participant p = new Participant(id, name, fm, wbm, dnm);
            p.CalcTotalMarks();
            p.CalcPercentage();
            p.GetPercentage();
            p.DisplayDetails();
        }
    }
}
