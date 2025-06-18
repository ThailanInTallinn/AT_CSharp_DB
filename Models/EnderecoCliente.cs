using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AT_CSharp_DB.Models
{
    [Owned]
    public class EnderecoCliente
    {
        [Required(ErrorMessage = "A rua do cliente é obrigatória.")]
        [MinLength(4, ErrorMessage = "A rua deve conter no mínimo 4 caracteres.")]
        public string logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A cidade do cliente é obrigatória.")]
        [MinLength(3, ErrorMessage = "A cidade deve conter no mínimo 3 caracteres.")]
        public string cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O país do cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "O país deve conter no mínimo 3 caracteres")]
        public string pais { get; set; } = string.Empty;
    }
}
