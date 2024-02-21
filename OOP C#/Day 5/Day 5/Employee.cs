using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Employee
    {
        #region Fields
        private int id;
        private string name;
        private int age;
        decimal salary;
        #endregion

        #region ctor
        public Employee()
        {
            Id = 1;
            Name = "Hassan";
            Age = 26;
            Salary = 20_000;
        }
        public Employee(int _id, string _name, int _age, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Age = _age;
            Salary = _salary;
        }


        #endregion

        #region Property
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
        #endregion

        #region Print
        public string Print()
        {
            return $"{id}:{name}:{age}:{salary}";
        }
        #endregion
    }
}
