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
		public RequisitoModel requisitos { get; set; }
		public ImagemJogoModel imagemJogo { get; set; }

		[BindProperty]
        public int Id { get; set; }

		public TelajogoModel()
		{
			jogo = new JogoModel();
			requisitos = new RequisitoModel();
			imagemJogo = new ImagemJogoModel();
		}

		public async Task<IActionResult> OnGetAsync(int Id)
		{
			try
			{
				var client = new HttpClient();

                var url = $"https://localhost:7106/api/Jogo/api/jogo/listar/{Id}";
				
				var resposta = await client.GetAsync(url);

				var conteudo = await resposta.Content.ReadAsStringAsync();

				jogo = JsonSerializer.Deserialize<JogoModel>(conteudo);

				var clientRequisito = new HttpClient();

				var urlRequisito = $"https://localhost:7106/api/Jogo/api/jogo/RequisitoSistema/{Id}";

				var respostaRequisito = await client.GetAsync(urlRequisito);

				var conteudoRequisito = await respostaRequisito.Content.ReadAsStringAsync();

				requisitos = JsonSerializer.Deserialize<RequisitoModel>(conteudoRequisito);

				var clientImagem = new HttpClient();

				var urlImagem = $"https://localhost:7106/api/Jogo/api/imagem/ImagemJogo/{Id}";

				var respostaImagem = await client.GetAsync(urlImagem);

				var conteudoImagem = await respostaImagem.Content.ReadAsStringAsync();

				imagemJogo = JsonSerializer.Deserialize<ImagemJogoModel>(conteudoImagem);
			}
			catch (Exception)
			{

				throw;
			}
			return Page();
		}
	}
}
