using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts) : base (fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried) 
        {
            StockOptions = numbOfOpts;
        }

        public Manager()
        {
            
        }

        //Override method

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            //вывод кол-ва фондовых опционов
            Console.WriteLine($"Number of Stock Options: {StockOptions}");
        }
    }
}
