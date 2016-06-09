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
        PessoaCategoriaModel categoria;

        public Frm_PessoaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
