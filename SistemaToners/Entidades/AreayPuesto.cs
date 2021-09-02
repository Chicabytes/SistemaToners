using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaToners.Entidades
{
    public class AreayPuesto
    {
        private Area area_puesto;
        private int puesto;

        public Area Area_puesto { get => area_puesto; set => area_puesto = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public AreayPuesto(Area _area_puesto, int _puesto)
        {
            this.area_puesto = _area_puesto;
            this.puesto = _puesto;
        }
    }
}
