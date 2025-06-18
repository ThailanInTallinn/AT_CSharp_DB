using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AT_CSharp_DB.Pages.Create
{
    public class CreateCidadeModel : PageModel
    {

        public string mensagem { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "O nome da cidade � obrigat�rio")]
        [MinLength(3, ErrorMessage = "O nome da cidade deve ter, no m�nimo, 3 caracteres")]
        public string nomeCidade { get; set; } = string.Empty;

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                mensagem = $"Cidade {nomeCidade} cadastrada com sucesso.";
                return Page();
            } else
            {
                mensagem = "Revise os erros no formul�rio antes de enviar.";
                return Page();
            }

        }
    }
}
