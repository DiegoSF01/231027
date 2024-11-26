namespace _231027.Views
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.dgvprodutos = new System.Windows.Forms.DataGridView();
            this.pesquisar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.incluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtvalorVenda = new System.Windows.Forms.TextBox();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(304, 242);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(177, 20);
            this.txtEstoque.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Estoque:";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(508, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(322, 250);
            this.picFoto.TabIndex = 70;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Marca:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 65;
            this.label.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(27, 131);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(454, 21);
            this.cboCategoria.TabIndex = 64;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // dgvprodutos
            // 
            this.dgvprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprodutos.Location = new System.Drawing.Point(27, 410);
            this.dgvprodutos.Name = "dgvprodutos";
            this.dgvprodutos.Size = new System.Drawing.Size(789, 189);
            this.dgvprodutos.TabIndex = 62;
            this.dgvprodutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprodutos_CellContentClick);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(652, 354);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(100, 50);
            this.pesquisar.TabIndex = 61;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(423, 290);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 47);
            this.fechar.TabIndex = 60;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(228, 290);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 47);
            this.excluir.TabIndex = 59;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(325, 290);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 47);
            this.cancelar.TabIndex = 58;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(129, 290);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(75, 47);
            this.alterar.TabIndex = 57;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // incluir
            // 
            this.incluir.Location = new System.Drawing.Point(27, 290);
            this.incluir.Name = "incluir";
            this.incluir.Size = new System.Drawing.Size(76, 47);
            this.incluir.TabIndex = 56;
            this.incluir.Text = "Incluir";
            this.incluir.UseVisualStyleBackColor = true;
            this.incluir.Click += new System.EventHandler(this.incluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Valor de Venda:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(27, 79);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(454, 20);
            this.txtDescricao.TabIndex = 54;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(27, 373);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(586, 20);
            this.txtPesquisa.TabIndex = 52;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(27, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 20);
            this.txtID.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Digite o produto para Pesquisar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(742, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(27, 184);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(454, 21);
            this.cboMarca.TabIndex = 74;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // txtvalorVenda
            // 
            this.txtvalorVenda.Location = new System.Drawing.Point(27, 242);
            this.txtvalorVenda.Name = "txtvalorVenda";
            this.txtvalorVenda.Size = new System.Drawing.Size(177, 20);
            this.txtvalorVenda.TabIndex = 75;
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 621);
            this.Controls.Add(this.txtvalorVenda);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.dgvprodutos);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.incluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DataGridView dgvprodutos;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button incluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtvalorVenda;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}