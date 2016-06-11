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
    public class PessoaCategoriaControle
    {
        PessoaCategoriaDAO dao;
        public PessoaCategoriaModel categoria { get; set; }        

        public PessoaCategoriaControle()
        {
            dao = new PessoaCategoriaDAO();
            categoria = new PessoaCategoriaModel();
        }

        public void PesquisaCategorias()
        {
            categoria.pessoaCategoria = dao.PesquisaCategorias();
        }

        public void Gravar(PessoaCategoriaModel categoria)
        {
            dao.GravarCategoria(categoria.pessoaCategoria);
        }

        public void Excluir(int categoriaId)
        {
            dao.ExcluirCategoria(categoriaId);
        }

        public void FormatDataGridCategoria(DataGridView dataGrid)
        {
            dataGrid.DataSource = categoria.pessoaCategoria;

            dataGrid.Columns["categoriaid"].HeaderText = "CID";          
            dataGrid.Columns["Categoria"].HeaderText = "Nome do contato";
            dataGrid.Columns["Categoria"].Width = 150;
            dataGrid.Columns["categoriaid"].Visible = false;            
        }

    }
}
