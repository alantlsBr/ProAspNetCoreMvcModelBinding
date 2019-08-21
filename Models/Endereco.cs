using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding.Models
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Complmento { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
    }
}
