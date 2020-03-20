
using Onion.Domain.Validators;
using System.ComponentModel.DataAnnotations;

namespace Onion.Domain.Entities
{
    [MetadataType(typeof(StudentValidationMetadata))]
    public partial class Student
    {
        public int IdStudent { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public StudentGroup StudentGroup { get; set; }
    }
}
