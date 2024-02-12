using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class TeacherTransfere
    {
        public int ID { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey("FromSchool")]
        public int? FromSchoolID { get; set; }

        public School FromSchool { get; set; }

        [ForeignKey("ToSchool")]
        public int? ToSchoolID { get; set; }

        public School ToSchool { get; set; }

        public DateTime Date { get; set; }

        public void Transfere() 
        { 
            Data context = new Data();
            if (this.FromSchoolID == context.Teachers.Where(t => t.ID == this.TeacherID)
                .Select(t => t.SchoolID).FirstOrDefault())
            {
                Teacher teacher = context.Teachers.Where(t => t.ID == this.TeacherID).FirstOrDefault();
                teacher.SchoolID = ToSchoolID.Value;
                context.TeacherTransferes.Add(this);
            }
            context.SaveChanges();
        }

    }
}
