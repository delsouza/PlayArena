using Business.PlayArena.Interface;
using DAO;
using DAO.Interface;
using Entity;
using Infra.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena
{
	public class VendaBusiness : IVendaBusiness
	{
		private readonly IVendaDAO _vendaDAO;
		private readonly ApplicationDbContext _context;

		public VendaBusiness(IVendaDAO vendaDAO, ApplicationDbContext context) 
		{
			_vendaDAO = vendaDAO;
			_context = context;
		}

		public VendaModel ObterVendaPorId(int idVenda)
		{
			return new VendaModel();
		}

		public async Task CadastrarVenda(VendaModel venda)
		{
			var vendaEntity = new VendaEntity(venda.Id_Jogo, venda.Id_Cliente);

			vendaEntity.DataVenda = DateTime.Now;

			_vendaDAO.Criar(vendaEntity);

			await _context.SaveChangesAsync();
		}

	}
}
