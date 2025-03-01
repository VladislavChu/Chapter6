using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        //data fields
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSsn;
        protected EmployeePayTypeEnum _payType;

        //properties
        public string Name
        {
            get
            {
                if (EmpName == null)
                {
                    return "There is no values! null!";
                }
                else
                {
                    return EmpName;
                }
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }
        public int Id
        {
            //get { return _empId; }
            //record only!
            set { EmpId = value; }
        }
        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }
        public int Age
        {
            get => EmpAge;
            set => EmpAge = value;
        }
        public string SocialSecurityNumber
        {
            get => EmpSsn;
            private set => EmpSsn = value;
        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        //ctors
        public Employee() { }
        public Employee(string name, int id, float pay) : this (name, id, pay, 0, "", EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int id, float pay, int age, string ssn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Pay = pay;
            Age = age;
            SocialSecurityNumber = ssn;
            PayType = payType;
        }
    }
}
