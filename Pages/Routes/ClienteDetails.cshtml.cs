using AT_CSharp_DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT_CSharp_DB.Routes
{
    public class ClienteDetailsModel : PageModel
    {
        public List<AT_CSharp_DB.Models.Cliente> listaDeClientes = new List<Models.Cliente>();

        public AT_CSharp_DB.Models.Cliente clienteSelecionado { get; set; }

        private void PreencherClientes()
        {
            var cliente = new Cliente
            {
                Nome = "Thailan Gouvea",
                ID = 1,
                Email = "thailangm@gmail.com",
                EnderecoCliente = new EnderecoCliente
                {
                    logradouro = "Rua Antenor de Carvalho",
                    cidade = "Rio de Janeiro",
                    pais = "Brasil"
                }
            };

            listaDeClientes.Add(cliente);
        }

        public async Task OnGetAsync(int id)
        {
            PreencherClientes();
            AT_CSharp_DB.Models.Cliente cliente = new Models.Cliente();
            

       
            foreach (var item in listaDeClientes)
            {
                if (item.ID == id)
                {
                    clienteSelecionado = item;
                }
            }
        }
    }
}