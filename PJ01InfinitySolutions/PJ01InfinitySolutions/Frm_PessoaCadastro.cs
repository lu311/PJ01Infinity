using PJ01Controller;
using PJ01Model;
using System;
using System.Windows.Forms;

namespace PJ01InfinitySolutions
{
    public partial class Frm_PessoaCadastro : Form
    {

        PessoaModel pessoa;

        public Frm_PessoaCadastro()
        {
            InitializeComponent();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            rdbFisica.Checked = true;
            cmbCategoria.SelectedItem = -1;
            chkCadastroInativo.Checked = false;
            txtCodigo.Clear();
            txtNome.Clear();
            txtNomeFantasia.Clear();
            txtDocumento1.Clear();
            txtComplemento.Clear();
            txtDataCad.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtBairro.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtUF.Clear();
            txtDocumento2.Clear();      
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //PessoaModel pessoa = new PessoaModel();
            PessoaControle pc = new PessoaControle();


           // pessoa.pessoaContatos = dgvContatos.DataSource;

            pessoa.pessoaId = Convert.ToInt32(txtCodigo.Text);
            pessoa.nome = txtNome.Text;
            pessoa.endereco = txtEndereco.Text;
            pessoa.complemento = txtComplemento.Text;
          //  pessoa.dataCadastro = Convert.ToDateTime(txtDataCad.Text);
            pessoa.cidade = txtCidade.Text;
            pessoa.cep = txtCep.Text;
            pessoa.bairro = txtBairro.Text;
            pessoa.numero = txtNumero.Text;
            pessoa.uf = txtUF.Text;
            pessoa.cnpjCpf =(txtDocumento1.Text);
            pessoa.ieRg = (txtDocumento2.Text);
            pessoa.nomeFantasia = txtNomeFantasia.Text;

            if (chkCadastroInativo.Checked)
                pessoa.inativo = "I";

            else
                pessoa.inativo = "A";

            if (cmbCategoria.SelectedIndex > -1)
                pessoa.categoriaId =Convert.ToInt32( cmbCategoria.SelectedValue);
           else
            {
                MessageBox.Show("Selecionar uma Categoria.");
               // return;
            }
            if (rdbFisica.Checked)
                pessoa.pessoaFisicaJuridica = "F";

            else pessoa.pessoaFisicaJuridica = "J";


            // valida se alguns atributos
            if (pc.validaDados(pessoa) == false)
            {
                MessageBox.Show(pc.msgValidacao);
                return;
            }

            // incia o processo de gravar em banco de dados
            pc.Gravar(pessoa);
            MessageBox.Show("GRAVADO COM SUCESSO");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_PessoaCadastro_Load(object sender, EventArgs e)
        {
            PessoaControle pc = new PessoaControle();
            pessoa = new PessoaModel();
            pessoa = pc.PesquisaUmaPessoa(1);
            pc.FormatDataGridPessoa(dgvContatos);
        }
    }
}
