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
        
        public void InserirCategoria(DataTable categoria)
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
                if (row["DATAANIVERSARIO"].ToString().Length > 0)
                    data = "'" + row["DATAANIVERSARIO"].ToString().Replace("/", ".").Replace("/", ".").Substring(0, 10) + "'";
                else
                    data = "null";

                string sql = "INSERT INTO PESSOACONTATO (PESSOAID,NOME,DEPARTAMENTO,DATAANIVERSARIO,DDD,FONE,OPERADORA,EMAIL) ";
                sql += "VALUES (" + pessoaId + ",'" +
                    row["NOME"].ToString() + "','" +
                    row["DEPARTAMENTO"].ToString() + "'," +
                    data + ",'" +
                    row["DDD"].ToString() + "','" +
                    row["FONE"].ToString() + "','" +
                    row["OPERADORA"].ToString() + "','" +
                    row["EMAIL"].ToString() + "')";

                listSql.Add(sql);
                Console.WriteLine("InserirCategoria linha insert: \n" + sql);
            }

            foreach (DataRow row in updateRows)
            {
                if (row["DATAANIVERSARIO"].ToString().Length > 0)
                    data = "'" + row["DATAANIVERSARIO"].ToString().Replace("/", ".").Replace("/", ".").Substring(0, 10) + "'";
                else
                    data = "null";

                string sql = "UPDATE PESSOACONTATO set "
                    + "NOME='" + row["NOME"].ToString() + "',"
                    + "DEPARTAMENTO='" + row["DEPARTAMENTO"].ToString() + "',"
                    + "DATAANIVERSARIO=" + data + ","
                    + "DDD='" + row["DDD"].ToString() + "',"
                    + "FONE='" + row["FONE"].ToString() + "',"
                    + "OPERADORA='" + row["OPERADORA"].ToString() + "',"
                    + "EMAIL='" + row["EMAIL"].ToString() + "' "
                    + "where CONTATOID = " + row["CONTATOID"].ToString();

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
        /// Pesquisa em banco de dados uma pessoaCategoria utilizando o ID como base da busca.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable PesquisaCategoria(int id)
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoacategoria where categoriaID = " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine("PesquisaCategoria erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
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
