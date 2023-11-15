namespace WindowsFormLocadora
{
    partial class Financeiro
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
            this.dtgridformulariocarro = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.dateTimeinicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimefinal = new System.Windows.Forms.DateTimePicker();
            this.mskcpf = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.ComboBox();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa_veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridformulariocarro)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridformulariocarro
            // 
            this.dtgridformulariocarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridformulariocarro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.os,
            this.cliente,
            this.cpf,
            this.placa_veiculo,
            this.total,
            this.final,
            this.Valor});
            this.dtgridformulariocarro.Location = new System.Drawing.Point(15, 154);
            this.dtgridformulariocarro.Name = "dtgridformulariocarro";
            this.dtgridformulariocarro.Size = new System.Drawing.Size(785, 176);
            this.dtgridformulariocarro.TabIndex = 0;
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconsultar.Location = new System.Drawing.Point(12, 373);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(232, 65);
            this.btnconsultar.TabIndex = 1;
            this.btnconsultar.Text = "CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Chocolate;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(305, 373);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(232, 65);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.Location = new System.Drawing.Point(12, 9);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(60, 18);
            this.lblplaca.TabIndex = 5;
            this.lblplaca.Text = "PLACA";
            this.lblplaca.Click += new System.EventHandler(this.lblplaca_Click);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(265, 9);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(41, 18);
            this.lblcpf.TabIndex = 6;
            this.lblcpf.Text = "CPF";
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(12, 95);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(109, 18);
            this.lblinicio.TabIndex = 8;
            this.lblinicio.Text = "DATA INICIO:";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.Location = new System.Drawing.Point(265, 95);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(105, 18);
            this.lblfinal.TabIndex = 9;
            this.lblfinal.Text = "DATA FINAL:";
            // 
            // dateTimeinicio
            // 
            this.dateTimeinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeinicio.Location = new System.Drawing.Point(15, 117);
            this.dateTimeinicio.Name = "dateTimeinicio";
            this.dateTimeinicio.Size = new System.Drawing.Size(131, 20);
            this.dateTimeinicio.TabIndex = 10;
            // 
            // dateTimefinal
            // 
            this.dateTimefinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimefinal.Location = new System.Drawing.Point(268, 117);
            this.dateTimefinal.Name = "dateTimefinal";
            this.dateTimefinal.Size = new System.Drawing.Size(144, 20);
            this.dateTimefinal.TabIndex = 11;
            // 
            // mskcpf
            // 
            this.mskcpf.FormattingEnabled = true;
            this.mskcpf.Location = new System.Drawing.Point(268, 30);
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(121, 21);
            this.mskcpf.TabIndex = 12;
            // 
            // txtplaca
            // 
            this.txtplaca.FormattingEnabled = true;
            this.txtplaca.Location = new System.Drawing.Point(15, 30);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(121, 21);
            this.txtplaca.TabIndex = 13;
            // 
            // os
            // 
            this.os.DataPropertyName = "os";
            this.os.HeaderText = "O.S";
            this.os.Name = "os";
            this.os.Width = 70;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "nome_cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.Width = 220;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf_cliente";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.Width = 120;
            // 
            // placa_veiculo
            // 
            this.placa_veiculo.DataPropertyName = "placa_veiculo";
            this.placa_veiculo.HeaderText = "Placa";
            this.placa_veiculo.Name = "placa_veiculo";
            this.placa_veiculo.Width = 90;
            // 
            // total
            // 
            this.total.DataPropertyName = "data_locacao";
            this.total.HeaderText = "Data Inicio Locação";
            this.total.Name = "total";
            this.total.Width = 80;
            // 
            // final
            // 
            this.final.DataPropertyName = "data_devolucao";
            this.final.HeaderText = "Data Final Locação";
            this.final.Name = "final";
            this.final.Width = 80;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor_pago";
            this.Valor.HeaderText = "Valor Total $";
            this.Valor.Name = "Valor";
            this.Valor.Width = 80;
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.dateTimefinal);
            this.Controls.Add(this.dateTimeinicio);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.dtgridformulariocarro);
            this.Name = "Financeiro";
            this.Text = "Financeiro";
            this.Load += new System.EventHandler(this.FormularioCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridformulariocarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridformulariocarro;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.DateTimePicker dateTimeinicio;
        private System.Windows.Forms.DateTimePicker dateTimefinal;
        private System.Windows.Forms.ComboBox mskcpf;
        private System.Windows.Forms.ComboBox txtplaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa_veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}