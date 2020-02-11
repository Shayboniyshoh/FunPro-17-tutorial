using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT.DAL
{
    public class CourseList
    {
        public List<Course> GetAllCourses()
        {
            return new CourseManager().GetAll();
        }
    }
}
