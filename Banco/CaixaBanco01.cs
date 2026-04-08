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
        Lancamento lancamento;
        bool status;
        public CaixaBanco01()
        {
            InitializeComponent();
            textBox_Saldo.Text = ContaBancaria.getSaldoAtual().ToString();
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            if (radioButton_Deposito.Checked)
            {
                status = ContaBancaria.deposito(double.Parse(TextBox_Valor.Text));
                textBox_Saldo.Text = ContaBancaria.getSaldoAtual().ToString();
                Ca

            }
            if (radioButton_Saque.Checked)
            {
                status = ContaBancaria.saque(double.Parse(TextBox_Valor.Text));
                textBox_Saldo.Text = ContaBancaria.getSaldoAtual().ToString();
            }


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
    }
}
