using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
	public interface IRequisitoSistemaBusiness
	{
		public List<RequisitoModel> ListarRequisitoSistema(int Id);
		public RequisitoModel ObterRequisitoPorId(int Id);
	}
}
