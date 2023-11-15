namespace WindowsFormLocadora
{
    partial class FormularioVeiculo
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
            this.txtbmodelo = new System.Windows.Forms.TextBox();
            this.txtbano = new System.Windows.Forms.TextBox();
            this.txtbchassi = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblchassi = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.lblcor = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalvar.Location = new System.Drawing.Point(604, 48);
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
            this.btnvoltar.Location = new System.Drawing.Point(604, 240);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(122, 140);
            this.btnvoltar.TabIndex = 1;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtbmodelo
            // 
            this.txtbmodelo.Location = new System.Drawing.Point(29, 128);
            this.txtbmodelo.Name = "txtbmodelo";
            this.txtbmodelo.Size = new System.Drawing.Size(400, 20);
            this.txtbmodelo.TabIndex = 3;
            // 
            // txtbano
            // 
            this.txtbano.Location = new System.Drawing.Point(29, 222);
            this.txtbano.Name = "txtbano";
            this.txtbano.Size = new System.Drawing.Size(100, 20);
            this.txtbano.TabIndex = 4;
            // 
            // txtbchassi
            // 
            this.txtbchassi.Location = new System.Drawing.Point(29, 319);
            this.txtbchassi.Name = "txtbchassi";
            this.txtbchassi.Size = new System.Drawing.Size(200, 20);
            this.txtbchassi.TabIndex = 5;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.Location = new System.Drawing.Point(29, 22);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(55, 18);
            this.lblplaca.TabIndex = 6;
            this.lblplaca.Text = "PLACA";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.Location = new System.Drawing.Point(29, 107);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(74, 18);
            this.lblmodelo.TabIndex = 7;
            this.lblmodelo.Text = "MODELO";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblano.Location = new System.Drawing.Point(29, 201);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(40, 18);
            this.lblano.TabIndex = 8;
            this.lblano.Text = "ANO";
            // 
            // lblchassi
            // 
            this.lblchassi.AutoSize = true;
            this.lblchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchassi.Location = new System.Drawing.Point(29, 298);
            this.lblchassi.Name = "lblchassi";
            this.lblchassi.Size = new System.Drawing.Size(62, 18);
            this.lblchassi.TabIndex = 9;
            this.lblchassi.Text = "CHASSI";
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(29, 401);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(200, 20);
            this.txtcor.TabIndex = 11;
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcor.Location = new System.Drawing.Point(29, 380);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(42, 18);
            this.lblcor.TabIndex = 12;
            this.lblcor.Text = "COR";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(32, 43);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 20);
            this.txtplaca.TabIndex = 13;
            // 
            // FormularioVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.lblchassi);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.txtbchassi);
            this.Controls.Add(this.txtbano);
            this.Controls.Add(this.txtbmodelo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsalvar);
            this.Name = "FormularioVeiculo";
            this.Text = "FormularioVeiculo";
            this.Load += new System.EventHandler(this.FormularioVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtbmodelo;
        private System.Windows.Forms.TextBox txtbano;
        private System.Windows.Forms.TextBox txtbchassi;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblchassi;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.TextBox txtplaca;
    }
}