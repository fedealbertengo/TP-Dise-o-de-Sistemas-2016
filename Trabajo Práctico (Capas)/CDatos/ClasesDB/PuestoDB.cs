﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CEntidades;
using System.Data.Entity.Core.Objects;
using CDatos.ClasesDAO;
using System.Linq.Expressions;

namespace CDatos.ClasesDB
{
    public class PuestoDB : PuestoDAO
    {

        public List<Puesto> getPuestos(Expression<Func<Puesto, bool>> filtro)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                Expression<Func<Puesto, bool>> predicadoGeneral = (pu => pu.id_consultor == null && pu.estado != "NoActivo"/* && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value*/);
                if(filtro != null)
                {
                    return db.Puesto.Include("Puntaje_Requerido.Competencia.Factor.Pregunta").Include("Evaluacion.Cuestionario").Include("Evaluacion.Cuestionario.Estado_Cuestionario").Where(filtro).Where(predicadoGeneral).ToList();
                }
                else
                {
                    return db.Puesto.Include("Puntaje_Requerido.Competencia.Factor.Pregunta").Include("Evaluacion.Cuestionario").Where(predicadoGeneral).ToList();
                }
            }
        }

        public int obtenerUltimoIDPuesto(int codigo, string nombre)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.spObtenerUltimoIDPuestoCN(codigo, nombre).FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      
        public void alta(Puesto puesto)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    db.Puesto.Add(puesto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void baja(Puesto puesto, Consultor consultorActual)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Puesto p = (from pu in db.Puesto where (pu.id_puesto == puesto.id_puesto && pu.fecha_eliminado == null) select pu).FirstOrDefault();
                    p.fecha_eliminado = DateTime.Now;
                    p.fecha_ultima_modificacion = DateTime.Now;
                    p.estado = "NoActivo";
                    p.id_consultor = consultorActual.nombreUsuario;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarSFunc(Puesto puesto)
        {
             try
            {

                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Puesto p = (from pu in db.Puesto where (pu.id_puesto == puesto.id_puesto && pu.fecha_eliminado == null) select pu).FirstOrDefault();
                    p.fecha_ultima_modificacion = DateTime.Now;
                    p.nombre = puesto.nombre;
                    p.empresa = puesto.empresa;
                    p.descripcion = puesto.descripcion;
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarCFunc(Puesto puesto,Puesto puestoSinMod)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Puesto p = (from pu in db.Puesto where (pu.id_puesto == puestoSinMod.id_puesto && pu.fecha_eliminado == null) select pu).FirstOrDefault();
                    p.estado = "NoActivo";
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    puesto.fecha_ultima_modificacion = DateTime.Now;
                    db.Puesto.Add(puesto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
