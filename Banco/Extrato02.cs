using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Extrato02 : Form
    {
        ContaCorrente contaCorrente;
        Cadastro cadastro;
        public Extrato02(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;

            dataGridView_Extrato.Rows.Clear();
            dataGridView_Extrato.Columns.Clear();
            dataGridView_Extrato.DataSource = null;
            dataGridView_Extrato.Columns.Add("colData", "Data");
            dataGridView_Extrato.Columns.Add("colOperacao", "Operação");
            dataGridView_Extrato.Columns.Add("colValor", "Valor");

            foreach (KeyValuePair<DateTime, double> kvp in cadastro.DicionarioLogsDeLancamentos)
            {
                dataGridView_Extrato.Rows.Add(kvp.Key.ToString().Split(' ')[0], (kvp.Value < 0) ? "Saque" : "Depósito", kvp.Value.ToString("C2"));
            }
        }

        private void dataGridView_Extrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
