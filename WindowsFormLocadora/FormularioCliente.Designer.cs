namespace WindowsFormLocadora
{
    partial class FormularioCliente
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
            this.txbcliente = new System.Windows.Forms.TextBox();
            this.txbendereco = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.mktxtcpf = new System.Windows.Forms.MaskedTextBox();
            this.mkdTxttelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txbcliente
            // 
            this.txbcliente.Location = new System.Drawing.Point(31, 49);
            this.txbcliente.Name = "txbcliente";
            this.txbcliente.Size = new System.Drawing.Size(416, 20);
            this.txbcliente.TabIndex = 0;
            // 
            // txbendereco
            // 
            this.txbendereco.Location = new System.Drawing.Point(31, 282);
            this.txbendereco.Name = "txbendereco";
            this.txbendereco.Size = new System.Drawing.Size(416, 20);
            this.txbendereco.TabIndex = 3;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalvar.Location = new System.Drawing.Point(587, 38);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(122, 140);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(587, 272);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(122, 140);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(27, 259);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(78, 20);
            this.lblendereco.TabIndex = 6;
            this.lblendereco.Text = "Endereço";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(27, 174);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(71, 20);
            this.lbltelefone.TabIndex = 7;
            this.lbltelefone.Text = "Telefone";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(27, 95);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(40, 20);
            this.lblcpf.TabIndex = 8;
            this.lblcpf.Text = "CPF";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(27, 26);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(104, 20);
            this.lblnome.TabIndex = 9;
            this.lblnome.Text = "Nome Cliente";
            // 
            // mktxtcpf
            // 
            this.mktxtcpf.Location = new System.Drawing.Point(31, 118);
            this.mktxtcpf.Mask = "000,000,000-00";
            this.mktxtcpf.Name = "mktxtcpf";
            this.mktxtcpf.Size = new System.Drawing.Size(162, 20);
            this.mktxtcpf.TabIndex = 12;
            // 
            // mkdTxttelefone
            // 
            this.mkdTxttelefone.Location = new System.Drawing.Point(31, 198);
            this.mkdTxttelefone.Mask = "(00) 00000-0000";
            this.mkdTxttelefone.Name = "mkdTxttelefone";
            this.mkdTxttelefone.Size = new System.Drawing.Size(133, 20);
            this.mkdTxttelefone.TabIndex = 13;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mkdTxttelefone);
            this.Controls.Add(this.mktxtcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txbendereco);
            this.Controls.Add(this.txbcliente);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbcliente;
        private System.Windows.Forms.TextBox txbendereco;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.MaskedTextBox mktxtcpf;
        private System.Windows.Forms.MaskedTextBox mkdTxttelefone;
    }
}