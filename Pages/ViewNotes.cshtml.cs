using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AT_CSharp_DB.Pages
{
    public class ViewNotesModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "A mensagem é obrigatória.")]
        public string mensagem {  get; set; }

        public List<string> listaDeMensagens { get; set; } = new List<string>();

        public string diretorioMensagens = "c:\\Users\\thail\\source\\repos\\AT_CSharp_DB\\wwwroot\\files";
        public void OnGet()
        {
            CarregarNotas();
        }

        public IActionResult OnPost()
        {
            if (!Directory.Exists(diretorioMensagens))
            {
                Directory.CreateDirectory(diretorioMensagens);
                
            }
            var nomeArquivo = $"{DateTime.Now:yyyyMMdd-HHmmss}.txt";
            var caminhoArquivo = Path.Combine(diretorioMensagens, nomeArquivo);

            System.IO.File.WriteAllText(caminhoArquivo, mensagem);
            CarregarNotas();
            return Page();

        }

        public void CarregarNotas()
        {
            if (Directory.Exists(diretorioMensagens))
            {
                var arquivos = Directory.GetFiles(diretorioMensagens, "*.txt");

                foreach (var arquivo in arquivos)
                {
                    try
                    {
                        var mensagemAtual = System.IO.File.ReadAllText(arquivo);
                        listaDeMensagens.Add(mensagemAtual);
                    } catch(Exception e)
                    {
                        listaDeMensagens.Add($"{e.Message}");
                    }
                }
            }
        }
    }
}
