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
        
       
        public void ALterarPessoa(PessoaModel pessoa)
        {
            throw new NotImplementedException(); 
        }

        // metodo privado que montara o sql de insert (novos registro) para enviar ao banco de dados
        public void InserirPessoa(PessoaModel pessoa)
        {
            string sql = "INSERT INTO PESSOA (";
            sql += " DATACADASTRO, NOME, NOMEFANTASIA, PESSOAFISICAJURIDICA, ";
            sql += " CNPJCPF, IERG, OBS, CATEGORIAID, INATIVO, ENDERECO, COMPLEMENTO, NUMERO, BAIRRO, CIDADE, UF, CEP)";
            sql += " VALUES (CURRENT_DATE, '" + pessoa.nome+ "', '" + pessoa.nomeFantasia + "', '" + pessoa.pessoaFisicaJuridica + "', ";
            sql += " '" + pessoa.cnpjCpf + "', '" + pessoa.ieRg + "','" + pessoa.obs + "'," + pessoa.categoriaId + ", '" + pessoa.inativo + "', '" + pessoa.endereco + "',";
            sql += " '" + pessoa.complemento + "','" + pessoa.numero + "','" + pessoa.bairro+ "','" + pessoa.cidade + "', '" + pessoa.uf+ "','" + pessoa.cep + "')";

            try
            {
                banco.abrirConexaoTransacao();
                banco.Gravar(sql);

                banco.Commit();

                // recupera o ID da pessoa
                tabelaSelect = banco.Select("SELECT GEN_ID(GEN_PESSOA_ID, 0) as PESSOAID FROM RDB$DATABASE");
                Console.WriteLine("row "+tabelaSelect.Rows[0][0].ToString());
                pessoa.pessoaId = Convert.ToInt32(tabelaSelect.Rows[0][0].ToString());
                Console.WriteLine("pessoaid "+ pessoa.pessoaId);
               

               // InserirContato(pessoa, null);

              //  banco.Commit();                
            }
            catch (Exception e)
            {
                banco.Rollback();                
                Console.WriteLine("PessoaDao.InserirPessoa erro: " + e.Message);
            }       
            finally
            {
                banco.fecharConexao();
            }


        }

        // metodo prevado que montara o sql de insert ou update para cadastro de contrato de uma pessoa
        // metodo privado que montara o sql de insert (novos registro) para enviar ao banco de dados
        private void InserirContato(PessoaModel pessoa, DataTable contato)
        {        
            List<string> listSql = new List<string>();

            // recupera as linhas deletadas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] delRows = contato.Select(null, null, DataViewRowState.Deleted);

            // recupera as linhas Inseridas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] insertRows = contato.Select(null, null, DataViewRowState.Added);

            // recupera as linhas alteradas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] updateRows = contato.Select(null, null, DataViewRowState.Added);

            foreach (DataRow row in delRows)
            {
                listSql.Add("delete from PESSOACONTATO where CONTATOID = " + row[0].ToString());
                Console.WriteLine("InserirPessoa.Contato linha deletada: " + row[0].ToString());
            }

            foreach (DataRow row in insertRows)
            {
                string sql = "INSERT INTO PESSOACONTATO (PESSOAID, NOME, DEPARTAMENTO, "; 
                      sql += "DATAANIVERSARIO, DDD, FONE, OPERADORA, EMAIL) ";
                      sql += "VALUES ('@PESSOAID','@NOME','@DEPARTAMENTO','@DATAANIVERSARIO','@DDD','@FONE','@OPERADORA','@EMAIL')";

                sql.Replace("@PESSOAID", pessoa.pessoaId.ToString());
                sql.Replace("@DEPARTAMENTO", row["DEPARTAMENTO"].ToString());
                sql.Replace("@DATAANIVERSARIO", row["DATAANIVERSARIO"].ToString());
                sql.Replace("@DDD", row["DDD"].ToString());
                sql.Replace("@FONE", row["FONE"].ToString());
                sql.Replace("@OPERADORA", row["OPERADORA"].ToString());
                sql.Replace("@EMAIL", row["EMAIL"].ToString());

                listSql.Add(sql);
                Console.WriteLine("InserirPessoa.Contato linha insert: \n" + sql);
            }

            foreach (DataRow row in updateRows)
            {
                string sql = "UPDATE PESSOACONTATO set PESSOAID='@PESSOAID', NOME='@NOME', DEPARTAMENTO='@DEPARTAMENTO', ";
                sql += "DATAANIVERSARIO='@DATAANIVERSARIO', DDD='@DDD', FONE='@FONE', OPERADORA='@OPERADORA', EMAIL='@EMAIL') ";
                sql += "where CONTATOID = @CONTATOID";

                sql.Replace("@CONTATOID", row["CONTATOID"].ToString());
                sql.Replace("@DEPARTAMENTO", row["DEPARTAMENTO"].ToString());
                sql.Replace("@DATAANIVERSARIO", row["DATAANIVERSARIO"].ToString());
                sql.Replace("@DDD", row["DDD"].ToString());
                sql.Replace("@FONE", row["FONE"].ToString());
                sql.Replace("@OPERADORA", row["OPERADORA"].ToString());
                sql.Replace("@EMAIL", row["EMAIL"].ToString());

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
                tabelaSelect = banco.Select("SELECT * from pessoacontato where PESSOAID = "+id);
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
