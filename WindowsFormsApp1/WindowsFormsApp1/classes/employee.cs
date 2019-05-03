using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes
{
    class Employee : user
    {
        public static int id;

        public string Position{ get; set; }
        public double Salary{ get; set; }

        public  int getId()
        { 


            id++;
            return id;
        }

       //public string getPosition()
       // {
       //     return position;
       // }
       // public void setPosition(string pos)
       // {
       //     position = pos;
       // }

       // public double getSalary()
       // {
       //     return salary;
       // }
       // public void setSalary(double sal)
       // {
       //    salary = sal;
       // }
    }


        
    }

