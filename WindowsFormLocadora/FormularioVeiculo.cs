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

namespace WindowsFormLocadora
{
    public partial class FormularioVeiculo : Form
    {
        public int CodigoVeiculo;
        public FormularioVeiculo()
        {
            InitializeComponent();
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

            // instrucao sql para o banco de dados
            string instrucao = "insert into Carro (placa, modelo, ano, chassi, cor) " +
            "values ('" + txtplaca.Text + "','" + txtbmodelo.Text + "', '" + txtbano.Text + "', '" + txtbchassi.Text + "', '" + txtcor.Text + "'); ";

            if (CodigoVeiculo > 0)
            {
                instrucao = $"update Carro set placa='{txtplaca.Text}', modelo='{txtbmodelo.Text}', ano='{txtbano.Text}', chassi='{txtbchassi.Text}', cor='{txtcor.Text}' " +
                    $" where codigo={CodigoVeiculo}";
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

        private void FormularioVeiculo_Load(object sender, EventArgs e)
        {
            if (CodigoVeiculo > 0)
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
                    string instrucao = "SELECT * FROM Carro " +
                        " where codigo = " + CodigoVeiculo + "; ";

                    DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                    NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                    da.Fill(dt); // preenche data table com resultado

                    txtplaca.Text = dt.Rows[0]["placa"].ToString();
                    txtbmodelo.Text = dt.Rows[0]["modelo"].ToString();
                    txtbano.Text = dt.Rows[0]["ano"].ToString();
                    txtbchassi.Text = dt.Rows[0]["chassi"].ToString();
                    txtcor.Text = dt.Rows[0]["cor"].ToString();
            }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao pesquisar Carro: " + erro.Message);
                }
            }
        
    }
}
