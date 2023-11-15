namespace WindowsFormLocadora
{
    partial class FormLocadora
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btnveiculo = new System.Windows.Forms.Button();
            this.btnlocacao = new System.Windows.Forms.Button();
            this.btnfinanceiro = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.Teal;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncliente.Location = new System.Drawing.Point(41, 32);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(130, 100);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "CLIENTE";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnveiculo
            // 
            this.btnveiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnveiculo.Location = new System.Drawing.Point(214, 32);
            this.btnveiculo.Name = "btnveiculo";
            this.btnveiculo.Size = new System.Drawing.Size(130, 100);
            this.btnveiculo.TabIndex = 1;
            this.btnveiculo.Text = "VEICULO";
            this.btnveiculo.UseVisualStyleBackColor = false;
            this.btnveiculo.Click += new System.EventHandler(this.btnveiculo_Click);
            // 
            // btnlocacao
            // 
            this.btnlocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlocacao.Location = new System.Drawing.Point(41, 166);
            this.btnlocacao.Name = "btnlocacao";
            this.btnlocacao.Size = new System.Drawing.Size(130, 100);
            this.btnlocacao.TabIndex = 2;
            this.btnlocacao.Text = "LOCAÇÃO";
            this.btnlocacao.UseVisualStyleBackColor = false;
            this.btnlocacao.Click += new System.EventHandler(this.btnlocacao_Click);
            // 
            // btnfinanceiro
            // 
            this.btnfinanceiro.BackColor = System.Drawing.Color.Teal;
            this.btnfinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinanceiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfinanceiro.Location = new System.Drawing.Point(214, 166);
            this.btnfinanceiro.Name = "btnfinanceiro";
            this.btnfinanceiro.Size = new System.Drawing.Size(130, 100);
            this.btnfinanceiro.TabIndex = 3;
            this.btnfinanceiro.Text = "FINANCEIRO";
            this.btnfinanceiro.UseVisualStyleBackColor = false;
            this.btnfinanceiro.Click += new System.EventHandler(this.btnfinanceiro_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Coral;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsair.Location = new System.Drawing.Point(407, 32);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(90, 234);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // FormLocadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 365);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnfinanceiro);
            this.Controls.Add(this.btnlocacao);
            this.Controls.Add(this.btnveiculo);
            this.Controls.Add(this.btncliente);
            this.Name = "FormLocadora";
            this.Text = "Locadora Rent Car Papale";
            this.Load += new System.EventHandler(this.FormLocadora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnveiculo;
        private System.Windows.Forms.Button btnlocacao;
        private System.Windows.Forms.Button btnfinanceiro;
        private System.Windows.Forms.Button btnsair;
    }
}

