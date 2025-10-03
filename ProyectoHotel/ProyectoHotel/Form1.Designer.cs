namespace ProyectoHotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIdHotel = new TextBox();
            txtNombreHotel = new TextBox();
            txtDirHotel = new TextBox();
            cmbCiudad = new ComboBox();
            cmbPais = new ComboBox();
            cmbEstrellas = new ComboBox();
            txtDescripcion = new TextBox();
            chkWifi = new CheckBox();
            chkParqueo = new CheckBox();
            chkActivo = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 38);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 4;
            label1.Text = "Mantenimiento de Hoteles";
            // 
            // txtIdHotel
            // 
            txtIdHotel.Enabled = false;
            txtIdHotel.Location = new Point(291, 125);
            txtIdHotel.Name = "txtIdHotel";
            txtIdHotel.Size = new Size(125, 27);
            txtIdHotel.TabIndex = 5;
            // 
            // txtNombreHotel
            // 
            txtNombreHotel.Location = new Point(291, 176);
            txtNombreHotel.Name = "txtNombreHotel";
            txtNombreHotel.Size = new Size(125, 27);
            txtNombreHotel.TabIndex = 6;
            // 
            // txtDirHotel
            // 
            txtDirHotel.Location = new Point(291, 223);
            txtDirHotel.Name = "txtDirHotel";
            txtDirHotel.Size = new Size(125, 27);
            txtDirHotel.TabIndex = 7;
            // 
            // cmbCiudad
            // 
            cmbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(291, 336);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(151, 28);
            cmbCiudad.TabIndex = 8;
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(291, 275);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(151, 28);
            cmbPais.TabIndex = 9;
            // 
            // cmbEstrellas
            // 
            cmbEstrellas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstrellas.FormattingEnabled = true;
            cmbEstrellas.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbEstrellas.Location = new Point(701, 125);
            cmbEstrellas.Name = "cmbEstrellas";
            cmbEstrellas.Size = new Size(151, 28);
            cmbEstrellas.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(701, 170);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(365, 133);
            txtDescripcion.TabIndex = 11;
            // 
            // chkWifi
            // 
            chkWifi.AutoSize = true;
            chkWifi.Location = new Point(701, 332);
            chkWifi.Name = "chkWifi";
            chkWifi.Size = new Size(58, 24);
            chkWifi.TabIndex = 12;
            chkWifi.Text = "Wifi";
            chkWifi.UseVisualStyleBackColor = true;
            // 
            // chkParqueo
            // 
            chkParqueo.AutoSize = true;
            chkParqueo.Location = new Point(832, 332);
            chkParqueo.Name = "chkParqueo";
            chkParqueo.Size = new Size(85, 24);
            chkParqueo.TabIndex = 13;
            chkParqueo.Text = "Parqueo";
            chkParqueo.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(965, 332);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 14;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 125);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 15;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 173);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 223);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 17;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 336);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 18;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 275);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 19;
            label6.Text = "País";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(591, 125);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 20;
            label7.Text = "Estrellas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 170);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 21;
            label8.Text = "Descripción";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(304, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(471, 420);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(630, 420);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 512);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chkActivo);
            Controls.Add(chkParqueo);
            Controls.Add(chkWifi);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbEstrellas);
            Controls.Add(cmbPais);
            Controls.Add(cmbCiudad);
            Controls.Add(txtDirHotel);
            Controls.Add(txtNombreHotel);
            Controls.Add(txtIdHotel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtIdHotel;
        private TextBox txtNombreHotel;
        private TextBox txtDirHotel;
        private ComboBox cmbCiudad;
        private ComboBox cmbPais;
        private ComboBox cmbEstrellas;
        private TextBox txtDescripcion;
        private CheckBox chkWifi;
        private CheckBox chkParqueo;
        private CheckBox chkActivo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnLimpiar;
    }
}
