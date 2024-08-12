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
		public List<ImagemJogoModel> imagemJogo { get; set; }

		[BindProperty]
        public int Id { get; set; }

		public TelajogoModel(IRequisitoSistemaBusiness requisitoSistemaBusiness, IImagemJogoBusiness imagemJogoBusiness, IJogoBusiness jogoBusiness)
		{
			jogo = new JogoModel();
			requisitos = new RequisitoModel();
			imagemJogo = new List<ImagemJogoModel>();
			_requisitoSistemaBusiness = requisitoSistemaBusiness;
			_imagemJogoBusiness = imagemJogoBusiness;
			_jogoBusiness = jogoBusiness;
		}

		public async Task<IActionResult> OnGetAsync(int Id)
		{
			try
			{
				requisitos = _requisitoSistemaBusiness.ObterRequisitoPorIdJogo(Id);
				imagemJogo = _imagemJogoBusiness.ListarImagemJogo(Id);
				jogo = _jogoBusiness.ObterJogoPorId(Id);
			}
			catch (Exception)
			{

				throw;
			}
			return Page();
		}
	}
}
