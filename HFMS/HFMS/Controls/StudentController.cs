using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFMS.Controls
{
    class StudentController
    {
        public int deleteStudent(string rollno)
        {
            return Model.ModelStudent.deleteStudent(rollno);
        }
        public int updateStudent(Student obj)
        {
            return Model.ModelStudent.updateStudent(obj);
        }
        public int addStudent(Student obj)
        {
            return Model.ModelStudent.addStudent(obj);
        }
        public Student getStudent(string rollno)
        {
            return Model.ModelStudent.getStudent(rollno);
        }
    }
}
