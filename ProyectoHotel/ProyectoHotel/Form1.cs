using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionBD;
using Microsoft.Data.SqlClient;

namespace ProyectoHotel
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        // nuevo tipo de variable Dictionary para poder llenar los combobox paises y ciudades
        // investigada en el video https://www.youtube.com/watch?v=R94JHIXdTk0

        private Dictionary<string, List<string>> PaisesyCiudades = new()
        {
            { "Guatemala", new List<string> {
                "Ciudad de Guatemala", "Quetzaltenango", "Escuintla", 
                "Huehuetenango",   "Chimaltenano",  "Cobán", 
                "Puerto Barrios",  "Jalapa",  "Jutiapa", 
                "Retalhuleu",  "Sololá",   "Totonicapán",
                "Santa Lucía Cotzumalguapa",  "San Marcos",  "Mazatenango",   
                "Zacapa",  "Chiquimula"
            }},
            { "El Salvador", new List<string> {
                "San Salvador", "Santa Ana", "San Miguel", 
                "Soyapango", "Mejicanos", "Apopa",
                "Delgado", "Santa Tecla", "Ahuachapán", 
                "Ilopango", "Usulután", "Sonsonate", 
                "La Libertad", "San Vicente", "Zacatecoluca", 
                "La Unión", "Chalatenango "
            }},
            { "Honduras", new List<string> {
                "Tegucigalpa", "San Pedro Sula", "La Ceiba", 
                "Choluteca", "Comayagua",   "El Progreso", 
                "Puerto Cortés", "Danlí", "Juticalpa", 
                "Tela", "Santa Rosa de Copán", "La Lima",
                "Villanueva", "Yoro", "Tocoa ", 
                "Siguatepeque", "Trujillo"
            }},
            { "Nicaragua", new List<string> {
                "Managua", "León", "Granada", 
                "Masaya", "Chinandega", "Estelí", 
                "Matagalpa", "Jinotega", "Bluefields",
                "Rivas", "Somoto",    "Boaco ", 
                "Ocotal", "San Carlos", "Juigalpa", 
                "Diriamba", "Tipitapa"
            }},
            { "Costa Rica", new List<string> {
                "San José", "Alajuela", "Cartago" ,
                "Heredia", "Puntarenas", "Limón", 
                "Liberia ", "San Carlos", "Grecia", 
                "Desamparados", "Curridabat", "Escazú ", 
                "Santa Ana", "Pérez Zeledón", "Goicoechea",
                "Turrialba", "Siquirres"
            }},
            { "Panamá", new List<string> {
                "Ciudad de Panamá", "Colón", "David", 
                "Santiago", "Chitré",      "La Chorrera", 
                "Penonomé", "Aguadulce ", "Arraiján",
                "Las Tablas" , "Puerto Armuelles",   "Almirante",
                "Chepo", "Boquete", "Bocas del Toro", 
                "Antón", "San Miguelito"
            }},
            { "Belice", new List<string> {
                "Belmopán", "Ciudad de Belice", "San Ignacio",
                "Orange Walk", "Corozal", "Dangriga",
                "Punta Gorda ", "San Pedro", "Benque Viejo", 
                "Ladyville", "Cayo",     "Santa Elena",
                "Independence",  "Hopkins", "Placencia",
                "Burrell Boom", "Trial Farm "
            }}
        };
        public Form1()
        {
            InitializeComponent();

            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPais.Items.Clear(); 
            cmbPais.Items.AddRange(PaisesyCiudades.Keys.ToArray()); //Voy a usar esto
            //para agregar los paises al cmbPais.

            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged;
            //Para cuando el usuario elija un pais, se llame el metodo para llenar las ciudades
        }
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCiudad.Items.Clear();// primero siempre se limpian las ciudades del cmbCiudad
            //sino se van a seguir agregando y se va a ver mal

            List<string> ciudades;

            if (cmbPais.SelectedItem != null && 
                PaisesyCiudades.TryGetValue(cmbPais.SelectedItem.ToString(), 
                out ciudades))
            {
                cmbCiudad.Items.AddRange(ciudades.ToArray());
                if (cmbCiudad.Items.Count > 0)
                    cmbCiudad.SelectedIndex = 0;
            }
        }

        
        private Hotel LlenarHotel()
        {
            // Validadores de campos para que no se pueda ingresar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreHotel.Text))
            {
                MessageBox.Show("Debe Ingresar Un nombre de Hotel", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null; 
            }
            if (cmbPais.SelectedIndex == -1) {
                MessageBox.Show("Ingrese un País", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtDirHotel.Text)) {
                MessageBox.Show("Ingrese la dirección del Hotel", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) {
                MessageBox.Show("Tiene que añadir la descripción del Hotel", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }

            //si todos los campos han sido llenados, entonces se crea el objeto hotel 
            //con la informacion de los campos del formulario.
            return new Hotel
            {
                IdHotel = string.IsNullOrWhiteSpace(txtIdHotel.Text) ? 0 :
                         Convert.ToInt32(txtIdHotel.Text),
                NombreHotel = txtNombreHotel.Text,
                DireccionHotel = txtDirHotel.Text,
                Ciudad = cmbCiudad.Text,
                Pais = cmbPais.Text,
                Estrellas = string.IsNullOrWhiteSpace(cmbEstrellas.Text) ? 0 :
                           Convert.ToInt32(cmbEstrellas.Text),
                Descripcion = txtDescripcion.Text,
                TieneWifi = chkWifi.Checked,
                TieneParking = chkParqueo.Checked,
                Activo = chkActivo.Checked
            };
        }

        // Llena los controles del formulario con los datos de un Hotel
        private void CargarHotel(Hotel hotel)
        {
            //se llena el formulario con los datos que se obtengan del hotel
            txtIdHotel.Text = hotel.IdHotel.ToString();
            txtNombreHotel.Text = hotel.NombreHotel;
            txtDirHotel.Text = hotel.DireccionHotel;
            cmbCiudad.Text = hotel.Ciudad;
            cmbPais.Text = hotel.Pais;
            cmbEstrellas.Text = hotel.Estrellas.ToString();
            txtDescripcion.Text = hotel.Descripcion;
            chkWifi.Checked = hotel.TieneWifi;
            chkParqueo.Checked = hotel.TieneParking;
            chkActivo.Checked = hotel.Activo;
        }

        private bool Modo_de_edicion = false;
    
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Modo_de_edicion)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtIdHotel.Text))
                    {
                        MessageBox.Show("Debe ingresar un ID de hotel para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    conn.Open();
                    string Consulta = "SELECT * FROM Hoteles WHERE IdHotel=@IdHotel";
                    using (SqlCommand comando = new SqlCommand(Consulta, conn))
                    {
                        comando.Parameters.AddWithValue("@IdHotel", Convert.ToInt32(txtIdHotel.Text));
                        using (SqlDataReader LectorSQL = comando.ExecuteReader())
                        {
                            if (LectorSQL.Read())
                            {
                                var hotel = new Hotel
                                {
                                    IdHotel = Convert.ToInt32(LectorSQL["IdHotel"]),
                                    NombreHotel = LectorSQL["NombreHotel"].ToString(),
                                    DireccionHotel = LectorSQL["DireccionHotel"].ToString(),
                                    Ciudad = LectorSQL["Ciudad"].ToString(),
                                    Pais = LectorSQL["Pais"].ToString(),
                                    Estrellas = Convert.ToInt32(LectorSQL["Estrellas"]),
                                    Descripcion = LectorSQL["Descripcion"].ToString(),
                                    TieneWifi = Convert.ToBoolean(LectorSQL["TieneWifi"]),
                                    TieneParking = Convert.ToBoolean(LectorSQL["TieneParking"]),
                                    Activo = Convert.ToBoolean(LectorSQL["Activo"])
                                };
                                CargarHotel(hotel);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el hotel en la base de datos", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                    // Restablece el estado si es necesario
                }
            }
            else
            {
                try
                {
                    Hotel hotel = LlenarHotel();
                    if (hotel == null) return; // Si la validación falla, no continúa

                    conn.Open();
                    string InsertHotel = "INSERT INTO Hoteles (NombreHotel, DireccionHotel, " +
                        "Ciudad, Pais, Estrellas, Descripcion, TieneWifi, " +
                        "TieneParking, Activo) " +
                        "VALUES(@NombreHotel, @DireccionHotel, @Ciudad, " +
                        "@Pais, @Estrellas, @Descripcion, @TieneWifi, " +
                        "@TieneParking, @Activo)";
                    using (SqlCommand comando = new SqlCommand(InsertHotel, conn))
                    {
                        comando.Parameters.AddWithValue("@NombreHotel", hotel.NombreHotel);
                        comando.Parameters.AddWithValue("@DireccionHotel", hotel.DireccionHotel);
                        comando.Parameters.AddWithValue("@Ciudad", hotel.Ciudad);
                        comando.Parameters.AddWithValue("@Pais", hotel.Pais);
                        comando.Parameters.AddWithValue("@Estrellas", hotel.Estrellas);
                        comando.Parameters.AddWithValue("@Descripcion", hotel.Descripcion);
                        comando.Parameters.AddWithValue("@TieneWifi", hotel.TieneWifi);
                        comando.Parameters.AddWithValue("@TieneParking", hotel.TieneParking);
                        comando.Parameters.AddWithValue("@Activo", hotel.Activo);
                        comando.ExecuteNonQuery();
                    }
                    LimpiarCampos();
                    MessageBox.Show("Nuevo hotel guardado", "Registro de Hoteles",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! \n" + ex.Message, "Registro de Hoteles",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
            }
        }

       

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtIdHotel.Text = "";
            txtNombreHotel.Text = "";
            txtDirHotel.Text = "";
            cmbPais.SelectedIndex = -1;
            cmbEstrellas.SelectedIndex = -1;
            txtDescripcion.Text = "";
            chkWifi.Checked = false;
            chkParqueo.Checked = false;
            chkActivo.Checked = false;
        }

        // Modificar (Actualizar)
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (!Modo_de_edicion)
            {
                txtIdHotel.Enabled = true;
                btnGuardar.Text = "Buscar";
                btnLimpiar.Text = "Eliminar";
                Modo_de_edicion = true;
            }
            else
            {
                Hotel hotel = LlenarHotel();
                if (hotel == null)
                {
                    // Ya se mostró el mensaje de error en LlenarHotel
                    return;
                }
                try
                {
                    conn.Open();
                    string updateHotel = "UPDATE Hoteles SET NombreHotel=@NombreHotel, DireccionHotel=@DireccionHotel, Ciudad=@Ciudad, Pais=@Pais, Estrellas=@Estrellas, Descripcion=@Descripcion, TieneWifi=@TieneWifi, TieneParking=@TieneParking, Activo=@Activo WHERE IdHotel=@IdHotel";
                    using (SqlCommand comando = new SqlCommand(updateHotel, conn))
                    {
                        comando.Parameters.AddWithValue("@IdHotel", hotel.IdHotel);
                        comando.Parameters.AddWithValue("@NombreHotel", hotel.NombreHotel);
                        comando.Parameters.AddWithValue("@DireccionHotel", hotel.DireccionHotel);
                        comando.Parameters.AddWithValue("@Ciudad", hotel.Ciudad);
                        comando.Parameters.AddWithValue("@Pais", hotel.Pais);
                        comando.Parameters.AddWithValue("@Estrellas", hotel.Estrellas);
                        comando.Parameters.AddWithValue("@Descripcion", hotel.Descripcion);
                        comando.Parameters.AddWithValue("@TieneWifi", hotel.TieneWifi);
                        comando.Parameters.AddWithValue("@TieneParking", hotel.TieneParking);
                        comando.Parameters.AddWithValue("@Activo", hotel.Activo);
                        int filas = comando.ExecuteNonQuery();
                        if (filas > 0)
                            MessageBox.Show("Se ha modificado la información del Hotel", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se encontró el Hotel en la base de datos", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.Message);
                }
                finally
                {
                    conn.Close();
                    Modo_de_edicion = false;
                    txtIdHotel.Enabled = false;
                    btnGuardar.Text = "Guardar";
                    btnLimpiar.Text = "Limpiar";
                }
            }
        }

        // Eliminar
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            if (Modo_de_edicion)
            {
                if (string.IsNullOrWhiteSpace(txtIdHotel.Text))
                {
                    MessageBox.Show("Ingrese el ID del hotel a eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirm = MessageBox.Show("¿Está seguro que desea eliminar este hotel?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int idHotel = Convert.ToInt32(txtIdHotel.Text);
                        conn.Open();
                        string deleteHotel = "DELETE FROM Hoteles WHERE IdHotel=@IdHotel";
                        using (SqlCommand comando = new SqlCommand(deleteHotel, conn))
                        {
                            comando.Parameters.AddWithValue("@IdHotel", idHotel);
                            int filas = comando.ExecuteNonQuery();
                            if (filas > 0)
                                MessageBox.Show("Hotel eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se encontró el hotel con ese ID.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        LimpiarCampos();
                        Modo_de_edicion = false;
                        txtIdHotel.Enabled = false;
                        btnGuardar.Text = "Guardar";
                        btnLimpiar.Text = "Limpiar";
                    }
                }
            }
            else
            {
                LimpiarCampos();
            }
        }
    }
}
