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
    public class ClienteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public int Telefone { get; set; }
        public string Email { get; set; } = string.Empty;

        public static explicit operator ClienteModel(ClienteEntity source)
        {
            if (source != null)
            {
                return new ClienteModel()
                {
                    Nome = source.Nome,
                    Endereco = source.Endereco,
                    Telefone = source.Telefone,
                    Email = source.Email
                };
            }
            else
                return null;
        }
    }
}
