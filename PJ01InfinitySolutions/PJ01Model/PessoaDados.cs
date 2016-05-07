using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Model
{
    public class PessoaDados
    {
        public int pessoaId { get; set; }
        public DateTime dataCadastro { get; set; }
        public string nome { get; set; }
        public string nomeFantasia { get; set; }
        public string pessoaFisicaJuridica { get; set; }
        public string cnpjCpf { get; set; }
        public string ieRg { get; set; }
        public string obs { get; set; }
        public string categoriaId { get; set; }
        public string inativo { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
    }
}
