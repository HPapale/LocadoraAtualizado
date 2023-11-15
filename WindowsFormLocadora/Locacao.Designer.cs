namespace WindowsFormLocadora
{
    partial class Locacao
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
            this.dtgridlocacao = new System.Windows.Forms.DataGridView();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridlocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridlocacao
            // 
            this.dtgridlocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridlocacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.os,
            this.nome,
            this.CPF,
            this.placa,
            this.data,
            this.devolucao,
            this.valor});
            this.dtgridlocacao.Location = new System.Drawing.Point(2, 12);
            this.dtgridlocacao.Name = "dtgridlocacao";
            this.dtgridlocacao.Size = new System.Drawing.Size(786, 244);
            this.dtgridlocacao.TabIndex = 0;
            // 
            // btnincluir
            // 
            this.btnincluir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnincluir.Location = new System.Drawing.Point(71, 277);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(255, 75);
            this.btnincluir.TabIndex = 1;
            this.btnincluir.Text = "INCLUIR O.S";
            this.btnincluir.UseVisualStyleBackColor = false;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnalterar.Location = new System.Drawing.Point(71, 363);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(255, 75);
            this.btnalterar.TabIndex = 2;
            this.btnalterar.Text = "ALTERAR O.S ";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Coral;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(474, 277);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(255, 75);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvoltar.Location = new System.Drawing.Point(474, 363);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(255, 75);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // os
            // 
            this.os.DataPropertyName = "os";
            this.os.HeaderText = "O.S";
            this.os.Name = "os";
            this.os.Width = 45;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome_cliente";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 230;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf_cliente";
            this.CPF.HeaderText = "CPF ";
            this.CPF.Name = "CPF";
            this.CPF.Width = 120;
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa_veiculo";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.Width = 75;
            // 
            // data
            // 
            this.data.DataPropertyName = "data_locacao";
            this.data.HeaderText = "Data Locação";
            this.data.Name = "data";
            this.data.Width = 80;
            // 
            // devolucao
            // 
            this.devolucao.DataPropertyName = "data_devolucao";
            this.devolucao.HeaderText = "Data Devolução";
            this.devolucao.Name = "devolucao";
            this.devolucao.Width = 80;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor_pago";
            this.valor.HeaderText = "Valor Pago";
            this.valor.Name = "valor";
            // 
            // Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.dtgridlocacao);
            this.Name = "Locacao";
            this.Text = "Locacao";
            this.Load += new System.EventHandler(this.Locacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridlocacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridlocacao;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}