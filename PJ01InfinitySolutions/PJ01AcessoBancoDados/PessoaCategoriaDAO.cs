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
                Console.WriteLine("InserirPessoa.Contato linha insert: \n" + sql);
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
                Console.WriteLine("UpdatePessoa.Contato linha insert: \n" + sql);
            }

            foreach (string sql in listSql)
            {
                banco.Gravar(sql);
            }
        }

        /// <summary>
        /// Pesquisa e delete uma pessoa no banco de dados utilizando o ID como base da busca.
        /// </summary>
        /// <param name="pessoaId"></param>
        public void ExcluirPessoa(int pessoaId)
        {
            try
            {
                banco.abrirConexaoTransacao();
                banco.Gravar("delete from pessoa where PESSOAID = " + pessoaId);
                banco.Commit();
            }
            catch (Exception e)
            {
                banco.Rollback();
                Console.WriteLine("PessoaDao.ExcluirPessoa erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        /// <summary>
        /// Pesquisa em banco de dados uma pessoa utilizando o ID como base da busca.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable PesquisaPessoa(int id)
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoa where PESSOAID = " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine("PessoaDao.PesquisaPessoa erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
        }

        /// <summary>
        /// Pesquisa em banco de dados uma ou mais pessoa utilizando um texto como base da busca 
        /// por hora apenas o nome esta sendo usado como meio de pesquisa.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public DataTable PesquisaPessoas(string texto)
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoa_consulta_view where upper(nome) like upper('%" + texto + "%') "
                    + " or upper(nomefantasia) like upper('%" + texto + "%') "
                    + " or upper(cidade) like upper('%" + texto + "%')  order by nome"
                    );
            }
            catch (Exception e)
            {
                Console.WriteLine("PessoaDao.PesquisaPessoas erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
        }

        /// <summary>
        ///  Pesquisa em banco de dados os contatos de uma pessoa utilizando o ID da pessoa como base da busca.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable PesquisaContatos(int id)
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoacontato where PESSOAID = " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine("PessoaDao.PesquisaContatos erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
        }

        /// <summary>
        /// Retorna os tipos de categoria que estão no banco de dados.
        /// </summary>
        /// <returns></returns>
        public DataTable PesquisaCategoriasPessoa()
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from PESSOACATEGORIA order by CATEGORIA");
            }
            catch (Exception e)
            {
                Console.WriteLine("PessoaDao.PesquisaCategoriasPessoa erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
        }
    }
}
}
