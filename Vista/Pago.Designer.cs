namespace Vista
{
    partial class Pago
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInteresPagado = new System.Windows.Forms.Label();
            this.lblInteresporPagar = new System.Windows.Forms.Label();
            this.lblFechaAnterior = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblFechaSiguiente = new System.Windows.Forms.Label();
            this.lblMontopagado = new System.Windows.Forms.Label();
            this.lblMontoaPagar = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.comboBoxIDprestamo = new System.Windows.Forms.ComboBox();
            this.dgvHistorialPagos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, -33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 521);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Siguiente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto pagado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Interes pagado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Interes por pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(650, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Registrar Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Prestamo";
            // 
            // lblInteresPagado
            // 
            this.lblInteresPagado.AutoSize = true;
            this.lblInteresPagado.Location = new System.Drawing.Point(209, 171);
            this.lblInteresPagado.Name = "lblInteresPagado";
            this.lblInteresPagado.Size = new System.Drawing.Size(41, 13);
            this.lblInteresPagado.TabIndex = 10;
            this.lblInteresPagado.Text = "label10";
            // 
            // lblInteresporPagar
            // 
            this.lblInteresporPagar.AutoSize = true;
            this.lblInteresporPagar.Location = new System.Drawing.Point(209, 273);
            this.lblInteresporPagar.Name = "lblInteresporPagar";
            this.lblInteresporPagar.Size = new System.Drawing.Size(41, 13);
            this.lblInteresporPagar.TabIndex = 11;
            this.lblInteresporPagar.Text = "label11";
            // 
            // lblFechaAnterior
            // 
            this.lblFechaAnterior.AutoSize = true;
            this.lblFechaAnterior.Location = new System.Drawing.Point(222, 356);
            this.lblFechaAnterior.Name = "lblFechaAnterior";
            this.lblFechaAnterior.Size = new System.Drawing.Size(41, 13);
            this.lblFechaAnterior.TabIndex = 12;
            this.lblFechaAnterior.Text = "label12";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(417, 361);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(41, 13);
            this.lblFechaActual.TabIndex = 13;
            this.lblFechaActual.Text = "label13";
            // 
            // lblFechaSiguiente
            // 
            this.lblFechaSiguiente.AutoSize = true;
            this.lblFechaSiguiente.Location = new System.Drawing.Point(538, 356);
            this.lblFechaSiguiente.Name = "lblFechaSiguiente";
            this.lblFechaSiguiente.Size = new System.Drawing.Size(41, 13);
            this.lblFechaSiguiente.TabIndex = 14;
            this.lblFechaSiguiente.Text = "label14";
            // 
            // lblMontopagado
            // 
            this.lblMontopagado.AutoSize = true;
            this.lblMontopagado.Location = new System.Drawing.Point(417, 171);
            this.lblMontopagado.Name = "lblMontopagado";
            this.lblMontopagado.Size = new System.Drawing.Size(41, 13);
            this.lblMontopagado.TabIndex = 15;
            this.lblMontopagado.Text = "label15";
            // 
            // lblMontoaPagar
            // 
            this.lblMontoaPagar.AutoSize = true;
            this.lblMontoaPagar.Location = new System.Drawing.Point(417, 263);
            this.lblMontoaPagar.Name = "lblMontoaPagar";
            this.lblMontoaPagar.Size = new System.Drawing.Size(41, 13);
            this.lblMontoaPagar.TabIndex = 16;
            this.lblMontoaPagar.Text = "label16";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(655, 361);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(116, 20);
            this.txtpago.TabIndex = 17;
            this.txtpago.TextChanged += new System.EventHandler(this.txtpago_TextChanged);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(645, 400);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(142, 34);
            this.btnRegistrarPago.TabIndex = 18;
            this.btnRegistrarPago.Text = "registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // comboBoxIDprestamo
            // 
            this.comboBoxIDprestamo.FormattingEnabled = true;
            this.comboBoxIDprestamo.Location = new System.Drawing.Point(269, 43);
            this.comboBoxIDprestamo.Name = "comboBoxIDprestamo";
            this.comboBoxIDprestamo.Size = new System.Drawing.Size(108, 21);
            this.comboBoxIDprestamo.TabIndex = 19;
            this.comboBoxIDprestamo.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDprestamo_SelectedIndexChanged);
            // 
            // dgvHistorialPagos
            // 
            this.dgvHistorialPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPagos.Location = new System.Drawing.Point(516, 78);
            this.dgvHistorialPagos.Name = "dgvHistorialPagos";
            this.dgvHistorialPagos.Size = new System.Drawing.Size(270, 171);
            this.dgvHistorialPagos.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(666, 43);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Monto Total";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvHistorialPagos);
            this.Controls.Add(this.comboBoxIDprestamo);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.lblMontoaPagar);
            this.Controls.Add(this.lblMontopagado);
            this.Controls.Add(this.lblFechaSiguiente);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.lblFechaAnterior);
            this.Controls.Add(this.lblInteresporPagar);
            this.Controls.Add(this.lblInteresPagado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInteresPagado;
        private System.Windows.Forms.Label lblInteresporPagar;
        private System.Windows.Forms.Label lblFechaAnterior;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblFechaSiguiente;
        private System.Windows.Forms.Label lblMontopagado;
        private System.Windows.Forms.Label lblMontoaPagar;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.ComboBox comboBoxIDprestamo;
        private System.Windows.Forms.DataGridView dgvHistorialPagos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
    }
}