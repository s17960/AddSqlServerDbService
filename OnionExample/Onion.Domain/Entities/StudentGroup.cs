
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Onion.Domain.Entities
{
    public class StudentGroup
    {
        [Key]
        public int IdStudentGroup { get; set; }
        public string Number { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
