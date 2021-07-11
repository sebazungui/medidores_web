﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public partial class PuntoCarga
    {
        public String TipoTxt
        {
            get
            {
                String texto = "";
                switch (Tipo)
                {
                    case 1:
                        texto = "Eléctrico";
                        break;
                    case 2:
                        texto = "Dual";
                        break;
                }
                return texto;
            }
        }
    }
}
