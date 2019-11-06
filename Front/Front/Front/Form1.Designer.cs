namespace Front
{
    partial class Conexão
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.AutoSize = true;
            this.tb_nome.Location = new System.Drawing.Point(47, 123);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(45, 17);
            this.tb_nome.TabIndex = 3;
            this.tb_nome.Text = "Nome";
            this.tb_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 154);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 22);
            this.txtName.TabIndex = 2;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(479, 43);
            this.bt_inserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(100, 28);
            this.bt_inserir.TabIndex = 7;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // bt_deletar
            // 
            this.bt_deletar.Location = new System.Drawing.Point(479, 123);
            this.bt_deletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(100, 28);
            this.bt_deletar.TabIndex = 8;
            this.bt_deletar.Text = "Excluir";
            this.bt_deletar.UseVisualStyleBackColor = true;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Location = new System.Drawing.Point(479, 211);
            this.bt_alterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(100, 28);
            this.bt_alterar.TabIndex = 9;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(40, 318);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.Size = new System.Drawing.Size(539, 185);
            this.dgvDados.TabIndex = 10;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(50, 63);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(227, 22);
            this.mskCpf.TabIndex = 13;
            // 
            // Conexão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 554);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_deletar);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Conexão";
            this.Text = "sss";
            this.Load += new System.EventHandler(this.Conexão_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.MaskedTextBox mskCpf;
    }
}

