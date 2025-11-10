namespace GelatoLab.Views
{
    partial class MovimentacaoConsultaForm
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
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvMovimentacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(12, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(136, 16);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Produto/Observação:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(154, 6);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(492, 22);
            this.txtPesquisar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(662, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(662, 35);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(82, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(15, 41);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(38, 16);
            this.lbltipo.TabIndex = 4;
            this.lbltipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(65, 38);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(214, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(259, 38);
            this.dtData.Name = "dtData";
            this.dtData.ShowCheckBox = true;
            this.dtData.Size = new System.Drawing.Size(282, 22);
            this.dtData.TabIndex = 7;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(662, 382);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvMovimentacoes
            // 
            this.dgvMovimentacoes.AllowUserToAddRows = false;
            this.dgvMovimentacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentacoes.Location = new System.Drawing.Point(45, 100);
            this.dgvMovimentacoes.Name = "dgvMovimentacoes";
            this.dgvMovimentacoes.ReadOnly = true;
            this.dgvMovimentacoes.RowHeadersWidth = 51;
            this.dgvMovimentacoes.RowTemplate.Height = 24;
            this.dgvMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacoes.Size = new System.Drawing.Size(666, 254);
            this.dgvMovimentacoes.TabIndex = 11;
            // 
            // MovimentacaoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvMovimentacoes);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Name = "MovimentacaoConsultaForm";
            this.Text = "MovimentacaoConsultaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvMovimentacoes;
    }
}