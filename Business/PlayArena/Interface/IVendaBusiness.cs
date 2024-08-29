using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena.Interface
{
	public interface IVendaBusiness
	{
		public Task CadastrarVenda(VendaModel venda);
		public VendaModel ObterVendaPorId(int id);
	}
}
