using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena.Interface
{
	public interface IAluguelBusiness
	{
		public Task CadastrarAluguel(AluguelModel aluguel);
		public AluguelModel ObterAluguelPorId(int id);
	}
}
