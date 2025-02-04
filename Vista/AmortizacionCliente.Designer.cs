namespace Vista
{
    partial class AmortizacionCliente
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
            this.dgvAmortizacionCliente = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.comboBoxPrestamos = new System.Windows.Forms.ComboBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortizacionCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmortizacionCliente
            // 
            this.dgvAmortizacionCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmortizacionCliente.Location = new System.Drawing.Point(234, 127);
            this.dgvAmortizacionCliente.Name = "dgvAmortizacionCliente";
            this.dgvAmortizacionCliente.RowHeadersWidth = 51;
            this.dgvAmortizacionCliente.Size = new System.Drawing.Size(519, 278);
            this.dgvAmortizacionCliente.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(62, 318);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(76, 87);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "button1";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // comboBoxPrestamos
            // 
            this.comboBoxPrestamos.FormattingEnabled = true;
            this.comboBoxPrestamos.Location = new System.Drawing.Point(449, 46);
            this.comboBoxPrestamos.Name = "comboBoxPrestamos";
            this.comboBoxPrestamos.Size = new System.Drawing.Size(110, 21);
            this.comboBoxPrestamos.TabIndex = 2;
            this.comboBoxPrestamos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrestamos_SelectedIndexChanged_1);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(402, 46);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(41, 15);
            this.lblFechaActual.TabIndex = 3;
            this.lblFechaActual.Text = "label1";
            // 
            // AmortizacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.comboBoxPrestamos);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dgvAmortizacionCliente);
            this.Name = "AmortizacionCliente";
            this.Text = "AmortizacionCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortizacionCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmortizacionCliente;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox comboBoxPrestamos;
        private System.Windows.Forms.Label lblFechaActual;
    }
}