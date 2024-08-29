using Business.PlayArena.Interface;
using DAO;
using DAO.Interface;
using Entity;
using Infra.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena
{
	public class AluguelBusiness : IAluguelBusiness
	{
		private readonly IAluguelDAO _aluguelDAO;
		private readonly ApplicationDbContext _context;

		public AluguelBusiness(IAluguelDAO aluguelDAO, ApplicationDbContext context)
		{
			_aluguelDAO = aluguelDAO;
			_context = context;
		}

		public AluguelModel ObterAluguelPorId(int IdAluguel)
		{
			return new AluguelModel ();
		}

		public async Task CadastrarAluguel(AluguelModel aluguel)
		{
			var aluguelEntity = new AluguelEntity(aluguel.Id_Jogo, aluguel.Id_Cliente);

			aluguelEntity.DataAluguel = DateTime.Now;

			_aluguelDAO.Criar(aluguelEntity);

			await _context.SaveChangesAsync();
		}
	}
}
