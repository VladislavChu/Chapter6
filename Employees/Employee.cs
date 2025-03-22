using System;
using System.Xml.Linq;

namespace Employees
{
    abstract partial class Employee
    {

        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public BenefitPackage Benefits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        }

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }


        }

        //methods
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }


        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
            
            /*
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commmission } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
            */
            
        }
            
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SSN: {EmpSsn}");
        }
    }
}
