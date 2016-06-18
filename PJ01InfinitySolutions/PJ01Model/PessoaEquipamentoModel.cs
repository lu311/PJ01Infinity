using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Model
{
    public class PessoaEquipamentoModel
    {
        public int equipamentoId { get; set; }
        public DateTime dataCadastro { get; set; }
        public int equipamentoTipoId { get; set; }
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public string numeroSerie { get; set; }
        public string etiquetaId { get; set; }
        public string pratimonioId { get; set; }
        public string nomePcRede { get; set; }
        public string redeIpFixo { get; set; }
        public string processador { get; set; }
        public string placaMae { get; set; }
        public string memoria { get; set; }
        public string placaVga { get; set; }
        public string placaRede { get; set; }
        public string hd { get; set; }
        public string driverDVD { get; set; }
        public string monitor { get; set; }
        public string fonteAlimentacao { get; set; }
        public int pessoaID { get; set; }
        public string impressoras { get; set; }
        public string impressorasIP { get; set; }
        public string scanner { get; set; }
        public string fornecedor { get; set; }
        public DateTime compraData { get; set; }
        public DateTime compraGarantia { get; set; }
        public string notaFiscal { get; set; }
        public string equipamentoEstado { get; set; }
        public Double equipamentoValor { get; set; }
        public string observacaoes { get; set; }

    }
}
