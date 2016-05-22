using PJ01Controller;
using PJ01Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Model
{
    public class PessoaDAO
    {
        Banco banco = new Banco();
        DataTable tabelaSelect;


        public void AlterarPessoa(PessoaModel pessoa)
        {
            string sql = "update PESSOA set "
             + "NOME='" + pessoa.nome + "',"
             + "NOMEFANTASIA='" + pessoa.nomeFantasia + "',"
             + "PESSOAFISICAJURIDICA='" + pessoa.pessoaFisicaJuridica + "', "
             + "CNPJCPF='" + pessoa.cnpjCpf + "',"
             + "IERG='" + pessoa.ieRg + "',"
             + "OBS='" + pessoa.obs + "',"
             + "CATEGORIAID=" + pessoa.categoriaId + ","
             + "INATIVO='" + pessoa.inativo + "',"
             + "ENDERECO='" + pessoa.endereco + "',"
             + "COMPLEMENTO='" + pessoa.complemento + "',"
             + "NUMERO='" + pessoa.numero + "',"
             + "BAIRRO='" + pessoa.bairro + "',"
             + "CIDADE='" + pessoa.cidade + "',"
             + "UF='" + pessoa.uf + "',"
             + "CEP='" + pessoa.cep + "'"
             + " where pessoaid=" + pessoa.pessoaId;

            try
            {
                banco.abrirConexao();
                banco.Gravar(sql);
                InserirContato(pessoa.pessoaId, pessoa.pessoaContatos);
            }
            catch (Exception e)
            {
                Console.WriteLine("PessoaDao.UpdatePessoa erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        // metodo privado que montara o sql de insert (novos registro) para enviar ao banco de dados
        public void InserirPessoa(PessoaModel pessoa)
        {
            string sql = "INSERT INTO PESSOA (";
            sql += " DATACADASTRO, NOME, NOMEFANTASIA, PESSOAFISICAJURIDICA, ";
            sql += " CNPJCPF, IERG, OBS, CATEGORIAID, INATIVO, ENDERECO, COMPLEMENTO, NUMERO, BAIRRO, CIDADE, UF, CEP)";
            sql += " VALUES (CURRENT_DATE, '" + pessoa.nome + "', '" + pessoa.nomeFantasia + "', '" + pessoa.pessoaFisicaJuridica + "', ";
            sql += " '" + pessoa.cnpjCpf + "', '" + pessoa.ieRg + "','" + pessoa.obs + "'," + pessoa.categoriaId + ", '" + pessoa.inativo + "', '" + pessoa.endereco + "',";
            sql += " '" + pessoa.complemento + "','" + pessoa.numero + "','" + pessoa.bairro + "','" + pessoa.cidade + "', '" + pessoa.uf + "','" + pessoa.cep + "')";

            try
            {
                // banco.abrirConexaoTransacao();

                banco.abrirConexao();
                banco.Gravar(sql);

                // banco.Commit();

                // recupera o ID da pessoa
                tabelaSelect = banco.Select("SELECT GEN_ID(GEN_PESSOA_ID, 0) as PESSOAID FROM RDB$DATABASE");
                Console.WriteLine("row " + tabelaSelect.Rows[0][0].ToString());
                pessoa.pessoaId = Convert.ToInt32(tabelaSelect.Rows[0][0].ToString());
                Console.WriteLine("pessoaid " + pessoa.pessoaId);

                // banco.abrirConexaoTransacao();
                InserirContato(pessoa.pessoaId, pessoa.pessoaContatos);

                // banco.Commit();                
            }
            catch (Exception e)
            {
                // banco.Rollback();
                Console.WriteLine("PessoaDao.InserirPessoa erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        // metodo prevado que montara o sql de insert ou update para cadastro de contrato de uma pessoa
        // metodo privado que montara o sql de insert (novos registro) para enviar ao banco de dados
        private void InserirContato(int pessoaId, DataTable contato)
        {
            List<string> listSql = new List<string>();
            string data = "null";

            // recupera as linhas deletadas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] delRows = contato.Select(null, null, DataViewRowState.Deleted);

            // recupera as linhas Inseridas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] insertRows = contato.Select(null, null, DataViewRowState.Added);

            // recupera as linhas alteradas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] updateRows = contato.Select(null, null, DataViewRowState.ModifiedCurrent);

            foreach (DataRow row in delRows)
            {
                listSql.Add("delete from PESSOACONTATO where CONTATOID = " + row[0].ToString());
                Console.WriteLine("InserirPessoa.Contato linha deletada: " + row[0].ToString());
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

        public DataTable PesquisaPessoa(int id)
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoa where PESSOAID = " + id);
                banco.fecharConexao();
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

        public DataTable PesquisaContatos(int id)
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoacontato where PESSOAID = " + id);
                banco.fecharConexao();
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
    }
}
