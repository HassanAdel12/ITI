using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_3
{
    class Employee
    {
        #region Data Fields
        int id;
        string name;
        int age;
        decimal salary;
        string email;
        string password;
        #endregion

        #region Setters and Getters
        public void SetId(int _id)
        {
            id = _id;
        }
        public int GetId()
        {
            return id;
        }

        public void SetName(string _name)
        {
            name = _name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge(int _age)
        {
            age = _age;
        }
        public int GetAge()
        {
            return age;
        }

        public void SetSalary(decimal _salary)
        {
            salary = _salary;
        }
        public decimal GetSalary()
        {
            return salary;
        }

        public void SetPassword(string _password)
        {
            password = _password;
        }
        
        public void SetEmail(string _email)
        {
            email = _email;
        }
        #endregion

        #region Print 
        
        public void PrintV1()
        { 
            Console.WriteLine($"ID :{id}");
            Console.WriteLine($"Name :{name}");
            Console.WriteLine($"Age :{age}");
            Console.WriteLine($"Salary :{salary:c}");
        }
        
        public string PrintV2()
        {
            return $"ID : {id} :Name : {name} :Age : {age} :Salary : {salary:c}";
        }
        #endregion

    }
}
