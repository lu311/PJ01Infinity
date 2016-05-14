using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Controller
{
    public class Banco
    {
        // Irá armazenar na variavel "banco" as configuraçoes do meu Banco de Dados
        string banco;
        FbConnection conexao;
        FbCommand comando;
        FbDataAdapter da;
        FbTransaction transacao;

        /// <summary>
        /// Contrutor que não requer string de conexção pois esta faz parte do contrutor
        /// </summary>
        public Banco()
        {
            banco = @"User=infinityinformatica;"
                + "Password=rapport;"
                + "Database=firebird.infinityinformatica.com.br:/firebird/infinityinformatica.gdb;"
                + "Dialect=3;"
                + "DataSource=firebird.infinityinformatica.com.br;"
                + "Port=3050";
            conexao = new FbConnection(banco);
            comando = new FbCommand("", conexao);
            da = new FbDataAdapter("", conexao);
        }

        /// <summary>
        /// Contrutor que requer uma string de conexção
        /// </summary>
        /// <param name="bancoStringConecxao"></param>
        public Banco(string bancoStringConecxao)
        {
            string banco = bancoStringConecxao;
            conexao = new FbConnection(banco);
            comando = new FbCommand("", conexao);
            da = new FbDataAdapter("", conexao);
        }

        /// <summary>
        ///  Irá abrir a Conexão com o banco de dados, apos o uso do contrutor.
        /// </summary>
        public void abrirConexao()
        {
            conexao.Open();
        }

        /// <summary>
        /// Irá fechar a Conexão com o banco de dado, caso não tenha feito efetivado a gravação dos dados (COMMIT) as alteração 
        /// serão pedidas ao fechar a conecxão.
        /// </summary>
        public void fecharConexao()
        {
            conexao.Close();
        }

        /// <summary>
        /// Irá abrir a Transação com o banco de dados (depede do metodo abrirConexão). É criado uma rota (sessão) para trabalhar 
        /// um pacote de dados, necessário o metodo COMMIT ou Rollback para efetivar ou cancelar as alateração.
        /// </summary>
        public void AbrirTransacao()
        {
            transacao = conexao.BeginTransaction();
            comando.Transaction = transacao;
        }

        /// <summary>
        /// Irá abrir a Conexão do banco de dados junto com a transacao, requer metodo COMMIT ou Rollback para efetivar ou cancelar as alateração.
        /// </summary>
        public void abrirConexaoTransacao()
        {
            conexao.Open();
            AbrirTransacao();
        }

        /// <summary>
        ///  Irá Comitar (efetivar) a transação e gravar os dados no Banco de Dados
        /// </summary>
        public void Commit()
        {
            comando.Transaction.Commit();
        }

        /// <summary>
        /// Irá desfazer a transação (cancelar) revertendo as alterações dos dados no banco de dados 
        /// </summary>
        public void Rollback()
        {
            comando.Transaction.Rollback();
        }

        /// <summary>
        /// Irá gravar os dados no banco de dados - com tratamento de erro (exception(s))
        /// este metodo vaí receber comomando SQL (insert, update, delete) que vão ser enviado ao banco de dados
        /// </summary>
        /// <param name="pSql"></param>
        /// <returns></returns>
        public string Gravar(string pSql)
        {
            comando.CommandText = pSql;
            
            try
            {
                comando.ExecuteNonQuery();
                return "";
            }
            catch (FbException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Recebe comandos SQL (select) para fazer pesquisas no banco de dados 
        /// </summary>
        /// <param name="pSelect"></param>
        /// <returns>retorno um DataTable </returns>
        public DataTable Select(string pSelect)
        {
            try
            {
                DataTable t = new DataTable();
                da.SelectCommand.CommandText = pSelect;
                da.Fill(t);
                return t;
            }
            catch (FbException)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo que receber o nome de uma tabela e o nome do campo ID desta tabela para assim retornar o maior numero de ID
        /// inserido na tabela. Utilizado para recupera o ID de um campo apos seu insert na tabela.
        /// </summary>
        /// <param name="pTabela"></param>
        /// <param name="pCampo"></param>
        /// <returns></returns>
        public int SelectMaxScalar(string pTabela, string pCampo)
        {
            comando.CommandText = "select max(" + pCampo + ") from " + pTabela;
            try
            {
                return (int)comando.ExecuteScalar();
            }
            catch (FbException)
            {
                return 0;
            }
        }

        /// <summary>
        /// retorna a propriedade que execulta os camando dentro do banco de dados.
        /// seu uso e para pegar recursos que a clase de Banco não tem disponivel
        /// </summary>
        /// <returns></returns>
        public FbCommand Comando()
        {
            return comando;
        }

    }
}
