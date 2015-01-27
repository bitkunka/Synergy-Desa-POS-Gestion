namespace StorePOS.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;

    #endregion
    
    public class Stock : Entity
    {
        private Articulo articulo;
        private string ubicacion;
        private int cantidad;
       
        #region Constructor

        public Stock()
        { 
        
        }

        public Stock(Articulo articulo, string ubicacion, int cantidad)
        {
            this.articulo = articulo;
            this.ubicacion = ubicacion;
            this.cantidad = cantidad;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Referencia un articulo del Catálogo
        /// </summary>
        public virtual Articulo Articulo 
        {
            get
            {
                return this.articulo;
            }
        }

        /// <summary>
        /// Representa la ubicación donde se encuentra la existencia del articulo en stock
        /// </summary>
        public virtual string Ubicacion 
        {
            get
            {
                return this.ubicacion;
            }
        }

        /// <summary>
        /// Cantidad en Stock del articulo en la Ubiación
        /// </summary>
        public virtual int Cantidad 
        {
            get
            {
                return this.cantidad;
            }
        }

        #endregion

        public virtual void Incrementar(int cantidad)
        {
            this.cantidad += cantidad;

            this.Articulo.IncrementarCantidadStock(cantidad);
        }

        public virtual void Decrementar(int cantidad)
        {
            this.cantidad -= cantidad;
            this.Articulo.DecrementarCantidadStock(cantidad);
        }
    }
}
