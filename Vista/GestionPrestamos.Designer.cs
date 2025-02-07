namespace Vista
{
    partial class GestionPrestamos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtTiempoMeses = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 615);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.cancel_circle_icon_149965;
            this.pictureBox1.Location = new System.Drawing.Point(40, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(510, 300);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(217, 20);
            this.txtGarantia.TabIndex = 2;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(510, 243);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(217, 20);
            this.txtSueldo.TabIndex = 3;
            // 
            // txtTiempoMeses
            // 
            this.txtTiempoMeses.Location = new System.Drawing.Point(510, 184);
            this.txtTiempoMeses.Name = "txtTiempoMeses";
            this.txtTiempoMeses.Size = new System.Drawing.Size(217, 20);
            this.txtTiempoMeses.TabIndex = 4;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(510, 131);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(217, 20);
            this.txtMontoPrestamo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(224, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 67);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(522, 203);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Garantia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(510, 41);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(217, 21);
            this.comboBoxClientes.TabIndex = 14;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cliente ID";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(224, 84);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(89, 67);
            this.btnRefrescar.TabIndex = 16;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // GestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 602);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.txtTiempoMeses);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPrestamos";
            this.Text = "GestionPrestamos";
            this.Load += new System.EventHandler(this.GestionPrestamos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtTiempoMeses;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrescar;
    }
}