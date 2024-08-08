using DAO.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using PlayArenaWAPI.Controllers;
using System.Text.Json;
using Business.PlayArena.Interface;

namespace PlayArena.Pages
{
    public class TelajogoModel : PageModel
    {
		private readonly IRequisitoSistemaBusiness _requisitoSistemaBusiness;
		private readonly IImagemJogoBusiness _imagemJogoBusiness;
		private readonly IJogoBusiness _jogoBusiness;

		public JogoModel jogo { get; set; }
		public RequisitoModel requisitos { get; set; }
		public ImagemJogoModel imagemJogo { get; set; }

		[BindProperty]
        public int Id { get; set; }

		public TelajogoModel(IRequisitoSistemaBusiness requisitoSistemaBusiness, IImagemJogoBusiness imagemJogoBusiness, IJogoBusiness jogoBusiness)
		{
			jogo = new JogoModel();
			requisitos = new RequisitoModel();
			imagemJogo = new ImagemJogoModel();
			_requisitoSistemaBusiness = requisitoSistemaBusiness;
			_imagemJogoBusiness = imagemJogoBusiness;
			_jogoBusiness = jogoBusiness;
		}

		public async Task<IActionResult> OnGetAsync(int Id)
		{
			try
			{
				requisitos = _requisitoSistemaBusiness.ObterRequisitoPorIdJogo(Id);
				imagemJogo = _imagemJogoBusiness.ObterImagemJogoPorId(Id);
				jogo = _jogoBusiness.ObterJogoPorId(Id);

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
