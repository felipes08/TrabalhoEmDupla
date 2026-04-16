namespace Banco
{
    partial class CaixaBanco01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExtrato = new System.Windows.Forms.Button();
            this.radioButton_Deposito = new System.Windows.Forms.RadioButton();
            this.radioButton_Saque = new System.Windows.Forms.RadioButton();
            this.TextBox_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Saldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Location = new System.Drawing.Point(68, 141);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(173, 42);
            this.buttonExecutar.TabIndex = 0;
            this.buttonExecutar.Text = "Executar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExtrato);
            this.groupBox1.Controls.Add(this.radioButton_Deposito);
            this.groupBox1.Controls.Add(this.radioButton_Saque);
            this.groupBox1.Controls.Add(this.TextBox_Valor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonExecutar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operação";
            // 
            // buttonExtrato
            // 
            this.buttonExtrato.Location = new System.Drawing.Point(68, 189);
            this.buttonExtrato.Name = "buttonExtrato";
            this.buttonExtrato.Size = new System.Drawing.Size(173, 42);
            this.buttonExtrato.TabIndex = 5;
            this.buttonExtrato.Text = "Mostrar Extrato";
            this.buttonExtrato.UseVisualStyleBackColor = true;
            this.buttonExtrato.Click += new System.EventHandler(this.buttonExtrato_Click);
            // 
            // radioButton_Deposito
            // 
            this.radioButton_Deposito.AutoSize = true;
            this.radioButton_Deposito.Location = new System.Drawing.Point(170, 100);
            this.radioButton_Deposito.Name = "radioButton_Deposito";
            this.radioButton_Deposito.Size = new System.Drawing.Size(110, 29);
            this.radioButton_Deposito.TabIndex = 4;
            this.radioButton_Deposito.TabStop = true;
            this.radioButton_Deposito.Text = "Depósito";
            this.radioButton_Deposito.UseVisualStyleBackColor = true;
            this.radioButton_Deposito.CheckedChanged += new System.EventHandler(this.radioButton_Deposito_CheckedChanged);
            // 
            // radioButton_Saque
            // 
            this.radioButton_Saque.AutoSize = true;
            this.radioButton_Saque.Location = new System.Drawing.Point(52, 100);
            this.radioButton_Saque.Name = "radioButton_Saque";
            this.radioButton_Saque.Size = new System.Drawing.Size(91, 29);
            this.radioButton_Saque.TabIndex = 3;
            this.radioButton_Saque.TabStop = true;
            this.radioButton_Saque.Text = "Saque";
            this.radioButton_Saque.UseVisualStyleBackColor = true;
            // 
            // TextBox_Valor
            // 
            this.TextBox_Valor.Location = new System.Drawing.Point(112, 54);
            this.TextBox_Valor.Name = "TextBox_Valor";
            this.TextBox_Valor.Size = new System.Drawing.Size(168, 30);
            this.TextBox_Valor.TabIndex = 2;
            this.TextBox_Valor.TextChanged += new System.EventHandler(this.TextBox_Valor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Saldo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(352, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_Saldo
            // 
            this.textBox_Saldo.Enabled = false;
            this.textBox_Saldo.Location = new System.Drawing.Point(98, 122);
            this.textBox_Saldo.Name = "textBox_Saldo";
            this.textBox_Saldo.Size = new System.Drawing.Size(180, 30);
            this.textBox_Saldo.TabIndex = 1;
            this.textBox_Saldo.TextChanged += new System.EventHandler(this.textBox_Saldo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saldo:";
            // 
            // CaixaBanco01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaixaBanco01";
            this.Text = "Caixa Banco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Deposito;
        private System.Windows.Forms.RadioButton radioButton_Saque;
        private System.Windows.Forms.TextBox TextBox_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExtrato;
    }
}

