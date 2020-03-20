using Onion.Domain.Entities;
using Onion.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Infrastructure.SqlServerDb.Services
{
    public class SqlServerStudentsDbService : IStudentsService
    {
        private SqlServerStudentsDbContext _context;

        public SqlServerStudentsDbService(SqlServerStudentsDbContext context)
        {
            _context = context;
        }

        public bool AddStudent(Student newStudent)
        {
            _context.Students.Add(newStudent);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _context.Students.ToList();

            return students;
        }
    }
}
