using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AluguelEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Jogo { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime DataDevolucaoReal { get; set; }
        public decimal Multa { get; set; }

		public AluguelEntity()
		{

		}

		public AluguelEntity(int Idjogo, int Idcliente)
		{
			Id_Cliente = Idcliente;
			Id_Jogo = Idjogo;
		}

		public static explicit operator AluguelModel(AluguelEntity source)
        {
            if (source != null)
            {
                return new AluguelModel()
                {
                    DataAluguel = source.DataAluguel
                };
            }
            else
                return null;
        }
		
		public static explicit operator AluguelEntity(AluguelModel source)
		{
			if (source != null)
			{
				return new AluguelEntity()
				{
					DataAluguel = source.DataAluguel
				};
			}
			else
				return null;
		}
	}
}
