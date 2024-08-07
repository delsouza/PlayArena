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
	public class ImagemJogoDAO : BaseDAO<ImagemJogoEntity>, IImagemJogoDAO
	{
		private readonly ApplicationDbContext _db;

		public ImagemJogoDAO(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Casting()
		{
			var model = new ImagemJogoModel();
			var entity = new ImagemJogoEntity();
			model = (ImagemJogoModel)entity;
		}
	}
}
