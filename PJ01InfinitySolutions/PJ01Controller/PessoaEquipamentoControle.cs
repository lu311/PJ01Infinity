using PJ01AcessoBancoDados;
using PJ01Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ01Controller
{
    class PessoaEquipamentoControle
    {

        public string msgValidacao { get; set; }
        public PessoaEquipamentoDAO dao;
        public PessoaModel pessoa { get; set; }
        public PessoaEquipamentoModel pessoaEquipaento { get; set; }


        public PessoaEquipamentoControle()
        {
            pessoa = new PessoaModel();
            pessoaEquipaento = new PessoaEquipamentoModel();
        }


        public DataTable PesquisaVariasEquipamentos(int pessoaId)
        {
            return null;
           
        }


  
        private Boolean validaDados()
        {
            if (pessoa.pessoaId < 1)
            {
                msgValidacao += "\n Inserir código do cliente no equipamento.";
                return false;
            }
            return true;
        }


        public void Gravar()
        {
            if (pessoaEquipaento.equipamentoId > 0)
            {
                dao.AlterarEquipamento(pessoaEquipaento);
            }
            else
            {
                dao.InserirPessoaEquipamento(pessoaEquipaento);
            }
        }


        public PessoaEquipamentoModel PesquisaUmaEquipamento(int EquipamentoId)
        {
            return null;
        }

 
        public void FormatDataGridEquipamento(DataGridView dataGrid)
        {
        
        }


        public void PesquisaTiposEquipamentos(ComboBox combo)
        {

        }


        public void ExcluirEquipamento(int EquipamentoID)
        {
            dao.ExcluirPessoaEquipamento(EquipamentoID);
        }
    }
}
