using Business.Interface;
using DAO;
using DAO.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class RequisitoSistemaBusiness : IRequisitoSistemaBusiness
	{
		private readonly IRequisitoSistemaDAO _requisitoSistemaDAO;

		public RequisitoSistemaBusiness(IRequisitoSistemaDAO requisitoSistemaDAO)
		{
			_requisitoSistemaDAO = requisitoSistemaDAO;
		}

		public List<RequisitoModel> ListarRequisitoSistema(int Id)
		{
			var list = new List<RequisitoModel>();
			var listaentity = _requisitoSistemaDAO.Listar();
			foreach (var requisito in listaentity)
			{
				var requisitoCasting = (RequisitoModel)requisito;
				list.Add(requisitoCasting);

			}
			return list;

		}

		public RequisitoModel ObterRequisitoPorId(int id)
		{
			var requisito = _requisitoSistemaDAO.ListarPor(x => x.Id == id).FirstOrDefault();

			return (RequisitoModel)requisito;
		}

	}
}
