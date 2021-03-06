using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using SistemaToners.Entidades;
using System;

namespace SistemaToners.Conexion
{
    public class Conexiones
    {
        public static string pathcompleto()
        {
            string path = Path.GetFullPath("SistemaToners.db");
            return "Data Source=" + path;
        }
        public void AltaArea(Area _area)
        {
            var conexion = new SQLiteConnection(pathcompleto());
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
            var conexion = new SQLiteConnection(pathcompleto());
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
        private Area BuscarPorNombre(string _nombre)
        {
            var conexion = new SQLiteConnection(pathcompleto());
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Select idArea from Area Where nombreArea = @nombreArea";
            command.Parameters.AddWithValue("@nombreArea", _nombre);
            Area _area = new Area();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _area.Id = Convert.ToInt32(reader["idArea"]);
                _area.Nombre_area = _nombre;
            }
            reader.Close();
            conexion.Close();
            return _area;
        }
        public void AltaPuesto(AreayPuesto _area_puesto)
        {
            Area areabuscada = BuscarPorNombre(_area_puesto.Area_puesto.Nombre_area);
            var conexion = new SQLiteConnection(pathcompleto());
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Insert Into Puesto(idArea, numPuesto) values (@area, @puesto);";
            command.Parameters.AddWithValue("@area", areabuscada.Id);
            command.Parameters.AddWithValue("@puesto", _area_puesto.Puesto);
            command.ExecuteNonQuery();
            conexion.Close();
        }
        public List<AreayPuesto> ListaPuesto()
        {
            List<AreayPuesto> Lista = new List<AreayPuesto>();
            var conexion = new SQLiteConnection(pathcompleto());
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = @"SELECT 
                                    idArea, 
                                    nombreArea, 
                                    numPuesto 
                                    FROM Puesto 
                                    Inner Join Area Using (idArea);";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Area nArea = new Area(Convert.ToInt32(reader["idArea"]), reader["nombreArea"].ToString());
                AreayPuesto areayPuesto = new AreayPuesto(nArea, Convert.ToInt32(reader["numPuesto"]));
                Lista.Add(areayPuesto);
            }
            reader.Close();
            conexion.Close();
            return Lista;
        }
    }
}
