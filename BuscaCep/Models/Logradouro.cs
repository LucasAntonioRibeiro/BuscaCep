using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCep.Models
{
    public class Logradouro
    {
        public string CEP { get; set; }
        public string id_logradouro { get; set; }
        public string tipo { get; set; }
        public string descrcao { get; set; }
        public string id_cidade { get; set; }
        public string UF { get; set; }
        public string complemento { get; set; }
        public string descrticao_sem_numero { get; set; }
        public string descricao_cidade { get; set; }
        public string codigo_cidade_ibge { get; set; }
        public string descricao_bairro { get; set; }
    }
}
