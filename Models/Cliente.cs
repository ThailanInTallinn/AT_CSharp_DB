using System.ComponentModel.DataAnnotations;

namespace AT_CSharp_DB.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [MinLength(10, ErrorMessage = "O nome do cliente deve ter pelo menos 3 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email do cliente é obrigatório.")]
        [MinLength(15, ErrorMessage= "O email do cliente deve conter pelo menos 15 caracteres.")]
        public string Email { get; set; } = string.Empty ;

        [Required]
        public EnderecoCliente EnderecoCliente { get; set; }
        
        public List<Reserva> Reservas { get; set; }

    }
}
