using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class School
    {
        public int ID { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        
        [InverseProperty("FromSchool")]
        public ICollection<TeacherTransfere> TeacherTransfereFromSchool { get; set; }

        [InverseProperty("ToSchool")]
        public ICollection<TeacherTransfere> TeacherTransfereToSchool { get; set; }
    }
}
