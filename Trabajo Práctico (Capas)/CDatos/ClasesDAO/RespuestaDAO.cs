﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDAO
{
    public interface RespuestaDAO
    {
        List<Respuesta> getRespuestas(string nombre);
    }
}
