
using System.ComponentModel.DataAnnotations;

namespace Onion.Domain.Entities
{
    public partial class Student
    {
        [Key]
        public int IdStudent { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public StudentGroup StudentGroup { get; set; }
    }
}
