namespace ProyectoHotel
{
    public class Usuario { 
    public int id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string tipo { get; set; }

    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}