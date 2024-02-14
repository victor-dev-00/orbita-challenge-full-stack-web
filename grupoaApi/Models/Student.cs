using System.ComponentModel.DataAnnotations;

namespace grupoaApi.Context
{
    /// <summary>
    /// Represents a student entity.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or initializes the Registration Academic (RA) number.
        /// </summary>
        [Key]
        public int Ra { get; init; }

        /// <summary>
        /// Gets or initializes the CPF (taxpayer ID) of the student.
        /// </summary>
        public string? Cpf { get; init; }

        /// <summary>
        /// Gets or sets the email of the student.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string? Name { get; set; }
    }
}