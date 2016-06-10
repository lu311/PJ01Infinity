using PJ01Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Controller
{
    public class PessoaCategoriaControle
    {
        PessoaCategoriaDAO dao;

       public PessoaCategoriaControle()
        {
            dao = new PessoaCategoriaDAO();
        }

        public DataTable PesquisaCategorias()
        {
            return dao.PesquisaCategorias();
        }

        public void Gravar(PessoaCategoriaModel categoria)
        {
            dao.GravarCategoria(categoria.pessoaCategoria);
        }

        public void Excluir(int categoriaId)
        {
            dao.ExcluirCategoria(categoriaId);
        }

    }
}
