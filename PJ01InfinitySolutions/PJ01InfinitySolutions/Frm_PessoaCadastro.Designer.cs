namespace PJ01InfinitySolutions
{
    partial class Frm_PessoaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDocumento2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocumento1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataCad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCadastroInativo = new System.Windows.Forms.CheckBox();
            this.rdbJuridica = new System.Windows.Forms.RadioButton();
            this.rdbFisica = new System.Windows.Forms.RadioButton();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 67);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::PJ01InfinitySolutions.Properties.Resources.index_delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(234, 4);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 57);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PJ01InfinitySolutions.Properties.Resources.disk_green;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(119, 4);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 57);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::PJ01InfinitySolutions.Properties.Resources.user1_add;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(4, 4);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 57);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 581);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtNomeFantasia);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtDataCad);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chkCadastroInativo);
            this.tabPage1.Controls.Add(this.rdbJuridica);
            this.tabPage1.Controls.Add(this.rdbFisica);
            this.tabPage1.Controls.Add(this.cmbCategoria);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDocumento2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDocumento1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 149);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentos";
            // 
            // txtDocumento2
            // 
            this.txtDocumento2.Location = new System.Drawing.Point(19, 94);
            this.txtDocumento2.Name = "txtDocumento2";
            this.txtDocumento2.Size = new System.Drawing.Size(187, 23);
            this.txtDocumento2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "CPF ou CNPJ";
            // 
            // txtDocumento1
            // 
            this.txtDocumento1.Location = new System.Drawing.Point(19, 43);
            this.txtDocumento1.Name = "txtDocumento1";
            this.txtDocumento1.Size = new System.Drawing.Size(183, 23);
            this.txtDocumento1.TabIndex = 22;
            this.txtDocumento1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDocumento1_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "RG ou IE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvContatos);
            this.groupBox2.Location = new System.Drawing.Point(12, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 232);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato(s)";
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContatos.Location = new System.Drawing.Point(3, 19);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(836, 210);
            this.dgvContatos.TabIndex = 39;
            this.dgvContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellContentClick);
            this.dgvContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvContatos_KeyPress);
            this.dgvContatos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvContatos_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(258, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 150);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 35);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(437, 23);
            this.txtEndereco.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(357, 77);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(210, 23);
            this.txtBairro.TabIndex = 33;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(357, 119);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(119, 23);
            this.txtCep.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Numero";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(250, 119);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(68, 23);
            this.txtUF.TabIndex = 37;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(475, 35);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 23);
            this.txtNumero.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Complemento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "UF";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(12, 77);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(303, 23);
            this.txtComplemento.TabIndex = 30;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(12, 119);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(210, 23);
            this.txtCidade.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Cidade";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(150, 127);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(704, 23);
            this.txtNomeFantasia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nome Fantasia";
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            this.txtDataCad.Location = new System.Drawing.Point(9, 127);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(100, 23);
            this.txtDataCad.TabIndex = 18;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 82);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo";
            // 
            // chkCadastroInativo
            // 
            this.chkCadastroInativo.AutoSize = true;
            this.chkCadastroInativo.Location = new System.Drawing.Point(492, 35);
            this.chkCadastroInativo.Name = "chkCadastroInativo";
            this.chkCadastroInativo.Size = new System.Drawing.Size(130, 20);
            this.chkCadastroInativo.TabIndex = 14;
            this.chkCadastroInativo.Text = "Cadastro inativo";
            this.chkCadastroInativo.UseVisualStyleBackColor = true;
            // 
            // rdbJuridica
            // 
            this.rdbJuridica.AutoSize = true;
            this.rdbJuridica.Location = new System.Drawing.Point(187, 35);
            this.rdbJuridica.Name = "rdbJuridica";
            this.rdbJuridica.Size = new System.Drawing.Size(126, 20);
            this.rdbJuridica.TabIndex = 13;
            this.rdbJuridica.Text = "Pessoa Jurídica";
            this.rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            this.rdbFisica.AutoSize = true;
            this.rdbFisica.Checked = true;
            this.rdbFisica.Location = new System.Drawing.Point(344, 35);
            this.rdbFisica.Name = "rdbFisica";
            this.rdbFisica.Size = new System.Drawing.Size(115, 20);
            this.rdbFisica.TabIndex = 12;
            this.rdbFisica.TabStop = true;
            this.rdbFisica.Text = "Pessoa Fisíca";
            this.rdbFisica.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(9, 32);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(140, 24);
            this.cmbCategoria.TabIndex = 11;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome da Pessoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 83);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(704, 23);
            this.txtNome.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtObs);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comentários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObs.Location = new System.Drawing.Point(3, 3);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(870, 546);
            this.txtObs.TabIndex = 0;
            // 
            // Frm_PessoaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 648);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_PessoaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa Cadastro";
            this.Load += new System.EventHandler(this.Frm_PessoaCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkCadastroInativo;
        private System.Windows.Forms.RadioButton rdbJuridica;
        private System.Windows.Forms.RadioButton rdbFisica;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDocumento2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDocumento1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataCad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObs;
    }
}