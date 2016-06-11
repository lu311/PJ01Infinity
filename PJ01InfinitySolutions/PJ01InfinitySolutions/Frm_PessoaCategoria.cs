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
    public partial class Frm_PessoaCategoria : Form
    {
        PessoaCategoriaControle pc = new PessoaCategoriaControle();

        public Frm_PessoaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_PessoaCategoria_Load(object sender, EventArgs e)
        {
            pc.PesquisaCategorias();
            pc.FormatDataGridCategoria(dgvCategorias);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            pc.Gravar(pc.categoria);
            MessageBox.Show("Dados gravaso com sucesso.");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
