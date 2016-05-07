using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Model
{
    class PessoaDAO
    {
        public string  msgValidacao { get; set; }

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
            sql += " VALUES(NULL, 'teste 1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL); ";
        }
    }
}
