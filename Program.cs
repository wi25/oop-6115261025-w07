using System;

namespace oop_6115261025_w07
{
    class Program
    {
            static void Main(string[] args)
            {
                Person p1 = new Person("Nitat", "Ninchawee", 20000, 10, 2, 2);
                Lecturer l1 = new Lecturer("Nitat", "Ninchawee", 20000, 10, 20,20,30,20,10);
                Console.WriteLine(p1.ToString());
                Console.WriteLine(l1.ToString());
               
        }

     }
 }

