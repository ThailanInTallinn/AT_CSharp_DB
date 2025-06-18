using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT_CSharp_DB.Pages.Reservar
{
    public class IndexModel : PageModel
    {

        public decimal valorTotal { get; set; }
        public void OnGet()
        {
            int numDiarias = 10;
            int valorDiaria = 400;

            

            valorTotal = Models.Reserva.calculaValorReserva(numDiarias, valorDiaria);
        }
    }
}
