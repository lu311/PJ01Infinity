﻿using PJ01Controller;
using PJ01Model;
using System;
using System.Windows.Forms;

namespace PJ01InfinitySolutions
{
    public partial class Frm_PessoaCadastro : Form
    {

        PessoaModel pessoa;
        PessoaControle pc = new PessoaControle();
        int pessoaIdPesquisa = 35;

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
            txtCodigo.Text = "0";
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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

                txtCodigo.Text = pessoa.pessoaId.ToString();
                txtDataCad.Text = pessoa.dataCadastro.ToString().Substring(0,10);
                txtNome.Text = pessoa.nome;
                pessoa.endereco = txtEndereco.Text;
                txtComplemento.Text = pessoa.complemento;
                txtCidade.Text = pessoa.cidade;
                txtCep.Text = pessoa.cep;
                txtBairro.Text = pessoa.bairro;
                txtNumero.Text = pessoa.numero;
                txtUF.Text = pessoa.uf;
                txtDocumento1.Text = pessoa.cnpjCpf;
                txtDocumento2.Text = pessoa.ieRg;
                txtNomeFantasia.Text = pessoa.nomeFantasia;

                if (pessoa.inativo == "I")
                    chkCadastroInativo.Checked = true;
                else
                    chkCadastroInativo.Checked = false;

                cmbCategoria.SelectedValue = pessoa.categoriaId;

                if (pessoa.pessoaFisicaJuridica == "F")
                    rdbFisica.Checked = true;
                else
                    rdbJuridica.Checked = true; ;
            }
            else
            {
                pessoa = pc.PesquisaUmaPessoa(0);
                pc.FormatDataGridPessoa(dgvContatos);
            }
        }
    }
}
