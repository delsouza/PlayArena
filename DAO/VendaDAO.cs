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
	public class VendaDAO : BaseDAO<VendaEntity>, IVendaDAO
	{
		private readonly ApplicationDbContext _db;

		public VendaDAO(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Casting()
		{
			var model = new VendaModel();
			var entity = new VendaEntity();
			model = (VendaModel)entity;
		}
	}
}
