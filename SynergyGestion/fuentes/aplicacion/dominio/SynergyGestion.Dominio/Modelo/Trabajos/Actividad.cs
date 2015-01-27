namespace SynergyGestion.Dominio.Modelo.Trabajos
{
    #region Using

    using System;
    using Dominio.Modelo.General;

    #endregion

    public class Actividad
    {
        private string nombre;
        private Rubro rubro;
        private UnidadMedida unidad;
        private int cantidad;
        private double valorUnitario;
        private double valorParcial;
        private EstadoActividad estado;

        #region Ctor

        public Actividad()
        {

        }

        public Actividad(string nombre, Rubro rubro, UnidadMedida unidad, int cantidad, double valorUnitario, double valorParcial, EstadoActividad estado)
        {
            this.nombre = nombre; 
            this.rubro = rubro;
            this.unidad = unidad; 
            this.cantidad = cantidad; 
            this.valorUnitario = valorUnitario; 
            this.valorParcial = valorParcial;
            this.estado = estado;
        }

        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public UnidadMedida Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        #endregion
    }
}
