using UniversityBL.Models;
using UniversityBL.Repositories;

namespace UniversityBL.Services.Implements
{
    public class CourseService : GenericService<Course>, ICourseService
    {
        public CourseService(ICourseRepository courseRepository) : base(courseRepository)
        {

        }
    }
}
