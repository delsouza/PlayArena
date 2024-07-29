using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using System.Text.Json;

namespace PlayArena.Pages
{
    public class CatalogoModel : PageModel
    {
        public List<JogoModel> listajogo  { get; set; }

        public async void OnGetAsync()
        {
            var client = new HttpClient();

            var url = "https://localhost:7106/api/Jogo/api/jogo/listar";

            var resposta = await client.GetAsync(url);

            resposta.EnsureSuccessStatusCode();

            var conteudo = await resposta.Content.ReadAsStringAsync();

            listajogo = JsonSerializer.Deserialize<List<JogoModel>>(conteudo);
        }
    }
}
