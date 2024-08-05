using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using PlayArenaWAPI.Controllers;
using System.Text.Json;

namespace PlayArena.Pages
{
    public class TelajogoModel : PageModel
    {
		public JogoModel jogo { get; set; }

		[BindProperty]
        public int Id { get; set; }

        public TelajogoModel()
		{
			jogo = new JogoModel();
		}

		public async Task<IActionResult> OnGetAsync(int Id)
		{
			try
			{
				var client = new HttpClient();

                var url = $"https://localhost:7106/api/Jogo/api/jogo/listar/{Id}";
				
				var resposta = await client.GetAsync(url);

				var conteudo = await resposta.Content.ReadAsStringAsync();

				//aa

				//jogo = JsonSerializer.Deserialize<JogoModel>(conteudo);

				//var client = new HttpClient();

				//var url = $"https://localhost:7106/api/Jogo/api/jogo/listar/{Id}";

				//var resposta = await client.GetAsync(url);

				//var conteudo = await resposta.Content.ReadAsStringAsync();

				//jogo = JsonSerializer.Deserialize<JogoModel>(conteudo);

				//aa

				//var client = new HttpClient();

				//var url = $"https://localhost:7106/api/Jogo/api/jogo/listar/{Id}";

				//var resposta = await client.GetAsync(url);

				//var conteudo = await resposta.Content.ReadAsStringAsync();

				//jogo = JsonSerializer.Deserialize<JogoModel>(conteudo);
			}
			catch (Exception)
			{

				throw;
			}



			return Page();
		}
	}
}
