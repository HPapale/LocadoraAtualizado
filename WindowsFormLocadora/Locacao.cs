using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLocadora
{
    public partial class Locacao : Form
    {
       
        public Locacao()
        {
            InitializeComponent();
        }


        private void btnincluir_Click(object sender, EventArgs e)
        {
            FormularioLocacao form = new FormularioLocacao();
            form.ShowDialog();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (dtgridlocacao.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Alterar.");
            }
            else
            {
                DataRowView dr = (DataRowView)dtgridlocacao.Rows[dtgridlocacao.SelectedRows[0].Index].DataBoundItem;

                int linhaSelecionada = int.Parse(dr["os"].ToString());

                MessageBox.Show("O.S é: " + linhaSelecionada);

                FormularioLocacao form = new FormularioLocacao();
                form.CodigoLocacao = linhaSelecionada;
                form.ShowDialog();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Locacao_Load(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM Locacao " +
                "order by os";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            // Fecha conexao com o banco
            con.Close();
            con.Dispose();

            dtgridlocacao.DataSource = dt; // carrega na lista da tela

        }

        private void Delete()
        {
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            DataRowView dr = (DataRowView)dtgridlocacao.Rows[dtgridlocacao.SelectedRows[0].Index].DataBoundItem;

            int linhaSelecionada = int.Parse(dr["os"].ToString());

            // instrucao sql para o banco de dados
            string instrucao = $"delete from locacao where os =" + linhaSelecionada;


            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);


            con.Open();


            try
            {
                //executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso!");
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


        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dtgridlocacao.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Excluir.");

            }

            else
            {
                if (MessageBox.Show("Tem certeza que deseja Excluir? ", "Tela de Locacao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete();


                    DataGridViewRow selectedRow = dtgridlocacao.SelectedRows[0];
                    dtgridlocacao.Rows.Remove(selectedRow);
                }
            }

        }

    }

}
