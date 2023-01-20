using System.ComponentModel.DataAnnotations;

namespace pomboCorreio.Models
{
    public class Login
    {
        [Required(ErrorMessage = "O email senha é obrigatório")]
        [StringLength(6, MinimumLength = 2, ErrorMessage = "O email senha não pode ultrapassar 50 caracteres", ErrorMessageResourceType = typeof(string))]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [StringLength(6, MinimumLength = 2, ErrorMessage = "O campo senha não pode ultrapassar 50 caracteres", ErrorMessageResourceType = typeof(string))]
        public string Senha { get; set; }
    }
}
