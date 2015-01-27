namespace StorePOS.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;

    #endregion
    
    /// <summary>
    /// Representa la variación del stock de un articulo en una ubicación.
    /// El movimiento puede ser IngresoStock el cuál incrementa el stock del articulo en la ubicación como así tambien el stock total del articulo o puede
    /// SalidaStock el cuál decrementa el stock del articulo en la ubicación como así tambien el stock total del articulo o pueder TransferenciaStock 
    /// el cuál decrementa el stock en la ubicación orígen e incrementa el stock stock en la ubicación destino pero no varía el stock total del articulo.
    /// </summary>
    public class MovimientoStock : Entity
    {
        private TipoMovimientoStock tipoMovimientoStock;
        private Stock stock;
        private int cantidad;
        private string documentoComercial;
        private DateTime fechaDocumento;
        private DateTime fechaRegistro;
        private int usuarioRegistro;
       
        #region Constructor

        public MovimientoStock()
        { 
        
        }

        public MovimientoStock(TipoMovimientoStock tipoMovimientoStock, Stock stock, int cantidad, string documentoComercial, DateTime fechaDocumento, int usuarioRegistro)
        {
            this.tipoMovimientoStock = tipoMovimientoStock;
            this.stock = stock;
            this.cantidad = cantidad;
            this.documentoComercial = documentoComercial;
            this.fechaDocumento = fechaDocumento;
            this.usuarioRegistro = usuarioRegistro;

            if (this.TipoMovimientoStock == TipoMovimientoStock.IngresoStock)
                this.Stock.Incrementar(cantidad);
            else
                this.Stock.Decrementar(cantidad);

            this.fechaRegistro = DateTime.Now;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Representa el tipo de movimiento de Stock (IngresoStock-SalidaStock)
        /// </summary>
        public virtual TipoMovimientoStock TipoMovimientoStock
        {
            get
            {
                return this.tipoMovimientoStock;
            }
        }
        /// <summary>
        /// Referencia al stock de un articulo en determinada ubicación
        /// </summary>
        public virtual Stock Stock 
        {
            get
            {
                return this.stock;
            }
        }
        /// <summary>
        /// Cantidad en la que varia el stock
        /// </summary>
        public virtual int Cantidad 
        {
            get
            {
                return this.cantidad;
            }
        }
        /// <summary>
        /// Documento comercial que respalda el movimiento (Remito, Factura, etc)
        /// </summary>
        public virtual string DocumentoComercial 
        {
            get
            {
                return this.documentoComercial;
            }
        }
        /// <summary>
        /// Fecha que se emitio el documento comercial
        /// </summary>
        public virtual DateTime FechaDocumento
        {
            get
            {
                return this.fechaDocumento;
            }
        }
        /// <summary>
        /// Registro de la fecha de sistema que se realizo la transacción
        /// </summary>
        public virtual DateTime FechaMovimiento
        {
            get
            {
                return this.fechaRegistro;
            }
        }
        /// <summary>
        /// Referencia del usuario que registro el movimiento de stock
        /// </summary>
        public virtual int UsuarioRegistro
        {
            get
            {
                return this.usuarioRegistro;
            }
        }

        #endregion
    }
}
