using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaToners.Entidades
{
    public class Area
    {
        private int id;
        private string nombre_area;

        public int Id { get => id; set => id = value; }
        public string Nombre_area { get => nombre_area; set => nombre_area = value; }

        public Area(int _id, string _nombre_area)
        {
            this.id = _id;
            this.nombre_area = _nombre_area;
        }
        public Area()
        {

        }
    }
}
