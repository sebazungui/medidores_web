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

        public PuntoCarga GetPunto(int id)
        {
            return puntos.Find(p => p.Id == id);
        }


        public List<PuntoCarga> GetAll(int tipo)
        {
            return puntos.FindAll(p => p.Tipo == tipo);
        }

        public void Update(PuntoCarga p)
        {
            puntos.Single(pto => pto.Id == p.Id).CapacidadMaxima = p.CapacidadMaxima;
            puntos.Single(pto => pto.Id == p.Id).Tipo = p.Tipo;
            puntos.Single(pto => pto.Id == p.Id).FechaVencimiento = p.FechaVencimiento;
        }
    }
}