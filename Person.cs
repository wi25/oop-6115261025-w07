﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w07
{
    class Person
    {
        private string name;
        private string lastname;
        private int salary;
        private int workedYear;
        private int intentYearlyActivity;
        private double assessedFromAdmin;


        public Person()
        {
        }

        public Person(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessedFromAdmin)
        {
            this.name = name;
            this.lastname = lastname;
            this.salary = salary;
            this.workedYear = workedYear;
            this.intentYearlyActivity = intentYearlyActivity;
            this.assessedFromAdmin = assessedFromAdmin;
        }

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Salary { get => salary; set => salary = value; }
        public int WorkedYear { get => workedYear; set => workedYear = value; }
        public int IntentYearlyActivity { get => intentYearlyActivity; set => intentYearlyActivity = value; }
        public double AssessedFromAdmin { get => assessedFromAdmin; set => assessedFromAdmin = value; }

        protected double assessMark()
        {
            double assessMark = 0;
            return assessMark;
        }
       

        public override string ToString()
        {
            return this.Name + " " + this.Lastname + " salary : " + this.Salary;
        }
    }
}
