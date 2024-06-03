using UniversityBL.Models;
using UniversityBL.Repositories;

namespace UniversityBL.Services.Implements
{
    public class StudentService : GenericService<Student>
    {
        public StudentService(IGenericRepository<Student> genericRepository) : base(genericRepository)
        {

        }
    }
}
