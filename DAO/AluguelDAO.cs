using DAO.Interface;
using Entity;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class AluguelDAO : BaseDAO<AluguelEntity>, IAluguelDAO
	{
		private readonly ApplicationDbContext _context;

		public AluguelDAO(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public void Casting()
		{
			var model = new AluguelModel();
			var entity = new AluguelEntity();
			model = (AluguelModel)entity;
		}
	}
}
