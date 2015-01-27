namespace SynergyGestion.Dominio.Modelo.Trabajos
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion

    public class Trabajo : Entity
    {
        private string nombre;
        private DateTime fecha;
        private FichaTecnica fichaTecnica;
        private IList<Actividad> actividades;

        #region Ctor

        public Trabajo()
        {
           
        }

        public Trabajo(string nombre)
        {
            this.nombre = nombre;
        }

        public Trabajo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public Trabajo(string nombre, DateTime fecha, Trabajos.FichaTecnica fichaTecnica)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.fichaTecnica = fichaTecnica;
        }

        #endregion

        #region Propiedades

        public virtual string Nombre 
        {
            get
            {
                return nombre;
            }
        }

        public DateTime Fecha
        {
            get 
            { 
                return fecha; 
            }
            set 
            { 
                fecha = value;
            }
        }

        public FichaTecnica FichaTecnica
        {
            get 
            { 
                return fichaTecnica; }
            set 
            { 
                fichaTecnica = value; 
            }
        }

        public IList<Actividad> Actividades
        {
            get 
            { 
                return actividades; 
            }
            set 
            { 
                actividades = value; 
            }
        }

        #endregion
    }
}
