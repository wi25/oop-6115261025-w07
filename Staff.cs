using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w07
{
    class Staff :Person
    {
        private double work;
        public double Work{ get => work; set => work = value; }
       
        public Staff(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessFromAdmin, double w)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.Work = w;
        }
        public double calculateSalaryRaise()
        {
            double score = this.IntentYearlyActivity + this.Work + this.AssessedFromAdmin;
            double salaryRaise = 0;

            if (score < 70)
            {
                return 0;
            }
            else if (score <= 80)
            {
                salaryRaise = Salary * 0.01;
            }
            else if (score <= 85)
            {
                salaryRaise = Salary * 0.015;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.02;
            }
            else if (score > 95)
            {
                salaryRaise = Salary * 0.025;
            }
            else if (score > 95)
            {
                salaryRaise = Salary * 0.03;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + "Salary Raise : " +
                this.calculateSalaryRaise();
        }
    }
}
