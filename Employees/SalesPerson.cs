using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson (string fullName, int age, int empId, float currPay, string ssn, int numbOfSales) : base (fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commmission)
        {
            SalesNumber = numbOfSales;
        }

        public SalesPerson()
        {
            
        }

        //Override method

        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            // Вывод кол-ва продаж
            Console.WriteLine($"Number of Sales: {SalesNumber}");
        }

    }
}
