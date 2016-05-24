using PJ01Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace PJ01Controller
{
    public class PessoaControle
    {
        public string msgValidacao { get; set; }
        PessoaDAO dao;
        PessoaModel pessoa;

        // contrutor da classe inicializar alguns objetos
        public PessoaControle()
        {
            dao = new PessoaDAO();
            pessoa = new PessoaModel();
        }

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

        /// <summary>
        /// faz o processo de monta o SQL que vai a Banco, se o ID = 0 é um novo cadastro caso contrario é uma alteração
        /// </summary>
        /// <param name="pessoa"></param>
        public void Gravar(PessoaModel pessoa)
        {
            if (pessoa.pessoaId > 0)
                dao.AlterarPessoa(pessoa);
            else
                dao.InserirPessoa(pessoa);
        }

        /// <summary>
        /// Metodo que faz pesquisa no banco de dados por meio da classe DAO, o resultado é atribuido ao objeto PessoaModel 
        /// </summary>
        /// <param name="pessoaId"></param>
        /// <returns></returns>
        public PessoaModel PesquisaUmaPessoa(int pessoaId)
        {
            // pesquisa a pessoa
            DataTable t;
            t = dao.PesquisaPessoa(pessoaId);

            if (t.Rows.Count > 0)
            {
                pessoa.pessoaId = Convert.ToInt32(t.Rows[0]["PESSOAID"].ToString());
                pessoa.dataCadastro = Convert.ToDateTime(t.Rows[0]["DATACADASTRO"]);
                pessoa.nome = t.Rows[0]["NOME"].ToString();
                pessoa.nomeFantasia = t.Rows[0]["NOMEFANTASIA"].ToString();
                pessoa.pessoaFisicaJuridica = t.Rows[0]["PESSOAFISICAJURIDICA"].ToString();
                pessoa.cnpjCpf = t.Rows[0]["CNPJCPF"].ToString();
                pessoa.ieRg = t.Rows[0]["IERG"].ToString();
                pessoa.obs = t.Rows[0]["OBS"].ToString();
                pessoa.categoriaId = Convert.ToInt32(t.Rows[0]["CATEGORIAID"].ToString());
                pessoa.inativo = t.Rows[0]["INATIVO"].ToString();
                pessoa.endereco = t.Rows[0]["ENDERECO"].ToString();
                pessoa.complemento = t.Rows[0]["COMPLEMENTO"].ToString();
                pessoa.numero = t.Rows[0]["NUMERO"].ToString();
                pessoa.bairro = t.Rows[0]["BAIRRO"].ToString();
                pessoa.cidade = t.Rows[0]["CIDADE"].ToString();
                pessoa.uf = t.Rows[0]["UF"].ToString();
                pessoa.cep = t.Rows[0]["CEP"].ToString();
            }
            // pesquisa os contatos da pessoa

            pessoa.pessoaContatos = dao.PesquisaContatos(pessoaId);

            return pessoa;
        }

        /// <summary>
        /// Metodo que recebe um DataGridView, do Objeto PessoaModel.pessoaContato DataSource 
        /// DataGridView, aproveitando para fazer uma formação no data
        /// </summary>
        /// <param name="dataGrid"></param>
        public void FormatDataGridPessoa(DataGridView dataGrid)
        {
            dataGrid.DataSource = pessoa.pessoaContatos;

            dataGrid.Columns["CONTATOID"].HeaderText = "CID";
            dataGrid.Columns["PESSOAID"].HeaderText = "PID";
            dataGrid.Columns["NOME"].HeaderText = "Nome do contato";
            dataGrid.Columns["DEPARTAMENTO"].HeaderText = "Departamento";
            dataGrid.Columns["DATAANIVERSARIO"].HeaderText = "Data aniversário";
            dataGrid.Columns["DDD"].HeaderText = "DDD";
            dataGrid.Columns["FONE"].HeaderText = "Telefone";
            dataGrid.Columns["OPERADORA"].HeaderText = "Operadora";
            dataGrid.Columns["EMAIL"].HeaderText = "E-Mail";
            dataGrid.Columns["EMAIL"].Width = 300;

            dataGrid.Columns["CONTATOID"].Visible = false;
            dataGrid.Columns["PESSOAID"].Visible = false;
        }

        public void PesquisaCategorias(ComboBox combo)
        {

            DataTable t;
            t = dao.PesquisaCategoriasPessoa();

            combo.DataSource = t;
            combo.ValueMember = "categoriaid";
            combo.DisplayMember = "categoria";

        }
    }
}
