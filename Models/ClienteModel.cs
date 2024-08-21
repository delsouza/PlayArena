using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o seu nome!")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite o endereço!")]
        public string Endereco { get; set; } = string.Empty;
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Digite o seu telefone!")]
        public int Telefone { get; set; }
		[DataType(DataType.EmailAddress)]
		[Required(ErrorMessage = "Digite o seu email!")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite a sua senha!")]
        [DataType(DataType.Password)]
		public string Senha { get; set; } = string.Empty;
    }
}
