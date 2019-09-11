using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3class
{
    public class Participant
    {
        private int _empID;
        private string _name;
        private float _foundationMarks;
        private float _webBasicMarks;
        private float _dotNetMarks;
        private float _obtainedMarks;
        private float _percentage;
        const float TotalMarks = 300;
        static string CompanyName;

        public int EmpID
        {
            get => _empID;
            set
            {
                if (value.ToString().Length == 4)
                    _empID = value;

            }
        }
        public string Name { get => _name; set => _name = value; }
        public float FoundationMarks
        {
            get => _foundationMarks;
            set
            {
                if (value >= 0 && value <= 100)
                    _foundationMarks = value;
            }
        }
        public float WebBasicMarks
        {
            get => _webBasicMarks;
            set
            {
                if (value >= 0 && value <= 100)
                    _webBasicMarks = value;

            }
        }
        public float DotNetMarks
        {
            get => _dotNetMarks;
            set
            {
                if (value >= 0 && value <= 100)
                    _dotNetMarks = value;

            }
        }
        public float ObtainedMarks
        {
            get => _obtainedMarks;
            set
            {
                if (value >= 0 && value <= 300)
                    _obtainedMarks = value;
            }
        }
        public float Percentage
        {
            get => _percentage;
            set
            {
                if (value >= 0 && value <= 100)
                    _percentage = value;
            }
        }

        public Participant()
        {

        }

        public Participant(int id, string name, float f_marks, float wb_marks, float dn_marks)
        {
            EmpID = id;
            Name = name;
            FoundationMarks = f_marks;
            WebBasicMarks = wb_marks;
            DotNetMarks = dn_marks;
        }
        static Participant()
        {
            CompanyName = "Corporate University";
        }

        public float CalcTotalMarks()
        {
            ObtainedMarks = WebBasicMarks + FoundationMarks + DotNetMarks;
            return ObtainedMarks;
        }
        public void CalcPercentage()
        {
            Percentage = ObtainedMarks / 3;

        }
        public float GetPercentage()
        {
            Percentage = ObtainedMarks / 3;
            return Percentage;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID is: " + EmpID);
            Console.WriteLine("Name is: " + Name);
            Console.WriteLine("Company name is: " + CompanyName);
            Console.WriteLine("Foundation marks is: " + FoundationMarks);
            Console.WriteLine("Web basic marks is: " + WebBasicMarks);
            Console.WriteLine("Dotnet marks is: " + DotNetMarks);
            Console.WriteLine("Obtained marks is: " + ObtainedMarks);
            Console.WriteLine("Percentage is: " + Percentage);

        }


    }
}
