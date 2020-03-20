
using System.Collections.Generic;

namespace Onion.Domain.Entities
{
    public class StudentGroup
    {
        public int IdStudentGroup { get; set; }
        public string Number { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
