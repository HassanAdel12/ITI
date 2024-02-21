using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_3
{
    struct Student
    {
        #region Data Fields
        int id;
        string name;
        int age;
        string address;
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

        public void SetAddress(string _address)
        {
            address = _address;
        }
        public string GetAddress()
        {
            return address;
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
            Console.WriteLine($"Address :{address}");
        }

        public string PrintV2()
        {
            return $"ID : {id} :Name : {name} :Age : {age} :Address : {address}";
        }
        #endregion
    }
}
