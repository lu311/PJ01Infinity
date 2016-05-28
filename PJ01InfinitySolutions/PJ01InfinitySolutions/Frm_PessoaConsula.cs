using PJ01Controller;
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
        public Frm_PessoaConsulta()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PessoaControle pc = new PessoaControle();
                dgvPessoaConsulta.DataSource = pc.PesquisaVariasPessoas(txtPesquisa.Text);

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
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Frm_PessoaCadastro telaPessoaCadastro = new Frm_PessoaCadastro();
            telaPessoaCadastro.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Frm_PessoaCadastro telaPessoaCadastro = new Frm_PessoaCadastro();
            DataGridViewRow row = dgvPessoaConsulta.CurrentRow;
            telaPessoaCadastro.pessoaIdPesquisa = Convert.ToInt32(row.Cells["pessoaid"].Value);
            telaPessoaCadastro.ShowDialog();
        }
    }
}
