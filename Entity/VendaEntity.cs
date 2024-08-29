using Microsoft.Identity.Client;
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
    public class VendaEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Jogo { get; set; }
        public DateTime DataVenda { get; set; }

        public VendaEntity()
        {
            
        }

        public VendaEntity(int Idjogo, int Idcliente)
        {
			Id_Cliente = Idcliente;
            Id_Jogo = Idjogo;
		}

        public static explicit operator VendaModel(VendaEntity source)
        {
            if (source != null)
            {
                return new VendaModel()
                {
                    DataVenda = source.DataVenda
                };
            }
            else
                return null;
        }

		public static explicit operator VendaEntity(VendaModel source)
		{
			if (source != null)
			{
				return new VendaEntity()
				{
					DataVenda = source.DataVenda
				};
			}
			else
				return null;
		}
	}
}
