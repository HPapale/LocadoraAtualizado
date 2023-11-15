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
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void FormularioCarro_Load(object sender, EventArgs e)
        {
            CarregaClientes();
            CarregaVeiculo();

            txtplaca.Text = "";
            mskcpf.Text = "";

            Consulta();
        }
        private void Consulta()
        {
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            using (NpgsqlConnection con = new NpgsqlConnection(stringConexao))
            {



                string instrucao = "SELECT * FROM locacao where os > 0 ";


                //instrucao sql para o banco de dados
                //string instrucao = "SELECT * FROM locacao " +
                //  "order by cpf_cliente";

                if (!string.IsNullOrEmpty(txtplaca.Text))
                {
                    instrucao += $" and placa_veiculo ilike '%{txtplaca.Text}%' ";
                }

                if (!string.IsNullOrEmpty(mskcpf.Text))
                {
                    instrucao += $" and cpf_cliente = '{mskcpf.Text}' ";
                }

                if (dateTimeinicio.Value != null && dateTimefinal.Value != null)
                {

                    instrucao += $" and data_locacao >= '{dateTimeinicio.Value.ToShortDateString()}'" +
                        $" and data_devolucao <= '{dateTimefinal.Value.ToShortDateString()}'";
                }


                instrucao += " order by os ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                using (NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }// passa por parametro a instrucao sql


                dtgridformulariocarro.DataSource = dt; // carrega na lista da tela
            }
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void CarregaVeiculo()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                               "User Id=postgres; Password=12345678; DataBase=locadora_car;";
            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM carro";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            txtplaca.DataSource = dt;
            txtplaca.DisplayMember = "placa";
            txtplaca.ValueMember = "codigo";
        }

        private void CarregaClientes()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                               "User Id=postgres; Password=12345678; DataBase=locadora_car;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * from cliente";


            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            mskcpf.DataSource = dt;
            mskcpf.DisplayMember = "cpf";
            mskcpf.ValueMember = "codigo";
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblplaca_Click(object sender, EventArgs e)
        {

        }
    }
}
