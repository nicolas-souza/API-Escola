using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public String Cep { get; set; }
        public String Rua { get; set; }
        public String Cidade { get; set; }
        public String Pais { get; set; }

    }
}