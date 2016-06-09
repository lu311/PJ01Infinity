using PJ01Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Model
{
    class PessoaCategoriaDAO
    {
        Banco banco = new Banco();
        DataTable tabelaSelect; 
        
        /// <summary>
        /// Metodo que recebe um datatable de categorias e o converte em sql para ser enviado ao banco de dados.
        /// </summary>
        /// <param name="categoria"></param>
        public void GravarCategoria(DataTable categoria)
        {
            List<string> listSql = new List<string>();

            // recupera as linhas deletadas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] delRows = categoria.Select(null, null, DataViewRowState.Deleted);

            // recupera as linhas Inseridas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] insertRows = categoria.Select(null, null, DataViewRowState.Added);

            // recupera as linhas alteradas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] updateRows = categoria.Select(null, null, DataViewRowState.ModifiedCurrent);

            foreach (DataRow row in delRows)
            {
                listSql.Add("delete from PESSOACATEGORIA where categoriaID = " + row["contatoid", DataRowVersion.Original].ToString());
                Console.WriteLine("InserirCategoria linha deletada: " + row["contatoid", DataRowVersion.Original].ToString());
            }

            foreach (DataRow row in insertRows)
            {
                string sql = "INSERT INTO PESSOACATEGORIA (categoria) VALUES ('" + row["categoria"].ToString() + "')";
                
                listSql.Add(sql);
                Console.WriteLine("InserirCategoria linha insert: \n" + sql);
            }

            foreach (DataRow row in updateRows)
            {
                string sql = "UPDATE PESSOACATEGORIA set "
                    + "NOME='" + row["categoria"].ToString() + "' "
                    + "where categogiraid = " + row["categoriaID"].ToString();

                listSql.Add(sql);
                Console.WriteLine("InserirCategoria linha update: \n" + sql);
            }

            foreach (string sql in listSql)
            {
                banco.Gravar(sql);
            }
        }

        /// <summary>
        /// Pesquisa e delete uma categoria no banco de dados utilizando o ID como base da busca.
        /// </summary>
        /// <param name="categoriaId"></param>
        public void ExcluirCategoria(int categoriaId)
        {
            try
            {
                banco.abrirConexaoTransacao();
                banco.Gravar("delete from pessoacategoria where categoriaID = " + categoriaId);
                banco.Commit();
            }
            catch (Exception e)
            {
                banco.Rollback();
                Console.WriteLine("ExcluirCategoria erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }
        }
     
        /// <summary>
        /// Pesquisa em banco de dados e retorna todas as categorias 
        /// </summary>
        /// <returns></returns>
        public DataTable PesquisaCategorias()
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoacategorias order by categoria");                   
            }
            catch (Exception e)
            {
                Console.WriteLine("PesquisaCategorias erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
        }        
    }
}
