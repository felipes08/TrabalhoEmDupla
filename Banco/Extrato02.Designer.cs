namespace Banco
{
    partial class Extrato02
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
            this.dataGridView_Extrato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Extrato)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Extrato
            // 
            this.dataGridView_Extrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Extrato.Location = new System.Drawing.Point(126, 65);
            this.dataGridView_Extrato.Name = "dataGridView_Extrato";
            this.dataGridView_Extrato.RowHeadersWidth = 51;
            this.dataGridView_Extrato.RowTemplate.Height = 24;
            this.dataGridView_Extrato.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_Extrato.TabIndex = 0;
            this.dataGridView_Extrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Extrato_CellContentClick);
            // 
            // Extrato02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Extrato);
            this.Name = "Extrato02";
            this.Text = "Extrato02";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Extrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Extrato;
    }
}