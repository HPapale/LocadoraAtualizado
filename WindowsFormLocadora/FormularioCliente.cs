using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormLocadora
{
    public partial class FormularioCliente : Form
    {
        public int CodigoCliente;
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            if (CodigoCliente > 0)
            {
                AlterarRegistro();
            }
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
                string instrucao = "SELECT * FROM Cliente " +
                    " where codigo = " + CodigoCliente + "; ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                da.Fill(dt); // preenche data table com resultado

                txbcliente.Text = dt.Rows[0]["nome"].ToString();
                mktxtcpf.Text = dt.Rows[0]["cpf"].ToString();
                mkdTxttelefone.Text = dt.Rows[0]["telefone"].ToString();
                txbendereco.Text = dt.Rows[0]["endereco"].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao pesquisar Fornecedor: " + erro.Message);
            }
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost; Port=5432; " +
                "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "insert into Cliente (nome, cpf, telefone, endereco) " +
                "values ('" + txbcliente.Text + "', '" + mktxtcpf.Text + "'," +
                " '" + mkdTxttelefone.Text + "', '" + txbendereco.Text + "'); ";

            if (CodigoCliente > 0)
            {
                instrucao = $"update Cliente set nome='{txbcliente.Text}', " +
                    $"cpf='{mktxtcpf.Text}', " +
                    $"telefone='{mkdTxttelefone.Text}'," +
                    $"endereco='{txbendereco.Text}'" +
                    $" where codigo={CodigoCliente}";
            }


            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);


            con.Open();


            try
            {
                //executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro salvo com sucesso!");
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
    }
}
