namespace PROYECTO_CATEDRAPOO104
{
    partial class FrmComentarios
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
            lblUsuario = new Label();
            cmbHoteles = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            nudCalificacion = new NumericUpDown();
            label4 = new Label();
            txtComentario = new TextBox();
            btnEnviar = new Button();
            dgvComentarios = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCalificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(51, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario: ";
            //lblUsuario.Click += label1_Click;
            // 
            // cmbHoteles
            // 
            cmbHoteles.FormattingEnabled = true;
            cmbHoteles.Location = new Point(51, 129);
            cmbHoteles.Name = "cmbHoteles";
            cmbHoteles.Size = new Size(151, 28);
            cmbHoteles.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 193);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Calificación:";
            //label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 89);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 3;
            label3.Text = "Seleccione su Hotel: ";
            // 
            // nudCalificacion
            // 
            nudCalificacion.Location = new Point(52, 232);
            nudCalificacion.Name = "nudCalificacion";
            nudCalificacion.Size = new Size(150, 27);
            nudCalificacion.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 279);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 5;
            label4.Text = "Comentario:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(51, 318);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(125, 27);
            txtComentario.TabIndex = 6;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(61, 371);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // dgvComentarios
            // 
            dgvComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComentarios.Location = new Point(361, 146);
            dgvComentarios.Name = "dgvComentarios";
            dgvComentarios.RowHeadersWidth = 51;
            dgvComentarios.Size = new Size(300, 188);
            dgvComentarios.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 105);
            label5.Name = "label5";
            label5.Size = new Size(298, 20);
            label5.TabIndex = 9;
            label5.Text = "Mostrar los comentarios previos del usuario";
            // 
            // FrmComentarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dgvComentarios);
            Controls.Add(btnEnviar);
            Controls.Add(txtComentario);
            Controls.Add(label4);
            Controls.Add(nudCalificacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbHoteles);
            Controls.Add(lblUsuario);
            Name = "FrmComentarios";
            Text = "FrmComentarios";
            Load += FrmComentarios_Load;
            ((System.ComponentModel.ISupportInitialize)nudCalificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private ComboBox cmbHoteles;
        private Label label2;
        private Label label3;
        private NumericUpDown nudCalificacion;
        private Label label4;
        private TextBox txtComentario;
        private Button btnEnviar;
        private DataGridView dgvComentarios;
        private Label label5;
    }
}