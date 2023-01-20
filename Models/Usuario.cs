using System.ComponentModel.DataAnnotations;

namespace pomboCorreio.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo nome não pode ultrapassar 50 caracteres", ErrorMessageResourceType = typeof(string))]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo sobrenome é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo sobrenome não pode ultrapassar 50 caracteres", ErrorMessageResourceType = typeof(string))]
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo apelido é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo apelido não pode ultrapassar 20 caracteres", ErrorMessageResourceType = typeof(string))]
        public string Apelido { get; set; }
        public string Senha { get; set; }


    }
}
