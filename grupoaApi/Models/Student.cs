using System.ComponentModel.DataAnnotations;

namespace grupoaApi.Context
{
    public class Student
    {
        //chave primária
        [Key]
        public int Ra { get; init; }

        public string? Cpf { get; init; }

        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}