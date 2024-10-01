namespace _231027.Views
{
    partial class FrmCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.incluir = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(742, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o nome da Cidade para Pesquisar:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(27, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(27, 202);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(586, 20);
            this.txtPesquisa.TabIndex = 5;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(634, 88);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(137, 20);
            this.txtUF.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(586, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "UF:";
            // 
            // incluir
            // 
            this.incluir.Location = new System.Drawing.Point(27, 126);
            this.incluir.Name = "incluir";
            this.incluir.Size = new System.Drawing.Size(76, 47);
            this.incluir.TabIndex = 9;
            this.incluir.Text = "Incluir";
            this.incluir.UseVisualStyleBackColor = true;
            this.incluir.Click += new System.EventHandler(this.incluir_Click);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(122, 126);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(75, 47);
            this.alterar.TabIndex = 11;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(303, 126);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 47);
            this.cancelar.TabIndex = 13;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(213, 126);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 47);
            this.excluir.TabIndex = 15;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(397, 126);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 47);
            this.fechar.TabIndex = 17;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(653, 186);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(100, 50);
            this.pesquisar.TabIndex = 19;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // dgvCidades
            // 
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidades.Location = new System.Drawing.Point(27, 249);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.Size = new System.Drawing.Size(744, 189);
            this.dgvCidades.TabIndex = 20;
            this.dgvCidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCidades_CellContentClick);
            // 
            // FrmCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.incluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCidades";
            this.Text = "FrmCidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button incluir;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.DataGridView dgvCidades;
    }
}