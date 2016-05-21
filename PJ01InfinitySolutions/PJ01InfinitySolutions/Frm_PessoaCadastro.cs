﻿using PJ01Controller;
using PJ01Model;
using System;
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
            PessoaControle pc = new PessoaControle();

            pessoa.pessoaId = Convert.ToInt32(txtCodigo.Text);
            pessoa.nome = txtNome.Text;
            pessoa.endereco = txtEndereco.Text;
            pessoa.complemento = txtComplemento.Text;

            // valida se alguns atributos
            if (pc.validaDados(pessoa) == false)
            {
                MessageBox.Show(pc.msgValidacao);
                return;
            }

            // incia o processo de gravar em banco de dados
            pc.Gravar(pessoa);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_PessoaCadastro_Load(object sender, EventArgs e)
        {
            PessoaControle pc = new PessoaControle();
            PessoaModel p = new PessoaModel();
            p = pc.PesquisaUmaPessoa(1);
            pc.FormatDataGridPessoa(dgvContatos);

        }
    }
}
