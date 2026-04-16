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
    public partial class CaixaBanco01 : Form
    {
        ContaCorrente ContaBancaria = new ContaCorrente();
        Cadastro logsDeLancamentos = new Cadastro();
        bool status;
        public CaixaBanco01()
        {
            InitializeComponent();
            textBox_Saldo.Text = ContaBancaria.getSaldoAtual().ToString("C2");
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            if (radioButton_Deposito.Checked)
            {
                status = ContaBancaria.deposito(double.Parse(TextBox_Valor.Text));
                textBox_Saldo.Text = ContaBancaria.getSaldoAtual().ToString("C2");
                
                
                if (!status)
                {
                    MessageBox.Show("Não foi possível efetuar o depósito!\nVerifique se o valor do depósito é Valido. São perimitidos depósitos de, no mínimo, R$ 50,00.", "ERRO");
                }
                else
                {
                    Lancamento lancamento = new Lancamento(double.Parse(TextBox_Valor.Text), true);
                    logsDeLancamentos.CadastrarLog(lancamento.DicionarioDoLancamento);
                }
                radioButton_Deposito.Checked = false;
            }
            if (radioButton_Saque.Checked)
            {
                status = ContaBancaria.saque(double.Parse(TextBox_Valor.Text));
                textBox_Saldo.Text = ContaBancaria.getSaldoAtual().ToString("C2");


                if (!status)
                {
                    MessageBox.Show("Não foi possível efetuar o saque!\nVerifique se o valor do saque é Valido. São perimitidos saques com valor mínimo de R$ 10,00.\nVerifique se a conta possui saldo suficiente para efetuar o saque.", "ERRO");
                }
                else
                {
                    Lancamento lancamento = new Lancamento(double.Parse(TextBox_Valor.Text), false);
                    logsDeLancamentos.CadastrarLog(lancamento.DicionarioDoLancamento);
                }
                radioButton_Saque.Checked = false;
                
            }
            TextBox_Valor.Text = "";
            


        }

        private void radioButton_Deposito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Saldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_TESTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExtrato_Click(object sender, EventArgs e)
        {
            Extrato02 extrato02 = new Extrato02(logsDeLancamentos);
            extrato02.ShowDialog();
            //dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            //dataGridView1.DataSource = null;
            //dataGridView1.Columns.Add("colData", "Data");
            //dataGridView1.Columns.Add("colOperacao", "Operação");
            //dataGridView1.Columns.Add("colValor", "Valor");
            
            //foreach (KeyValuePair<DateTime, double> kvp in logsDeLancamentos.DicionarioLogsDeLancamentos)
            //{ 
            //    dataGridView1.Rows.Add(kvp.Key.ToString().Split(' ')[0], (kvp.Value < 0) ? "Saque" : "Depósito", kvp.Value.ToString("C2"));
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
