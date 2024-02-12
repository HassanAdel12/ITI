using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Department
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<School> Schools { get; set; }
    }
}
