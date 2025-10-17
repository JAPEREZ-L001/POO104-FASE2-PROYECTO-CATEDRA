namespace PROYECTO_CATEDRAPOO104
{
    partial class FrmBusquedaHoteles
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
            label1 = new Label();
            dgvResultados = new DataGridView();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblCiudad = new Label();
            txtCiudad = new TextBox();
            lblPais = new Label();
            txtPais = new TextBox();
            lblFechaEntrada = new Label();
            dtpEntrada = new DateTimePicker();
            lblFechaSalida = new Label();
            dtpSalida = new DateTimePicker();
            btnBuscar = new Button();
            nudCapacidad = new NumericUpDown();
            lblCapacidad = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txtComodidades = new TextBox();
            label7 = new Label();
            txtCalificacionPromedio = new TextBox();
            label6 = new Label();
            txtPrecioMinimo = new TextBox();
            label5 = new Label();
            txtDescripcionHotel = new TextBox();
            label4 = new Label();
            txtDireccionHotel = new TextBox();
            label3 = new Label();
            NombreHotel = new Label();
            txtNombreHotel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 503);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 11;
            label1.Text = "Resultados de búsqueda";
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(60, 556);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(950, 85);
            dgvResultados.TabIndex = 12;
            dgvResultados.CellContentClick += dgvResultados_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiudad);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(lblPais);
            groupBox1.Controls.Add(txtPais);
            groupBox1.Controls.Add(lblFechaEntrada);
            groupBox1.Controls.Add(dtpEntrada);
            groupBox1.Controls.Add(lblFechaSalida);
            groupBox1.Controls.Add(dtpSalida);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(nudCapacidad);
            groupBox1.Controls.Add(lblCapacidad);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 399);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "🔎 Búsqueda de Hoteles";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(31, 39);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 11;
            lblCiudad.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(130, 40);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PlaceholderText = "Ej: San Salvador";
            txtCiudad.Size = new Size(125, 27);
            txtCiudad.TabIndex = 12;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(280, 43);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(37, 20);
            lblPais.TabIndex = 13;
            lblPais.Text = "País:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(334, 39);
            txtPais.Name = "txtPais";
            txtPais.PlaceholderText = "Ej: El Salvador";
            txtPais.Size = new Size(125, 27);
            txtPais.TabIndex = 14;
            // 
            // lblFechaEntrada
            // 
            lblFechaEntrada.AutoSize = true;
            lblFechaEntrada.Location = new Point(16, 110);
            lblFechaEntrada.Name = "lblFechaEntrada";
            lblFechaEntrada.Size = new Size(126, 20);
            lblFechaEntrada.TabIndex = 15;
            lblFechaEntrada.Text = "Fecha de entrada:";
            // 
            // dtpEntrada
            // 
            dtpEntrada.Format = DateTimePickerFormat.Short;
            dtpEntrada.Location = new Point(148, 110);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(250, 27);
            dtpEntrada.TabIndex = 16;
            dtpEntrada.Value = new DateTime(2025, 10, 16, 19, 34, 16, 0);
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(16, 168);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(114, 20);
            lblFechaSalida.TabIndex = 17;
            lblFechaSalida.Text = "Fecha de salida:";
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Short;
            dtpSalida.Location = new Point(148, 163);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(250, 27);
            dtpSalida.TabIndex = 18;
            dtpSalida.Value = new DateTime(2025, 10, 16, 19, 34, 16, 0);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(161, 349);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar Hoteles";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(148, 262);
            nudCapacidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(150, 27);
            nudCapacidad.TabIndex = 20;
            nudCapacidad.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(31, 264);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(83, 20);
            lblCapacidad.TabIndex = 19;
            lblCapacidad.Text = "Capacidad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtComodidades);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCalificacionPromedio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPrecioMinimo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDescripcionHotel);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDireccionHotel);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(NombreHotel);
            groupBox2.Controls.Add(txtNombreHotel);
            groupBox2.Location = new Point(565, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 394);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Hoteles";
            // 
            // button1
            // 
            button1.Location = new Point(182, 349);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 39;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtComodidades
            // 
            txtComodidades.Location = new Point(200, 290);
            txtComodidades.Name = "txtComodidades";
            txtComodidades.ReadOnly = true;
            txtComodidades.Size = new Size(181, 27);
            txtComodidades.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 295);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 37;
            label7.Text = "Comodidades:";
            // 
            // txtCalificacionPromedio
            // 
            txtCalificacionPromedio.Location = new Point(202, 242);
            txtCalificacionPromedio.Name = "txtCalificacionPromedio";
            txtCalificacionPromedio.ReadOnly = true;
            txtCalificacionPromedio.Size = new Size(181, 27);
            txtCalificacionPromedio.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 247);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 35;
            label6.Text = "Calificación promedio:";
            // 
            // txtPrecioMinimo
            // 
            txtPrecioMinimo.Location = new Point(200, 194);
            txtPrecioMinimo.Name = "txtPrecioMinimo";
            txtPrecioMinimo.ReadOnly = true;
            txtPrecioMinimo.Size = new Size(181, 27);
            txtPrecioMinimo.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 201);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 33;
            label5.Text = "Precio mínimo:";
            // 
            // txtDescripcionHotel
            // 
            txtDescripcionHotel.Location = new Point(200, 96);
            txtDescripcionHotel.Name = "txtDescripcionHotel";
            txtDescripcionHotel.ReadOnly = true;
            txtDescripcionHotel.Size = new Size(181, 27);
            txtDescripcionHotel.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 96);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 31;
            label4.Text = "Descripción del Hotel:";
            // 
            // txtDireccionHotel
            // 
            txtDireccionHotel.Location = new Point(200, 150);
            txtDireccionHotel.Name = "txtDireccionHotel";
            txtDireccionHotel.ReadOnly = true;
            txtDireccionHotel.Size = new Size(181, 27);
            txtDireccionHotel.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 157);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 29;
            label3.Text = "Direccíon:";
            // 
            // NombreHotel
            // 
            NombreHotel.AutoSize = true;
            NombreHotel.Location = new Point(38, 48);
            NombreHotel.Name = "NombreHotel";
            NombreHotel.Size = new Size(135, 20);
            NombreHotel.TabIndex = 28;
            NombreHotel.Text = "Nombre Del Hotel:";
            // 
            // txtNombreHotel
            // 
            txtNombreHotel.Location = new Point(200, 46);
            txtNombreHotel.Name = "txtNombreHotel";
            txtNombreHotel.ReadOnly = true;
            txtNombreHotel.Size = new Size(181, 27);
            txtNombreHotel.TabIndex = 27;
            // 
            // FrmBusquedaHoteles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 855);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dgvResultados);
            Controls.Add(label1);
            Name = "FrmBusquedaHoteles";
            Text = "BusquedaHoteles";
            Load += FrmBusquedaHoteles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvResultados;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblCiudad;
        private TextBox txtCiudad;
        private Label lblPais;
        private TextBox txtPais;
        private Label lblFechaEntrada;
        private DateTimePicker dtpEntrada;
        private Label lblFechaSalida;
        private DateTimePicker dtpSalida;
        private Button btnBuscar;
        private NumericUpDown nudCapacidad;
        private Label lblCapacidad;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox txtComodidades;
        private Label label7;
        private TextBox txtCalificacionPromedio;
        private Label label6;
        private TextBox txtPrecioMinimo;
        private Label label5;
        private TextBox txtDescripcionHotel;
        private Label label4;
        private TextBox txtDireccionHotel;
        private Label label3;
        private Label NombreHotel;
        private TextBox txtNombreHotel;
    }
}