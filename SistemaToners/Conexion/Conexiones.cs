using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using SistemaToners.Entidades;
using System;

namespace SistemaToners.Conexion
{
    public class Conexiones
    {
        public void AltaArea(Area _area)
        {
            string path = Path.GetFullPath("SistemaToners.db");
            string cadena = "Data Source=" + path;
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Insert Into Area(nombreArea) values (@area);";
            command.Parameters.AddWithValue("@area", _area.Nombre_area);
            command.ExecuteNonQuery();
            conexion.Close();
        }
        public List<Area> ListaAreas()
        {
            List<Area> ListaArea = new List<Area>();
            string path = Path.GetFullPath("SistemaToners.db");
            string cadena = "Data Source=" + path;
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Select * from Area;";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Area _area = new Area(Convert.ToInt32(reader["idArea"]), reader["nombreArea"].ToString());
                ListaArea.Add(_area);
            }
            reader.Close();
            conexion.Close();
            return ListaArea;
        }
    }
}
