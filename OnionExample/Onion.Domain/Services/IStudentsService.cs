using Onion.Domain.Entities;
using System.Collections.Generic;

namespace Onion.Domain.Services
{
    public interface IStudentsService
    {
        public IEnumerable<Student> GetStudents();
        public bool AddStudent(Student newStudent);
    }
}
