using PJ01Controller;
using PJ01Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ01InfinitySolutions
{
    public partial class Frm_PessoaConsulta : Form
    {
        PessoaControle pc = new PessoaControle();
        public PessoaModel pessoaSelecionada;
        public int pessoaSelecionadaID;

        /// <summary>
        /// este construtor torna invisivel o botao de selecionar
        /// nesta caso o uso pesquisa de pessoas é apenas da meio de cadastro e alteração.
        /// </summary>
        public Frm_PessoaConsulta()
        {          
            InitializeComponent();

            btnSelecionar.Visible = false;
        }

        /// <summary>
        /// este construtor habilita o botao de seleciona pessoa ao receber qualquer valor boleano, 
        /// o botao seleciona recupera os dados de uma pessoa e a coloca em um objeto na memoria
        /// depois a tela e fechada.
        /// </summary>
        /// <param name="habilitaSelecionar"></param>
        public Frm_PessoaConsulta(bool habilitaSelecionar)
        {
            InitializeComponent();

            btnSelecionar.Visible = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisarPessoas();
            }
        }

        private void pesquisarPessoas()
        {
            // realiza a pesquisa
            dgvPessoaConsulta.DataSource = pc.PesquisaVariasPessoas(txtPesquisa.Text);

            // configura o datagrid
            dgvPessoaConsulta.Columns["pessoaid"].HeaderText = "Código";
            dgvPessoaConsulta.Columns["nome"].HeaderText = "Nome ou Razão Social";
            dgvPessoaConsulta.Columns["inativo"].HeaderText = "Ativo";
            dgvPessoaConsulta.Columns["nomefantasia"].HeaderText = "Nome fantasia";
            dgvPessoaConsulta.Columns["cnpjcpf"].HeaderText = "CNPJ/CPF";
            dgvPessoaConsulta.Columns["ierg"].HeaderText = "I.E./RG";
            dgvPessoaConsulta.Columns["pessoafisicajuridica"].HeaderText = "F/J";
            dgvPessoaConsulta.Columns["categoriaid"].HeaderText = "categoriaid";
            dgvPessoaConsulta.Columns["cidade"].HeaderText = "Cidade";
            dgvPessoaConsulta.Columns["telefone"].HeaderText = "Telefone";

            dgvPessoaConsulta.Columns["inativo"].Visible = false;
            dgvPessoaConsulta.Columns["nomefantasia"].Visible = false;
            dgvPessoaConsulta.Columns["ierg"].Visible = false;
            dgvPessoaConsulta.Columns["pessoafisicajuridica"].Visible = false;
            dgvPessoaConsulta.Columns["categoriaid"].Visible = false;

            dgvPessoaConsulta.Columns["pessoaid"].Width = 50;
            dgvPessoaConsulta.Columns["nome"].Width = 300;
            dgvPessoaConsulta.Columns["cidade"].Width = 150;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // inicializar o objeto da tela de cadastro.
            Frm_PessoaCadastro telaPessoaCadastro = new Frm_PessoaCadastro();
            telaPessoaCadastro.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // criar o objeto da tela de cadastro, recupera o valor do codigo (ID) da linha seliciona e atribui a variavel
            //  do objeto tela.
            Frm_PessoaCadastro telaPessoaCadastro = new Frm_PessoaCadastro();
            DataGridViewRow row = dgvPessoaConsulta.CurrentRow;
            telaPessoaCadastro.pessoaIdPesquisa = Convert.ToInt32(row.Cells["pessoaid"].Value);
            telaPessoaCadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisarPessoas();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // recupera o valor do codigo (ID) da linha seliciona e faz uma pesquisa em banco de dados
            // o metodo vai retorna um objeto PessoaModelo apos fazer as associação a variavel a tela sera fechadadesta.
            DataGridViewRow row = dgvPessoaConsulta.CurrentRow;
            pessoaSelecionada = pc.PesquisaUmaPessoa(Convert.ToInt32(row.Cells["pessoaid"].Value));
            pessoaSelecionadaID = pessoaSelecionada.pessoaId;
            // fecha a tela tambem pode ser usado this.Close();
            Close(); 
        }
    }
}
