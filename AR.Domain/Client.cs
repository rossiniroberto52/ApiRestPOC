using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} carcteres")]
        public string Name { get; set; }
        public string cpf { get; set; }
        public int Idade { get; set; }
    }
}
