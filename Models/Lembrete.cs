using System.ComponentModel.DataAnnotations;

namespace pomboCorreio.Models
{
    public class Lembrete
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo IdUsuario é obrigatório")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "O campo nome não pode ultrapassar 40 caracteres", ErrorMessageResourceType = typeof(string))]

        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo descrição não pode ultrapassar 100 caracteres", ErrorMessageResourceType = typeof(string))]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo data lembrete é obrigatório")]

        public DateTime Dt_Lembrete { get; set; }
        [Required(ErrorMessage = "O campo o horário é obrigatório")]

        public DateTime Hr_Lembrete { get; set; }
        
    }
}
