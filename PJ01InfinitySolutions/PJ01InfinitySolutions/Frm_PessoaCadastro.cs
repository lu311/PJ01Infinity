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
    public partial class Frm_PessoaCadastro : Form
    {
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
            PessoaModel pessoa = new PessoaModel();

            pessoa.pessoaId = Convert.ToInt32(txtCodigo.Text);
            pessoa.nome = txtNome.Text;
            pessoa.endereco = txtEndereco.Text;
            pessoa.complemento = txtComplemento.Text;
     

            //PessoaDAO dao = new PessoaDAO();


            //if (dao.validaDados(pessoa) == false)
            //{
            //    MessageBox.Show(dao.msgValidacao);
            //    return;
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
