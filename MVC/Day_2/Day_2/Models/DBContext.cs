using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_2.Models
{
    public class DBContext
    {
        public static List<Department> Deparments = new List<Department>()
        {
            new Department() { Id = 1, Name = "Department 1",Title = "Title 1"},
            new Department() { Id = 2, Name = "Department 2",Title = "Title 2"},
            new Department() { Id = 3, Name = "Department 3",Title = "Title 3"},
            new Department() { Id = 4, Name = "Department 4",Title = "Title 4"},
        };
    }
}