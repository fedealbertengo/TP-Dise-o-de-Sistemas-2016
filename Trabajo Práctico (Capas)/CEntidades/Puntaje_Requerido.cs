//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puntaje_Requerido
    {
        public int id_puesto { get; set; }
        public int codigo_competencia { get; set; }
        public int ponderacion { get; set; }
    
        public virtual Competencia Competencia { get; set; }
        public virtual Puesto Puesto { get; set; }

        public bool Igual(Puntaje_Requerido car)
        {
            return (this.ponderacion == car.ponderacion && this.Competencia.Igual(car.Competencia));
        }
    }
}
