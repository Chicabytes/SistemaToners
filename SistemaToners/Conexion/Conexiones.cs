using System.Data.SQLite;
using System.IO;
using SistemaToners.Entidades;

namespace SistemaToners.Conexion
{
    public class Conexiones
    {
        public void AltaArea(Area _area)
        {
            string cadena = "Data Source=" + Directory.GetCurrentDirectory() + "\\SistemaToners.db";
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Insert Into Area(nombreArea) values (@area)";
            command.Parameters.AddWithValue("@area", _area.Nombre_area);
            command.ExecuteNonQuery();
            conexion.Close();
        }
        
    }
}
