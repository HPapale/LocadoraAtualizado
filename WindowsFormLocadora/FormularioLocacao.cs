using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormLocadora
{
    public partial class FormularioLocacao : Form
    {
        public int CodigoLocacao;
        public FormularioLocacao()
        {
            InitializeComponent();
        }

        private void FormularioLocacao_Load(object sender, EventArgs e)
        {
            CarregaClientes();
            CarregaVeiculo();

            if (CodigoLocacao > 0)
            {
                AlterarRegistro();
            }

        }

        private void CarregaVeiculo()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                               "User Id=postgres; Password=12345678; DataBase=locadora_car;";
            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT modelo ||'    - '|| cor ||' -    '|| placa as descricao, codigo FROM carro ";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            cboxveiculo.DataSource = dt;
            cboxveiculo.DisplayMember = "descricao";
            cboxveiculo.ValueMember = "descricao";
        }

        private void CarregaClientes()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                               "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT nome ||'    - '|| cpf as descricao, codigo FROM cliente ";


            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            cboxcpf.DataSource = dt;
            cboxcpf.DisplayMember = "descricao";
            cboxcpf.ValueMember = "descricao";
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    

        private void AlterarRegistro()
        {
            try
            {
                string stringConexao = "Server=localhost; Port=5432; " +
                               "User Id=postgres; Password=12345678; DataBase=locadora_car;";

                // objeto de conexao
                NpgsqlConnection con = new NpgsqlConnection(stringConexao);

                // instrucao sql para o banco de dados
                string instrucao = "SELECT * FROM Locacao " +
                    " where os = " + CodigoLocacao + "; ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                da.Fill(dt); // preenche data table com resultado

                cboxveiculo.Text = dt.Rows[0]["placa_veiculo"].ToString();
                cboxcpf.Text = dt.Rows[0]["cpf_cliente"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["data_locacao"].ToString();
                dateTimePicker2.Text = dt.Rows[0]["data_devolucao"].ToString();
                txtvalor.Text = dt.Rows[0]["valor_pago"].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao pesquisar Carro: " + erro.Message);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost; Port=5432; " +
                               "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            decimal valorTotal = decimal.Parse(txtvalor.Text);//.Trim().Replace("R$", " ").Replace(".", ","));

            string seguro = ckbcseguro.Checked ? "Sim" : "Nao";

            string instrucao = " ";
  
           
            // instrucao sql para o banco de dados

            if (CodigoLocacao > 0)
            {
                instrucao = $"update locacao set placa_veiculo = '{mascaraplaca.Text}'" +
                    $" cpf_cliente = '{mascaracpf.Text}', valor_pago = {valorTotal}" +
                    $" nome_cliente = '{cboxcpf.Text}' " +
                    $" data_locacao = '{dateTimePicker1.Text}', data_devolucao = '{dateTimePicker2.Text}'," +                 
                    $" where os = '{CodigoLocacao}'";
            }
            else
            {
                instrucao = "insert into locacao(placa_veiculo, cpf_cliente, nome_cliente, valor_pago, data_locacao, data_devolucao)" +
                "values ('" + mascaraplaca.Text + "','" + mascaracpf.Text + "','" + cboxcpf.Text + "'," + valorTotal + " ,'" + dateTimePicker1.Text + "',"+ 
                "'" + dateTimePicker2.Text + "')";
            }
                
            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);

            con.Open();

            try
            {
                //executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro salvo com Sucesso!");
                Close();

            }
            catch (Exception ex)
            {
                // se ocorrer erro da uma msg
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fecha a conexao
                con.Close(); con.Dispose();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
