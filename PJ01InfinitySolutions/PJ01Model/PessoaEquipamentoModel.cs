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
        public string EtiqueId { get; set; }
        public string pratimonioId { get; set; }
        public string NomePcRede { get; set; }
        public string RedeIpFixo { get; set; }
        public string Processador { get; set; }
        public string PlacaMae { get; set; }
        public string Memoria { get; set; }
        public string PlacaVga { get; set; }
        public string PlacaRede { get; set; }
        public string HD { get; set; }
        public string DriverDVD { get; set; }
        public string Monitor { get; set; }
        public string fonteAlimentacao { get; set; }
        public int PessoaID { get; set; }
        public string Impressoras { get; set; }
        public string ImpressorasIP { get; set; }
        public string scanner { get; set; }
        public string fornecedor { get; set; }
        public DateTime compraData { get; set; }
        public DateTime compraGarantia { get; set; }
        public string NotaFiscal { get; set; }
        public string equipamentoEstado { get; set; }
        public Double equipamentoValor { get; set; }
        public string observacaoes { get; set; }

    }
}
