using Onion.Domain.Entities;
using Onion.Domain.Services;
using System.Collections.Generic;

namespace Onion.Infratructure.MockDb.Services
{
    public class MockStudentsDbService : IStudentsService
    {
        private static ICollection<Student> _students = new List<Student>
        {
            new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski"},
            new Student{IdStudent=2, FirstName="Anna", LastName="Malewski"},
            new Student{IdStudent=3, FirstName="Andrzej", LastName="Andrzejewicz"}
        };

        public bool AddStudent(Student newStudent)
        {
            _students.Add(newStudent);
            return true;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
