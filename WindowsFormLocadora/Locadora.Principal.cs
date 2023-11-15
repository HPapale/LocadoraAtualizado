using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLocadora
{
    public partial class FormLocadora : Form
    {
        public FormLocadora()
        {
            InitializeComponent();
        }

        private void FormLocadora_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {

            {
                MessageBox.Show("Deseja realmente Sair?");
                Close();
            }
            {
                Application.Exit();
            }
            
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.ShowDialog();
        }

        private void btnveiculo_Click(object sender, EventArgs e)
        {
             Veiculo form = new Veiculo();
             form.ShowDialog();

        }

        private void btnlocacao_Click(object sender, EventArgs e)
        {
            Locacao form = new Locacao();
            form.ShowDialog();
        }

        private void btnfinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro form = new Financeiro();
            form.ShowDialog();
        }
    }
    
}
