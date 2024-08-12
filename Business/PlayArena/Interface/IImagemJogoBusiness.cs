using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PlayArena.Interface
{
    public interface IImagemJogoBusiness
    {
        public ImagemJogoModel ObterImagemJogoPorId(int id);
		public List<ImagemJogoModel> ListarImagemJogo(int id);
	}
}
