namespace SynergyGestion.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;

    #endregion
    
    public class Articulo : Entity
    {
        private string codigo;
        private string descripcion;
        private decimal valor;
        private CriterioCosteo criterioCosteo;
        private GrupoArticulo grupoArticulo;
        private int cantidadStock;

        #region Constructor

        public Articulo()
        {
        }

        public Articulo(string codigo, string descripcion, decimal valor, CriterioCosteo criterioCosteo)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.valor = valor;
            this.criterioCosteo = criterioCosteo;
        }

        public Articulo(string codigo, string descripcion, decimal valor, CriterioCosteo criterioCosteo, GrupoArticulo grupoArticulo)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.valor = valor;
            this.criterioCosteo = criterioCosteo;
            this.grupoArticulo = grupoArticulo;
        }

        #endregion

        #region Propiedades

        public virtual string Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        public virtual string Descripcion
        {
            get
            {
                return this.descripcion;
            }

        }

        public virtual decimal Valor
        {
            get
            {
                return this.valor;
            }
        }

        public virtual CriterioCosteo CriterioCosteo
        {
            get
            {
                return this.criterioCosteo;
            }
        }

        public virtual GrupoArticulo GrupoArticulo
        {
            get
            {
                return this.grupoArticulo;
            }
        }

        public virtual int CantidadStock
        {
            get
            {
                return this.cantidadStock;
            }
        }

        #endregion

        public virtual void IncrementarCantidadStock(int cantidad)
        {
            this.cantidadStock += cantidad;
        }

        public virtual void DecrementarCantidadStock(int cantidad)
        {
            this.cantidadStock -= cantidad;
        }
    }
}
