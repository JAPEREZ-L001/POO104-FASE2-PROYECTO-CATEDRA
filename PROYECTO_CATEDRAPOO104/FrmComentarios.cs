using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_CATEDRAPOO104
{
    public partial class FrmComentarios : Form
    {
        private string connectionString = "Server=HP-PAVILION-JL\\SQLDEVELOPER;Database=GestionHoteles;Integrated Security=True;Encrypt=False;";

        // 🔹 Para pruebas, se usa un usuario ficticio mientras no haya login
        private int idUsuarioSesion = 1; // <-- Cambiar cuando se conecte el login
        // private int idUsuarioSesion; // <-- Descomentar cuando tengas login
        // private string nombreUsuarioSesion; // <-- Descomentar para mostrar nombre de usuario en lblUsuario

        public FrmComentarios()
        {
            InitializeComponent();
        }

        private void FrmComentarios_Load(object sender, EventArgs e)
        {
            // 🔹 Mostrar usuario (temporal con ID ficticio)
            lblUsuario.Text = "Usuario: UsuarioPrueba";
            // lblUsuario.Text = "Usuario: " + nombreUsuarioSesion; // <-- Descomentar cuando tengas login

            // Inicializar NumericUpDown
            nudCalificacion.Minimum = 1;
            nudCalificacion.Maximum = 5;
            nudCalificacion.Value = 5;

            // Cargar hoteles
            CargarHoteles();

            // Cargar comentarios existentes
            CargarComentariosUsuario();

            // Ajustes DataGridView
            dgvComentarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComentarios.ReadOnly = true;
        }

        private void CargarHoteles()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT IdHotel, NombreHotel
                        FROM Hoteles
                        -- INNER JOIN Reservas R ON H.IdHotel = R.HabitacionId
                        -- WHERE R.IdHuesped = @UsuarioId"; // <-- Depende del login

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // cmd.Parameters.AddWithValue("@UsuarioId", idUsuarioSesion); // <-- Descomentar cuando tengas login

                        conn.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        cmbHoteles.DisplayMember = "NombreHotel";
                        cmbHoteles.ValueMember = "IdHotel";
                        cmbHoteles.DataSource = dt;

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar hoteles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComentariosUsuario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT H.NombreHotel, R.Calificacion, R.Comentario, R.Fecha
                        FROM Resenas R
                        INNER JOIN Hoteles H ON R.HotelId = H.IdHotel
                        WHERE R.HuespedId = @UsuarioId
                        ORDER BY R.Fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioId", idUsuarioSesion);

                        conn.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        dgvComentarios.DataSource = dt;

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar comentarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cmbHoteles.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un hotel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Ingrese un comentario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string insertQuery = @"
                        INSERT INTO Resenas (Calificacion, Comentario, Fecha, HuespedId, HotelId)
                        VALUES (@Calificacion, @Comentario, GETDATE(), @HuespedId, @HotelId)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Calificacion", (int)nudCalificacion.Value);
                        cmd.Parameters.AddWithValue("@Comentario", txtComentario.Text.Trim());
                        cmd.Parameters.AddWithValue("@HuespedId", idUsuarioSesion);
                        cmd.Parameters.AddWithValue("@HotelId", (int)cmbHoteles.SelectedValue);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Comentario enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtComentario.Clear();
                nudCalificacion.Value = 5;

                // Recargar comentarios
                CargarComentariosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar comentario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


