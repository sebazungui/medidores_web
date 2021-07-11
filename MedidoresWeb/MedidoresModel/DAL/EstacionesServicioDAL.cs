using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class EstacionesServicioDAL
    {
        private static List<EstacionServicio> estaciones = new List<EstacionServicio>();

        public void Add(EstacionServicio es)
        {
            estaciones.Add(es);
        }

        public List<EstacionServicio> GetAll()
        {
            return estaciones;
        }

        public void Remove(int id)
        {
            EstacionServicio estacionServicio = estaciones.Find(es => es.Id == id);
            estaciones.Remove(estacionServicio);
        }
    }
}
