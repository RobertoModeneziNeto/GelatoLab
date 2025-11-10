namespace GelatoLab.Views
{
    partial class MenuPrincipalForm
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
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(603, 9);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(44, 16);
            this.lblUsuarioLogado.TabIndex = 0;
            this.lblUsuarioLogado.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.desenvolvedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUsuarios,
            this.menuItemProdutos,
            this.menuItemCategorias,
            this.menuItemFornecedores});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMovimentacao});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConsultaUsuarios,
            this.menuItemConsultaProdutos,
            this.menuItemConsultaCategorias,
            this.menuItemConsultaFornecedores,
            this.menuItemConsultaMovimentacoes});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSair});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // menuItemUsuarios
            // 
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(224, 26);
            this.menuItemUsuarios.Text = "Usuarios";
            // 
            // menuItemProdutos
            // 
            this.menuItemProdutos.Name = "menuItemProdutos";
            this.menuItemProdutos.Size = new System.Drawing.Size(224, 26);
            this.menuItemProdutos.Text = "Produtos";
            // 
            // menuItemCategorias
            // 
            this.menuItemCategorias.Name = "menuItemCategorias";
            this.menuItemCategorias.Size = new System.Drawing.Size(224, 26);
            this.menuItemCategorias.Text = "Categorias";
            this.menuItemCategorias.Click += new System.EventHandler(this.menuItemCategorias_Click);
            // 
            // menuItemFornecedores
            // 
            this.menuItemFornecedores.Name = "menuItemFornecedores";
            this.menuItemFornecedores.Size = new System.Drawing.Size(224, 26);
            this.menuItemFornecedores.Text = "Fornecedores";
            // 
            // menuItemSair
            // 
            this.menuItemSair.Name = "menuItemSair";
            this.menuItemSair.Size = new System.Drawing.Size(224, 26);
            this.menuItemSair.Text = "Sair";
            // 
            // menuItemConsultaUsuarios
            // 
            this.menuItemConsultaUsuarios.Name = "menuItemConsultaUsuarios";
            this.menuItemConsultaUsuarios.Size = new System.Drawing.Size(258, 26);
            this.menuItemConsultaUsuarios.Text = "Consulta Usuarios";
            // 
            // menuItemConsultaProdutos
            // 
            this.menuItemConsultaProdutos.Name = "menuItemConsultaProdutos";
            this.menuItemConsultaProdutos.Size = new System.Drawing.Size(258, 26);
            this.menuItemConsultaProdutos.Text = "Consulta Produtos";
            // 
            // menuItemConsultaCategorias
            // 
            this.menuItemConsultaCategorias.Name = "menuItemConsultaCategorias";
            this.menuItemConsultaCategorias.Size = new System.Drawing.Size(258, 26);
            this.menuItemConsultaCategorias.Text = "Consulta Categorias";
            this.menuItemConsultaCategorias.Click += new System.EventHandler(this.menuItemConsultaCategorias_Click);
            // 
            // menuItemConsultaFornecedores
            // 
            this.menuItemConsultaFornecedores.Name = "menuItemConsultaFornecedores";
            this.menuItemConsultaFornecedores.Size = new System.Drawing.Size(258, 26);
            this.menuItemConsultaFornecedores.Text = "Consulta Fornecedores";
            // 
            // menuItemConsultaMovimentacoes
            // 
            this.menuItemConsultaMovimentacoes.Name = "menuItemConsultaMovimentacoes";
            this.menuItemConsultaMovimentacoes.Size = new System.Drawing.Size(258, 26);
            this.menuItemConsultaMovimentacoes.Text = "Consulta Movimentacoes";
            // 
            // menuItemMovimentacao
            // 
            this.menuItemMovimentacao.Name = "menuItemMovimentacao";
            this.menuItemMovimentacao.Size = new System.Drawing.Size(229, 26);
            this.menuItemMovimentacao.Text = "Movimentar Estoque";
            // 
            // desenvolvedoresToolStripMenuItem
            // 
            this.desenvolvedoresToolStripMenuItem.Name = "desenvolvedoresToolStripMenuItem";
            this.desenvolvedoresToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.desenvolvedoresToolStripMenuItem.Text = "Desenvolvedores";
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuItemProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuItemCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuItemFornecedores;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultaCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultaFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultaMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem menuItemSair;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoresToolStripMenuItem;
    }
}