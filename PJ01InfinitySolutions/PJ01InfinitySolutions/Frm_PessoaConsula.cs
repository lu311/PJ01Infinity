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
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Frm_PessoaCadastro telaPessoaCadastro = new Frm_PessoaCadastro();
            telaPessoaCadastro.ShowDialog();
        }
    }
}
