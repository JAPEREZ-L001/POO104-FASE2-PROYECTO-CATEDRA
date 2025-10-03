namespace ProyectoHotel
{
    public class Hotel
    {
        public int IdHotel { get; set; }
        public string NombreHotel { get; set; }
        public string DireccionHotel { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int Estrellas { get; set; }
        public string Descripcion { get; set; }
        public bool TieneWifi { get; set; }
        public bool TieneParking { get; set; }
        public bool Activo { get; set; }
    }
}