using PJ01Controller;
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
        public string  msgValidacao { get; set; }
        Banco banco = new Banco();
        DataTable tabelaSelect;

        /// <summary>
        /// Metodo que verifica e faz algumas validações nos dados da Classe de Pessoa, 
        /// se retorna Verdadeiro (true) os dados estão corretos caso retorne falso deve verificar a propriedade msgValidacao
        /// </summary>
        /// <param name="pessoa"></param>
        public bool validaDados(PessoaDados pessoa)
        {
            bool valida = true;
            msgValidacao = string.Empty;

            if (pessoa.nome.Trim().Length < 1)
            {
                msgValidacao += "Nome do cadastro de pessoa esta vazio. \n";
                valida = false;
            }

            if (pessoa.endereco.Trim().Length > 0)
            {
                if (pessoa.bairro.Trim().Length < 1)
                {
                    msgValidacao += "Quando o tiver uma endereço digitado é necessário incluir o bairro. \n";
                    valida = false;
                }
                if (pessoa.cidade.Trim().Length < 1)
                {
                    msgValidacao += "Quando o tiver uma endereço digitado é necessário incluir o cidade. \n";
                    valida = false;
                }
                if (pessoa.uf.Trim().Length < 1)
                {
                    msgValidacao += "Quando o tiver uma endereço digitado é necessário incluir o Estado (UF). \n";
                    valida = false;
                }
            }

            return valida;
        }

        /// <summary>
        /// faz o processo de monta o SQL que vai a Banco, se o ID = 0 é um novo cadastro caso contrario é uma alteração
        /// </summary>
        /// <param name="pessoa"></param>
        public void Gravar(PessoaDados pessoa)
        {            
            if (pessoa.pessoaId > 0)
                InserirPessoa(pessoa);
            else
                ALterarPessoa(pessoa);
        }

        private void ALterarPessoa(PessoaDados pessoa)
        {
            throw new NotImplementedException(); 
        }

        // metodo privado que montara o sql de insert (novos registro) para enviar ao banco de dados
        private void InserirPessoa(PessoaDados pessoa)
        {
            string sql = "INSERT INTO PESSOA (";
            sql += " DATACADASTRO, NOME, NOMEFANTASIA, PESSOAFISICAJURIDICA, ";
            sql += " CNPJCPF, IERG, OBS, CATEGORIAID, INATIVO, ENDERECO, COMPLEMENTO, NUMERO, BAIRRO, CIDADE, UF, CEP)";
            sql += " VALUES (@DATACADASTRO, @NOME, @NOMEFANTASIA, @PESSOAFISICAJURIDICA, ";
            sql += " @CNPJCPF, @IERG, @OBS, @CATEGORIAID, @INATIVO, @ENDERECO, @COMPLEMENTO,";
            sql += " @NUMERO, @BAIRRO, @CIDADE, @UF, @CEP)";

            sql.Replace("@DATACADASTRO", DateTime.Now.ToString());
            sql.Replace("@NOME", pessoa.nome);
            sql.Replace("@NOMEFANTASIA", pessoa.nomeFantasia);
            sql.Replace("@PESSOAFISICAJURIDICA", pessoa.pessoaFisicaJuridica);
            sql.Replace("@CNPJCPF", pessoa.cnpjCpf);
            sql.Replace("@IERG", pessoa.ieRg);
            sql.Replace("@OBS", pessoa.obs);
            sql.Replace("@CATEGORIAID", pessoa.categoriaId);
            sql.Replace("@INATIVO", pessoa.inativo);
            sql.Replace("@ENDERECO", pessoa.endereco);
            sql.Replace("@COMPLEMENTO", pessoa.complemento);
            sql.Replace("@NUMERO", pessoa.numero);
            sql.Replace("@BAIRRO", pessoa.bairro);
            sql.Replace("@CIDADE", pessoa.cidade);
            sql.Replace("@UF", pessoa.uf);
            sql.Replace("@CEP", pessoa.cep);

            try
            {
                banco.abrirConexaoTransacao();
                banco.Gravar(sql);

                // recupera o ID da pessoa
                tabelaSelect = banco.Select("SELECT GEN_ID(GEN_PESSOA_ID, 0) as PESSOAID FROM RDB$DATABASE");

                pessoa.pessoaId = Convert.ToInt32(tabelaSelect.Rows[0][0]);

                InserirContato(pessoa, null);

                banco.Commit();
                banco.fecharConexao();
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
        private void InserirContato(PessoaDados pessoa, DataTable contato)
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
                      sql += "VALUES(@PESSOAID,@NOME,@DEPARTAMENTO,@DATAANIVERSARIO,@DDD,@FONE,@OPERADORA,@EMAIL)";

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
                string sql = "UPDATE PESSOACONTATO set PESSOAID=@PESSOAID, NOME=@NOME, DEPARTAMENTO=@DEPARTAMENTO, ";
                sql += "DATAANIVERSARIO=@DATAANIVERSARIO, DDD=@DDD, FONE=@FONE, OPERADORA=@OPERADORA, EMAIL=@EMAIL) ";
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
    }
}
