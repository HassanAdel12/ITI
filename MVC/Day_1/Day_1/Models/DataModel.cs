using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Day_1.Models
{
    public class DataModel 
    {
        public static List<Deparment> Deparments = new List<Deparment>()
        {
            new Deparment() { Id = 1, Name = "Deparment 1"},
            new Deparment() { Id = 2, Name = "Deparment 2"},
            new Deparment() { Id = 3, Name = "Deparment 3"},
            new Deparment() { Id = 4, Name = "Deparment 4"},
        };
    }
}