using PJ01Controller;
using PJ01Model;
using System;
using System.Windows.Forms;

namespace PJ01InfinitySolutions
{
    public partial class Frm_PessoaCadastro : Form
    {

        PessoaControle pc = new PessoaControle();
        PessoaModel pessoa;
        public int pessoaIdPesquisa = 0;

        public Frm_PessoaCadastro()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            pessoa.pessoaId = Convert.ToInt32(txtCodigo.Text);
            pessoa.nome = txtNome.Text;
            pessoa.endereco = txtEndereco.Text;
            pessoa.complemento = txtComplemento.Text;
            pessoa.cidade = txtCidade.Text;
            pessoa.cep = txtCep.Text;
            pessoa.bairro = txtBairro.Text;
            pessoa.numero = txtNumero.Text;
            pessoa.uf = txtUF.Text;
            pessoa.cnpjCpf = (txtDocumento1.Text);
            pessoa.ieRg = (txtDocumento2.Text);
            pessoa.nomeFantasia = txtNomeFantasia.Text;
            pessoa.obs = txtObs.Text;

            if (chkCadastroInativo.Checked)
                pessoa.inativo = "I";

            else
                pessoa.inativo = "A";

            if (cmbCategoria.SelectedIndex > -1)
                pessoa.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
            else
            {
                // MessageBox.Show("Selecionar uma Categoria.");
                // return;
            }
            if (rdbFisica.Checked)
                pessoa.pessoaFisicaJuridica = "F";
            else
                pessoa.pessoaFisicaJuridica = "J";


            // valida se alguns atributos
            if (pc.validaDados(pessoa) == false)
            {
                MessageBox.Show(pc.msgValidacao);
                return;
            }

            // incia o processo de gravar em banco de dados
            pc.Gravar(pessoa);
            MessageBox.Show("GRAVADO COM SUCESSO");
            LimpaTela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
            chkCadastroInativo.Checked = false;
            cmbCategoria.SelectedItem = -1;
            rdbFisica.Checked = true;
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCodigo.Clear();
            txtCodigo.Text = "0";
            txtComplemento.Clear();
            txtDataCad.Clear();
            txtDocumento1.Clear();
            txtDocumento2.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNomeFantasia.Clear();
            txtNumero.Clear();
            txtUF.Clear();
            txtObs.Clear();
            dgvContatos.DataSource = null;
            tabControl1.TabIndex = 0;
            pessoaIdPesquisa = 0;
            PesquisaPessoa();
        }

        private void Frm_PessoaCadastro_Load(object sender, EventArgs e)
        {
            PesquisaPessoa();
        }

        private void PesquisaPessoa()
        {
            pessoa = new PessoaModel();

            if (pessoaIdPesquisa > 0)
            {
                pessoa = pc.PesquisaUmaPessoa(pessoaIdPesquisa);
                pc.FormatDataGridPessoa(dgvContatos);
                pc.PesquisaCategorias(cmbCategoria);

                txtCodigo.Text = pessoa.pessoaId.ToString();
                txtDataCad.Text = pessoa.dataCadastro.ToString().Substring(0, 10);
                txtNome.Text = pessoa.nome;
                txtEndereco.Text = pessoa.endereco;
                txtComplemento.Text = pessoa.complemento;
                txtCidade.Text = pessoa.cidade;
                txtCep.Text = pessoa.cep;
                txtBairro.Text = pessoa.bairro;
                txtNumero.Text = pessoa.numero;
                txtUF.Text = pessoa.uf;
                txtDocumento1.Text = pessoa.cnpjCpf;
                txtDocumento2.Text = pessoa.ieRg;
                txtNomeFantasia.Text = pessoa.nomeFantasia;
                txtObs.Text = pessoa.obs;

                if (pessoa.inativo == "I")
                    chkCadastroInativo.Checked = true;
                else
                    chkCadastroInativo.Checked = false;

                cmbCategoria.SelectedValue = pessoa.categoriaId;

                if (pessoa.pessoaFisicaJuridica == "F")
                    rdbFisica.Checked = true;
                else
                    rdbJuridica.Checked = true;
            }
            else
            {
                pessoa = pc.PesquisaUmaPessoa(0);
                pc.FormatDataGridPessoa(dgvContatos);
                pc.PesquisaCategorias(cmbCategoria);
            }
        }

        private void dgvContatos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void DeletaContato()
        {
            foreach (DataGridViewRow item in dgvContatos.SelectedRows)
            {
                dgvContatos.Rows.RemoveAt(item.Index);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "0")
            {
                DialogResult opcao = MessageBox.Show("Deseja excluir este cadastro? \n Após confirmação a tela será fechada.",
                    "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    pc.ExcluirPessoa(Convert.ToInt32(txtCodigo.Text));
                    this.Close();
                }
            }
        }
    }
}
