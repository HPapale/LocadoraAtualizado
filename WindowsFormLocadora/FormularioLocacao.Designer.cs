namespace WindowsFormLocadora
{
    partial class FormularioLocacao
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lbldatalocacao = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldatadevolucao = new System.Windows.Forms.Label();
            this.cboxveiculo = new System.Windows.Forms.ComboBox();
            this.cboxcpf = new System.Windows.Forms.ComboBox();
            this.lblseguro = new System.Windows.Forms.Label();
            this.ckbcseguro = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.MaskedTextBox();
            this.mascaracpf = new System.Windows.Forms.MaskedTextBox();
            this.mascaraplaca = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf2 = new System.Windows.Forms.Label();
            this.lblplaca2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalvar.Location = new System.Drawing.Point(619, 39);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(122, 140);
            this.btnsalvar.TabIndex = 0;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(619, 227);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(122, 140);
            this.btnvoltar.TabIndex = 1;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(37, 292);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(101, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(34, 271);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(108, 18);
            this.lblvalor.TabIndex = 9;
            this.lblvalor.Text = "VALOR PAGO ";
            // 
            // lbldatalocacao
            // 
            this.lbldatalocacao.AutoSize = true;
            this.lbldatalocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatalocacao.Location = new System.Drawing.Point(34, 185);
            this.lbldatalocacao.Name = "lbldatalocacao";
            this.lbldatalocacao.Size = new System.Drawing.Size(147, 18);
            this.lbldatalocacao.TabIndex = 10;
            this.lbldatalocacao.Text = "DATA DE LOCAÇÃO";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(34, 99);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(120, 18);
            this.lblnome.TabIndex = 11;
            this.lblnome.Text = "NOME CLIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "MODELO VEICULO / PLACA";
            // 
            // lbldatadevolucao
            // 
            this.lbldatadevolucao.AutoSize = true;
            this.lbldatadevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatadevolucao.Location = new System.Drawing.Point(280, 185);
            this.lbldatadevolucao.Name = "lbldatadevolucao";
            this.lbldatadevolucao.Size = new System.Drawing.Size(168, 18);
            this.lbldatadevolucao.TabIndex = 17;
            this.lbldatadevolucao.Text = "DATA DE DEVOLUÇÃO";
            // 
            // cboxveiculo
            // 
            this.cboxveiculo.FormattingEnabled = true;
            this.cboxveiculo.Location = new System.Drawing.Point(34, 44);
            this.cboxveiculo.Name = "cboxveiculo";
            this.cboxveiculo.Size = new System.Drawing.Size(310, 21);
            this.cboxveiculo.TabIndex = 24;
            // 
            // cboxcpf
            // 
            this.cboxcpf.FormattingEnabled = true;
            this.cboxcpf.Location = new System.Drawing.Point(37, 121);
            this.cboxcpf.Name = "cboxcpf";
            this.cboxcpf.Size = new System.Drawing.Size(307, 21);
            this.cboxcpf.TabIndex = 25;
            // 
            // lblseguro
            // 
            this.lblseguro.AutoSize = true;
            this.lblseguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseguro.Location = new System.Drawing.Point(31, 349);
            this.lblseguro.Name = "lblseguro";
            this.lblseguro.Size = new System.Drawing.Size(181, 18);
            this.lblseguro.TabIndex = 26;
            this.lblseguro.Text = "Assinale opção de Seguro";
            // 
            // ckbcseguro
            // 
            this.ckbcseguro.AutoSize = true;
            this.ckbcseguro.Location = new System.Drawing.Point(37, 386);
            this.ckbcseguro.Name = "ckbcseguro";
            this.ckbcseguro.Size = new System.Drawing.Size(72, 17);
            this.ckbcseguro.TabIndex = 19;
            this.ckbcseguro.Text = "ACEITAR";
            this.ckbcseguro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 209);
            this.dateTimePicker1.Mask = "00/00/0000";
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(283, 209);
            this.dateTimePicker2.Mask = "00/00/0000";
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.ValidatingType = typeof(System.DateTime);
            // 
            // mascaracpf
            // 
            this.mascaracpf.Location = new System.Drawing.Point(480, 121);
            this.mascaracpf.Mask = "000.000.000-00";
            this.mascaracpf.Name = "mascaracpf";
            this.mascaracpf.Size = new System.Drawing.Size(100, 20);
            this.mascaracpf.TabIndex = 29;
            // 
            // mascaraplaca
            // 
            this.mascaraplaca.Location = new System.Drawing.Point(480, 44);
            this.mascaraplaca.Mask = "AAA-0A00";
            this.mascaraplaca.Name = "mascaraplaca";
            this.mascaraplaca.Size = new System.Drawing.Size(100, 20);
            this.mascaraplaca.TabIndex = 30;
            // 
            // lblcpf2
            // 
            this.lblcpf2.AutoSize = true;
            this.lblcpf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf2.Location = new System.Drawing.Point(477, 99);
            this.lblcpf2.Name = "lblcpf2";
            this.lblcpf2.Size = new System.Drawing.Size(42, 18);
            this.lblcpf2.TabIndex = 31;
            this.lblcpf2.Text = "CPF ";
            // 
            // lblplaca2
            // 
            this.lblplaca2.AutoSize = true;
            this.lblplaca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca2.Location = new System.Drawing.Point(476, 23);
            this.lblplaca2.Name = "lblplaca2";
            this.lblplaca2.Size = new System.Drawing.Size(55, 18);
            this.lblplaca2.TabIndex = 32;
            this.lblplaca2.Text = "PLACA";
            // 
            // FormularioLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblplaca2);
            this.Controls.Add(this.lblcpf2);
            this.Controls.Add(this.mascaraplaca);
            this.Controls.Add(this.mascaracpf);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblseguro);
            this.Controls.Add(this.cboxcpf);
            this.Controls.Add(this.cboxveiculo);
            this.Controls.Add(this.ckbcseguro);
            this.Controls.Add(this.lbldatadevolucao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbldatalocacao);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsalvar);
            this.Name = "FormularioLocacao";
            this.Text = "FormularioLocacao";
            this.Load += new System.EventHandler(this.FormularioLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lbldatalocacao;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldatadevolucao;
        private System.Windows.Forms.ComboBox cboxveiculo;
        private System.Windows.Forms.ComboBox cboxcpf;
        private System.Windows.Forms.Label lblseguro;
        private System.Windows.Forms.CheckBox ckbcseguro;
        private System.Windows.Forms.MaskedTextBox dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox mascaracpf;
        private System.Windows.Forms.MaskedTextBox mascaraplaca;
        private System.Windows.Forms.Label lblcpf2;
        private System.Windows.Forms.Label lblplaca2;
    }
}