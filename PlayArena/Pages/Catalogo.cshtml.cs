using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using PlayArenaWAPI.Controllers;
using System.Text.Json;

namespace PlayArena.Pages
{
    public class CatalogoModel : PageModel
    {
        public List<JogoModel> listajogo { get; set; }

        public CatalogoModel()
        {
            listajogo = new List<JogoModel>();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                var client = new HttpClient();

                var url = "https://localhost:7106/api/Jogo/api/jogo/listar";

                var resposta = await client.GetAsync(url);

                var conteudo = await resposta.Content.ReadAsStringAsync();

                listajogo = JsonSerializer.Deserialize<List<JogoModel>>(conteudo);
            }
            catch (Exception)
            {

                throw;
            }

            return Page();
        }
    }
}
