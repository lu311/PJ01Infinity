﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PessoaConsulta telaPessoaConsulta = new Frm_PessoaConsulta();
            telaPessoaConsulta.ShowDialog();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroDeUmaNovaPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PessoaCadastro telaPessoaCadastro = new Frm_PessoaCadastro();
            telaPessoaCadastro.ShowDialog();
        }

        private void cadastroDeCategoriasDePessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PessoaCategoria telaPessoaCategoria = new Frm_PessoaCategoria();
            telaPessoaCategoria.ShowDialog();
        }
    }
}
