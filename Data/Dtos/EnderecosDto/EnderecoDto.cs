using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Dtos.EnderecoDtos
{
    public class EnderecoDto
    {
        public String Pais { get; set; }
        public String Cidade { get; set; }
        public String Rua { get; set; }
        public String Cep { get; set; }
    }
}