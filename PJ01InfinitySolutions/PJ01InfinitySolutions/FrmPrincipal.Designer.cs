namespace PJ01InfinitySolutions
{
    partial class FrmPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPessoaConsulta = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPessoasCadastradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUmaNovaPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCategoriasDePessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPessoaConsulta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(543, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPessoaConsulta
            // 
            this.toolStripButtonPessoaConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPessoaConsulta.Image = global::PJ01InfinitySolutions.Properties.Resources.user1_find;
            this.toolStripButtonPessoaConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPessoaConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPessoaConsulta.Name = "toolStripButtonPessoaConsulta";
            this.toolStripButtonPessoaConsulta.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonPessoaConsulta.Text = "toolStripButton1";
            this.toolStripButtonPessoaConsulta.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(543, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Cadastros";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPessoasCadastradaToolStripMenuItem,
            this.cadastroDeUmaNovaPessoaToolStripMenuItem,
            this.cadastroDeCategoriasDePessoaToolStripMenuItem});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // consultaPessoasCadastradaToolStripMenuItem
            // 
            this.consultaPessoasCadastradaToolStripMenuItem.Name = "consultaPessoasCadastradaToolStripMenuItem";
            this.consultaPessoasCadastradaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultaPessoasCadastradaToolStripMenuItem.Text = "Consulta pessoas cadastrada";
            this.consultaPessoasCadastradaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // cadastroDeUmaNovaPessoaToolStripMenuItem
            // 
            this.cadastroDeUmaNovaPessoaToolStripMenuItem.Name = "cadastroDeUmaNovaPessoaToolStripMenuItem";
            this.cadastroDeUmaNovaPessoaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cadastroDeUmaNovaPessoaToolStripMenuItem.Text = "Cadastro de uma nova pessoa";
            this.cadastroDeUmaNovaPessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUmaNovaPessoaToolStripMenuItem_Click);
            // 
            // cadastroDeCategoriasDePessoaToolStripMenuItem
            // 
            this.cadastroDeCategoriasDePessoaToolStripMenuItem.Name = "cadastroDeCategoriasDePessoaToolStripMenuItem";
            this.cadastroDeCategoriasDePessoaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cadastroDeCategoriasDePessoaToolStripMenuItem.Text = "Cadastro de categorias de pessoa";
            this.cadastroDeCategoriasDePessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCategoriasDePessoaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 331);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PJ01 - Infinity Informática";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPessoaConsulta;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPessoasCadastradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUmaNovaPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCategoriasDePessoaToolStripMenuItem;
    }
}

