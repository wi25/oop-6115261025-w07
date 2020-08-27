using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w07
{
    class Lecturer : Person
    {
        private double portfolio;
        private double project;
        private double research;

        public double Portfolio{ get => portfolio; set => portfolio = value; }
        public double Project{ get => project; set => project = value; }
        public double Research{ get => research; set => research = value; }
        public Lecturer(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessFromAdmin, double po,double pj,double re)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.Portfolio = po;
            this.Project = pj;
            this.Research = re;
        }
        public double calculateSalaryRaise()
        {
            double score= this.IntentYearlyActivity +this.Portfolio +this.Project + this.Research + this.AssessedFromAdmin;
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
                salaryRaise = Salary * 0.02; 
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.025; 
            }
            else if (score > 90)
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
