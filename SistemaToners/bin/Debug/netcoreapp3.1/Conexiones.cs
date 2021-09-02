using System;
using System.Data.SQLite;
using System.IO;
using SistemaToners.Entidades;

namespace SistemaToners.Conexion
{
    public class Conexiones
    {
        public void AltaArea(Area _area)
        {
            string path = Path.GetFullPath("SistemaToners.db");
            string cadena = "Data Source=" + path;
            new SQLiteConnection(cadena).Open();
            var command = new SQLiteConnection(cadena).CreateCommand();
            command.CommandText = "Insert Into Area(nombreArea) values (@area)";
            command.Parameters.AddWithValue("@area", _area.Nombre_area);
            command.ExecuteNonQuery();
            new SQLiteConnection(cadena).Close();
        }
        
    }
}
