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
            this.lblMontoMes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 796);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(805, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Siguiente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto pagado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Interes pagado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "Interes por pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(853, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nuevo Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(239, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Prestamo";
            // 
            // lblInteresPagado
            // 
            this.lblInteresPagado.AutoSize = true;
            this.lblInteresPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresPagado.ForeColor = System.Drawing.Color.Navy;
            this.lblInteresPagado.Location = new System.Drawing.Point(336, 209);
            this.lblInteresPagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInteresPagado.Name = "lblInteresPagado";
            this.lblInteresPagado.Size = new System.Drawing.Size(45, 25);
            this.lblInteresPagado.TabIndex = 10;
            this.lblInteresPagado.Text = "000";
            // 
            // lblInteresporPagar
            // 
            this.lblInteresporPagar.AutoSize = true;
            this.lblInteresporPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresporPagar.ForeColor = System.Drawing.Color.Navy;
            this.lblInteresporPagar.Location = new System.Drawing.Point(336, 342);
            this.lblInteresporPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInteresporPagar.Name = "lblInteresporPagar";
            this.lblInteresporPagar.Size = new System.Drawing.Size(45, 25);
            this.lblInteresporPagar.TabIndex = 11;
            this.lblInteresporPagar.Text = "000";
            // 
            // lblFechaAnterior
            // 
            this.lblFechaAnterior.AutoSize = true;
            this.lblFechaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAnterior.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaAnterior.Location = new System.Drawing.Point(336, 444);
            this.lblFechaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAnterior.Name = "lblFechaAnterior";
            this.lblFechaAnterior.Size = new System.Drawing.Size(45, 25);
            this.lblFechaAnterior.TabIndex = 12;
            this.lblFechaAnterior.Text = "000";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaActual.Location = new System.Drawing.Point(615, 444);
            this.lblFechaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(45, 25);
            this.lblFechaActual.TabIndex = 13;
            this.lblFechaActual.Text = "000";
            // 
            // lblFechaSiguiente
            // 
            this.lblFechaSiguiente.AutoSize = true;
            this.lblFechaSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSiguiente.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaSiguiente.Location = new System.Drawing.Point(871, 444);
            this.lblFechaSiguiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaSiguiente.Name = "lblFechaSiguiente";
            this.lblFechaSiguiente.Size = new System.Drawing.Size(45, 25);
            this.lblFechaSiguiente.TabIndex = 14;
            this.lblFechaSiguiente.Text = "000";
            // 
            // lblMontopagado
            // 
            this.lblMontopagado.AutoSize = true;
            this.lblMontopagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontopagado.ForeColor = System.Drawing.Color.Navy;
            this.lblMontopagado.Location = new System.Drawing.Point(615, 197);
            this.lblMontopagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontopagado.Name = "lblMontopagado";
            this.lblMontopagado.Size = new System.Drawing.Size(45, 25);
            this.lblMontopagado.TabIndex = 15;
            this.lblMontopagado.Text = "000";
            // 
            // lblMontoaPagar
            // 
            this.lblMontoaPagar.AutoSize = true;
            this.lblMontoaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoaPagar.ForeColor = System.Drawing.Color.Navy;
            this.lblMontoaPagar.Location = new System.Drawing.Point(615, 308);
            this.lblMontoaPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoaPagar.Name = "lblMontoaPagar";
            this.lblMontoaPagar.Size = new System.Drawing.Size(45, 25);
            this.lblMontoaPagar.TabIndex = 16;
            this.lblMontoaPagar.Text = "000";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(860, 92);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(153, 22);
            this.txtpago.TabIndex = 17;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(843, 124);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(189, 42);
            this.btnRegistrarPago.TabIndex = 18;
            this.btnRegistrarPago.Text = "registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // comboBoxIDprestamo
            // 
            this.comboBoxIDprestamo.FormattingEnabled = true;
            this.comboBoxIDprestamo.Location = new System.Drawing.Point(392, 53);
            this.comboBoxIDprestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxIDprestamo.Name = "comboBoxIDprestamo";
            this.comboBoxIDprestamo.Size = new System.Drawing.Size(143, 24);
            this.comboBoxIDprestamo.TabIndex = 19;
            this.comboBoxIDprestamo.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDprestamo_SelectedIndexChanged);
            // 
            // dgvHistorialPagos
            // 
            this.dgvHistorialPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPagos.Location = new System.Drawing.Point(229, 578);
            this.dgvHistorialPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorialPagos.Name = "dgvHistorialPagos";
            this.dgvHistorialPagos.RowHeadersWidth = 51;
            this.dgvHistorialPagos.Size = new System.Drawing.Size(803, 123);
            this.dgvHistorialPagos.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Navy;
            this.lblTotal.Location = new System.Drawing.Point(871, 308);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 25);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(827, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 36);
            this.label11.TabIndex = 22;
            this.label11.Text = "Monto Total";
            // 
            // lblMontoMes
            // 
            this.lblMontoMes.AutoSize = true;
            this.lblMontoMes.Location = new System.Drawing.Point(912, 66);
            this.lblMontoMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMes.Name = "lblMontoMes";
            this.lblMontoMes.Size = new System.Drawing.Size(28, 16);
            this.lblMontoMes.TabIndex = 23;
            this.lblMontoMes.Text = "000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.cancel_circle_icon_149965;
            this.pictureBox1.Location = new System.Drawing.Point(40, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 741);
            this.Controls.Add(this.lblMontoMes);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMontoMes;
    }
}