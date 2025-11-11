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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultaMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDesenvolvedores = new System.Windows.Forms.ToolStripMenuItem();
            this.GelatoLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(310, 276);
            this.lblUsuarioLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(50, 16);
            this.lblUsuarioLogado.TabIndex = 0;
            this.lblUsuarioLogado.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.menuItemDesenvolvedores});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
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
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuItemUsuarios
            // 
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(145, 22);
            this.menuItemUsuarios.Text = "Usuarios";
            this.menuItemUsuarios.Click += new System.EventHandler(this.menuItemUsuarios_Click);
            // 
            // menuItemProdutos
            // 
            this.menuItemProdutos.Name = "menuItemProdutos";
            this.menuItemProdutos.Size = new System.Drawing.Size(145, 22);
            this.menuItemProdutos.Text = "Produtos";
            this.menuItemProdutos.Click += new System.EventHandler(this.menuItemProdutos_Click);
            // 
            // menuItemCategorias
            // 
            this.menuItemCategorias.Name = "menuItemCategorias";
            this.menuItemCategorias.Size = new System.Drawing.Size(145, 22);
            this.menuItemCategorias.Text = "Categorias";
            this.menuItemCategorias.Click += new System.EventHandler(this.menuItemCategorias_Click);
            // 
            // menuItemFornecedores
            // 
            this.menuItemFornecedores.Name = "menuItemFornecedores";
            this.menuItemFornecedores.Size = new System.Drawing.Size(145, 22);
            this.menuItemFornecedores.Text = "Fornecedores";
            this.menuItemFornecedores.Click += new System.EventHandler(this.menuItemFornecedores_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMovimentacao});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // menuItemMovimentacao
            // 
            this.menuItemMovimentacao.Name = "menuItemMovimentacao";
            this.menuItemMovimentacao.Size = new System.Drawing.Size(184, 22);
            this.menuItemMovimentacao.Text = "Movimentar Estoque";
            this.menuItemMovimentacao.Click += new System.EventHandler(this.menuItemMovimentacao_Click);
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
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // menuItemConsultaUsuarios
            // 
            this.menuItemConsultaUsuarios.Name = "menuItemConsultaUsuarios";
            this.menuItemConsultaUsuarios.Size = new System.Drawing.Size(209, 22);
            this.menuItemConsultaUsuarios.Text = "Consulta Usuarios";
            this.menuItemConsultaUsuarios.Click += new System.EventHandler(this.menuItemConsultaUsuarios_Click);
            // 
            // menuItemConsultaProdutos
            // 
            this.menuItemConsultaProdutos.Name = "menuItemConsultaProdutos";
            this.menuItemConsultaProdutos.Size = new System.Drawing.Size(209, 22);
            this.menuItemConsultaProdutos.Text = "Consulta Produtos";
            this.menuItemConsultaProdutos.Click += new System.EventHandler(this.menuItemConsultaProdutos_Click);
            // 
            // menuItemConsultaCategorias
            // 
            this.menuItemConsultaCategorias.Name = "menuItemConsultaCategorias";
            this.menuItemConsultaCategorias.Size = new System.Drawing.Size(209, 22);
            this.menuItemConsultaCategorias.Text = "Consulta Categorias";
            this.menuItemConsultaCategorias.Click += new System.EventHandler(this.menuItemConsultaCategorias_Click);
            // 
            // menuItemConsultaFornecedores
            // 
            this.menuItemConsultaFornecedores.Name = "menuItemConsultaFornecedores";
            this.menuItemConsultaFornecedores.Size = new System.Drawing.Size(209, 22);
            this.menuItemConsultaFornecedores.Text = "Consulta Fornecedores";
            this.menuItemConsultaFornecedores.Click += new System.EventHandler(this.menuItemConsultaFornecedores_Click);
            // 
            // menuItemConsultaMovimentacoes
            // 
            this.menuItemConsultaMovimentacoes.Name = "menuItemConsultaMovimentacoes";
            this.menuItemConsultaMovimentacoes.Size = new System.Drawing.Size(209, 22);
            this.menuItemConsultaMovimentacoes.Text = "Consulta Movimentacoes";
            this.menuItemConsultaMovimentacoes.Click += new System.EventHandler(this.menuItemConsultaMovimentacoes_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSair});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // menuItemSair
            // 
            this.menuItemSair.Name = "menuItemSair";
            this.menuItemSair.Size = new System.Drawing.Size(93, 22);
            this.menuItemSair.Text = "Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // menuItemDesenvolvedores
            // 
            this.menuItemDesenvolvedores.Name = "menuItemDesenvolvedores";
            this.menuItemDesenvolvedores.Size = new System.Drawing.Size(108, 20);
            this.menuItemDesenvolvedores.Text = "Desenvolvedores";
            this.menuItemDesenvolvedores.Click += new System.EventHandler(this.menuItemDesenvolvedores_Click);
            // 
            // GelatoLab
            // 
            this.GelatoLab.AutoSize = true;
            this.GelatoLab.BackColor = System.Drawing.Color.Transparent;
            this.GelatoLab.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GelatoLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(129)))));
            this.GelatoLab.Location = new System.Drawing.Point(35, 109);
            this.GelatoLab.Name = "GelatoLab";
            this.GelatoLab.Size = new System.Drawing.Size(465, 86);
            this.GelatoLab.TabIndex = 2;
            this.GelatoLab.Text = "GelatoLab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GelatoLab.Properties.Resources.imagem_540x321;
            this.ClientSize = new System.Drawing.Size(524, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GelatoLab);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem menuItemDesenvolvedores;
        private System.Windows.Forms.Label GelatoLab;
        private System.Windows.Forms.Label label2;
    }
}