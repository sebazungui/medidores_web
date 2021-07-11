using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class EstacionServicio
    {
        private int id;
        private int capacidadMaxima;
        private String direccion;
        private String Ciudad;

        public int Id { get => id; set => id = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
    }
}
