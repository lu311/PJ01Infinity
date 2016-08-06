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
    public partial class txtFornecedor : Form
    {

        PessoaModel pessoa;

        public txtFornecedor()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            PessoaEquipamentoModel eq = new PessoaEquipamentoModel();

            // eq.equipamentoId = Convert.ToInt32(txtCodigo.Text);
            //eq.dataCadastro = txtda
            //eq.equipamentoTipoId = cmdEquipamento.ValueMember;
            eq.fabricante = txtFabricante.Text;
            eq.modelo = txtModelo.Text;
            eq.numeroSerie = txtNSerie.Text;
            eq.etiquetaId = txtEtiqueta.Text;
            eq.pratimonioId = txtPatrimonial.Text;
            eq.nomePcRede = txtNomePc.Text;
            eq.redeIpFixo = txtIpFixo.Text;
            eq.processador = txtProcessador.Text;
            eq.placaMae = txtFabricante.Text;
            eq.memoria = txtFabricante.Text;
            eq.placaVga = txtFabricante.Text;
            eq.placaRede = txtFabricante.Text;
            eq.hd = txtFabricante.Text;
            eq.driverDVD = txtFabricante.Text;
            eq.monitor = txtFabricante.Text;
            eq.fonteAlimentacao = txtFabricante.Text;
            eq.pessoaID = txtFabricante.Text;
            eq.impressoras = txtFabricante.Text;
            eq.impressorasIP = txtFabricante.Text;
            eq.scanner = txtFabricante.Text;
            eq.fornecedor = txtFabricante.Text;
            eq.compraData = txtFabricante.Text;
            eq.compraGarantia = txtFabricante.Text;
            eq.notaFiscal = txtFabricante.Text;
            eq.equipamentoEstado = txtFabricante.Text;
            eq.equipamentoValor = txtFabricante.Text;
            eq.observacaoes = txtFabricante.Text;



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
    }
}
