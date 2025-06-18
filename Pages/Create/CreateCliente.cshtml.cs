using AT_CSharp_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT_CSharp_DB.Pages.Create
{
    public class CreateClienteModel : PageModel
    {

        [BindProperty]
        public Cliente Cliente { get; set; }

        public string mensagem { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                mensagem = "Revise os erros no formulário antes de enviar.";
                return Page();
            }

            mensagem = "Cliente cadastrado com sucesso.";
            return Page();
        }

        public CreateClienteModel()
        {
            Cliente = new Cliente
            {
                EnderecoCliente = new EnderecoCliente()
            };
        }
    }
}