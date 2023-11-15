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
    public partial class Veiculo : Form
    {
        private void Excluir()
        {
            string stringConexao = "Server=localhost; Port=5432; " +
               "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            DataRowView dr = (DataRowView)dtgridveiculo.Rows[dtgridveiculo.SelectedRows[0].Index].DataBoundItem;

            int linhaSelecionada = int.Parse(dr["codigo"].ToString());

            // instrucao sql para o banco de dados
            string instrucao = $"delete from carro where codigo =" + linhaSelecionada;


            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);


            con.Open();


            try
            {
                //executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido com Sucesso!");
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
        public Veiculo()
        {
            InitializeComponent();

            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM Carro " +
                "order by placa";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            // Fecha conexao com o banco
            con.Close();
            con.Dispose();

            dtgridveiculo.DataSource = dt; // carrega na lista da tela
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            FormularioVeiculo form = new FormularioVeiculo();
            form.ShowDialog();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dtgridveiculo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Excluir.");

            }

            else
            {
                if (MessageBox.Show("Tem certeza que deseja Excluir? ", "Tela de Veiculo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Excluir();


                    DataGridViewRow selectedRow = dtgridveiculo.SelectedRows[0];
                    dtgridveiculo.Rows.Remove(selectedRow);
                }

            }
        }

        private void Veiculo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (dtgridveiculo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Alterar.");
            }
            else
            {
                DataRowView dr = (DataRowView)dtgridveiculo.Rows[dtgridveiculo.SelectedRows[0].Index].DataBoundItem;

                int linhaSelecionada = int.Parse(dr["codigo"].ToString());

                MessageBox.Show("Placa do Veiculo é: " + linhaSelecionada);

                FormularioVeiculo form = new FormularioVeiculo();
                form.CodigoVeiculo = linhaSelecionada;
                form.ShowDialog();
            }
        }
    }
}
