using DAO.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using PlayArenaWAPI.Controllers;
using System.Text.Json;
using Business.PlayArena.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Infra.Context;
using Business.PlayArena;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Claims;

namespace PlayArena.Pages
{
    [Authorize]
    public class TelajogoModel : PageModel
    {
		private readonly IRequisitoSistemaBusiness _requisitoSistemaBusiness;
		private readonly IImagemJogoBusiness _imagemJogoBusiness;
		private readonly IJogoBusiness _jogoBusiness;
		private readonly IAluguelBusiness _aluguelBusiness;
		private readonly IVendaBusiness _vendaBusiness;

        public JogoModel jogo { get; set; }
		[BindProperty]
		public AluguelModel aluguel { get; set; }
		[BindProperty]
		public VendaModel venda { get; set; }
		public RequisitoModel requisitos { get; set; }
		public List<ImagemJogoModel> imagemJogo { get; set; }

		[BindProperty]
        public int Id { get; set; }

		public TelajogoModel(IRequisitoSistemaBusiness requisitoSistemaBusiness, IImagemJogoBusiness imagemJogoBusiness, IJogoBusiness jogoBusiness, IAluguelBusiness aluguelBusiness, IVendaBusiness vendaBusiness)
		{
			jogo = new JogoModel();
			requisitos = new RequisitoModel();
			aluguel = new AluguelModel();
			venda = new VendaModel();
			imagemJogo = new List<ImagemJogoModel>();
			_requisitoSistemaBusiness = requisitoSistemaBusiness;
			_imagemJogoBusiness = imagemJogoBusiness;
			_jogoBusiness = jogoBusiness;
			_vendaBusiness = vendaBusiness;
			_aluguelBusiness = aluguelBusiness;
		}

		public async Task<IActionResult> OnGetAsync(int Id)
		{
			try
			{
				requisitos = _requisitoSistemaBusiness.ObterRequisitoPorIdJogo(Id);
				imagemJogo = _imagemJogoBusiness.ListarImagemJogo(Id);
				jogo = _jogoBusiness.ObterJogoPorId(Id);
				venda = _vendaBusiness.ObterVendaPorId(Id);
				aluguel = _aluguelBusiness.ObterAluguelPorId(Id);
			}
			catch (Exception)
			{

				throw;
			}
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(int Id, string servico)
		{
			var jogo = _jogoBusiness.ObterJogoPorId(Id);

			if (jogo != null)
			{
				if (jogo.QuantidadeDisponivel != 0)
				{
					if (servico == "comprar")
					{
						venda.Id_Jogo = venda.Id;
						venda.Id_Cliente = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                        await _vendaBusiness.CadastrarVenda(venda);
					}
					else
					{
						aluguel.Id_Jogo = aluguel.Id;
						aluguel.Id_Cliente = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
						await _aluguelBusiness.CadastrarAluguel(aluguel);
					}
				}
			}

			else
			{
				return RedirectToPage("/Catalogo");
			}

            return RedirectToPage("/Catalogo");
		}
	}
}
