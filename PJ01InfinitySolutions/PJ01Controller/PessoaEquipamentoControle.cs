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

        public string msgValidacao;
        public EquipamentoDAO dao;
        public PessoaModel pessoa;
        public PessoaEquipamentoModel pessoaEquipaento;


        public PessoaEquipamentoControle()
        {
            pessoa = new PessoaModel();
            pessoaEquipaento = new PessoaEquipamentoModel();
        }


        public DataTable PesquisaVariasEquipamentos(int pessoaId)
        {
            return null;
           
        }


  
        private Boolean validaDados(PessoaEquipamentoModel Equipamento)
        {
            return false;
        }


        public void Gravar(PessoaEquipamentoModel Equipamento)
        {

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

        }
    }
}
