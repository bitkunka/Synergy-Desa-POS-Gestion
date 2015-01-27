namespace SynergyGestion.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;

    #endregion

    /// <summary>
    /// Representa la transferencia de stock de un articulo desde una ubicación orígen a una ubicación destino.
    /// Esta transacción provoca un decremento del stock en la ubicación orígen e incrementa el stock stock en la ubicación destino pero no varía el stock total del articulo.
    /// </summary>
    public class TrasnferenciaStock : Entity
    {
        private int cantidad;
        private DateTime fechaTransferencia;
        private string usuarioRegistro;
        
        #region Constructor

        public TrasnferenciaStock()
        {
        
        }

        public TrasnferenciaStock(int cantidad, DateTime fechaTransferencia, string usuarioRegistro)
        {
            this.cantidad = cantidad;
            this.fechaTransferencia = fechaTransferencia;
            this.usuarioRegistro = usuarioRegistro;
        }

        #endregion

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
        /// Registro de la fecha de sistema que se realizo la transacción
        /// </summary>
        public virtual DateTime FechaTransferencia
        {
            get
            {
                return this.fechaTransferencia;
            }
        }

        /// <summary>
        /// Referencia del usuario que registro el movimiento de stock
        /// </summary>
        public virtual string UsuarioRegistro
        {
            get
            {
                return this.usuarioRegistro;
            }
        }
    }
}
