using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class PuntosCargaDAL
    {
        private static List<PuntoCarga> puntos = new List<PuntoCarga>();

        public void Add(PuntoCarga p)
        {
            puntos.Add(p);
        }

        public List<PuntoCarga> GetAll()
        {
            return puntos;
        }

        public void Remove(int id)
        {
            PuntoCarga punto = puntos.Find(e => e.Id == id);
            puntos.Remove(punto);
        }

        public List<PuntoCarga> GetAll(int tipo)
        {
            return puntos.FindAll(p => p.Tipo == tipo);
        }

        public void Update(PuntoCarga p)
        {
   

        }
    }
}