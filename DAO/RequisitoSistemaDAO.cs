using DAO.Interface;
using Entity;
using Infra.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class RequisitoSistemaDAO : BaseDAO<RequisitoEntity>, IRequisitoSistemaDAO
	{
		private readonly ApplicationDbContext _db;

		public RequisitoSistemaDAO(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Casting()
		{
			var model = new RequisitoModel();
			var entity = new RequisitoEntity();
			model = (RequisitoModel)entity;
		}
	}
}
