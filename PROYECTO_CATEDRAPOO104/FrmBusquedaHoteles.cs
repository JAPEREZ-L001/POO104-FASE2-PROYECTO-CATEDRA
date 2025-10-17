using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
#region Snippet: Version Funcional
namespace PROYECTO_CATEDRAPOO104
{
    public partial class FrmBusquedaHoteles : Form
    {
        // 🔹 Cadena de conexión a tu base de datos
        private string connectionString = "Server=HP-PAVILION-JL\\SQLDEVELOPER;Database=GestionHoteles;Integrated Security=True;Encrypt=False;";

        public FrmBusquedaHoteles()
        {
            InitializeComponent();
        }

        private void FrmBusquedaHoteles_Load(object sender, EventArgs e)
        {

            // Maximizar el formulario al cargar
            this.WindowState = FormWindowState.Maximized;

            // Inicializar controles
            dtpEntrada.MinDate = DateTime.Today;
            dtpSalida.MinDate = DateTime.Today.AddDays(1);
            nudCapacidad.Minimum = 1;
            nudCapacidad.Maximum = 10;
            nudCapacidad.Value = 2;

            // Configurar DataGridView
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.MultiSelect = false;
            dgvResultados.ReadOnly = true;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCapacidad_ValueChanged(object sender, EventArgs e)
        {

        }

    

        private void dgvResultados_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvResultados.SelectedRows.Count > 0)
            {
                var fila = dgvResultados.SelectedRows[0];

                // Llenar los TextBox de detalles
                txtNombreHotel.Text = fila.Cells["NombreHotel"].Value?.ToString() ?? "";
                txtDireccionHotel.Text = fila.Cells["DireccionHotel"].Value?.ToString() ?? "";
                txtDescripcionHotel.Text = fila.Cells["DescripcionHotel"].Value?.ToString() ?? "";
                txtPrecioMinimo.Text = fila.Cells["PrecioMinimo"].Value?.ToString() ?? "";
                txtCalificacionPromedio.Text = fila.Cells["CalificacionPromedio"].Value?.ToString() ?? "";
                txtComodidades.Text = fila.Cells["Comodidades"].Value?.ToString() ?? "";
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreHotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcionHotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionHotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalificacionPromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComodidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SP_BuscarHotelesConDetalles", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros del SP
                    cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pais", txtPais.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaEntrada", dtpEntrada.Value.Date);
                    cmd.Parameters.AddWithValue("@FechaSalida", dtpSalida.Value.Date);
                    cmd.Parameters.AddWithValue("@Capacidad", (int)nudCapacidad.Value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Asignar al DataGridView
                    dgvResultados.DataSource = dt;

                    // Ocultar IdHotel
                    if (dgvResultados.Columns.Contains("IdHotel"))
                        dgvResultados.Columns["IdHotel"].Visible = false;

                    // Mensaje si no hay resultados
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No se encontraron hoteles disponibles.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar hoteles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
#endregion

