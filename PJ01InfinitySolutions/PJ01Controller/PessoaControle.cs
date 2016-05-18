using PJ01Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01Controller
{
    class PessoaControle
    {
        public string msgValidacao { get; set; }

        /// <summary>
        /// Metodo que verifica e faz algumas validações nos dados da Classe de Pessoa, 
        /// se retorna Verdadeiro (true) os dados estão corretos caso retorne falso deve verificar a propriedade msgValidacao
        /// </summary>
        /// <param name="pessoa"></param>
        public bool validaDados(PessoaModel pessoa)
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


    }
}
