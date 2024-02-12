using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Teacher
    {

        public int ID { get; set; }

        [ForeignKey("School")]
        public int SchoolID { get; set; }

        public School School { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string NationalID { get; set; }

        public int Code { get; set;}

        public string Job { get; set; }

        public string Phone { get; set; }

        public string Qualification { get; set; }

        public DateTime QualificationDate { get; set; }

        public DateTime HiringDate { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

        public ICollection<TeacherTransfere> teacherTransferes { get; set; }

    }
}
