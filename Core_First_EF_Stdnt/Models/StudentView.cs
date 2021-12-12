using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core_First_EF_Stdnt.Models
{
    public class StudentView
    {
        public List<Student> getAllStudents()
        {
            StudentContext obj = new StudentContext();
            return obj.Students.ToList();
        }
    }
}