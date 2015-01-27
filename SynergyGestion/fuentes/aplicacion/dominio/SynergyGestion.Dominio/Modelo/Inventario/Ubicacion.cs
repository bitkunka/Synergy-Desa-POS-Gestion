namespace SynergyGestion.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Comun;
    using AdministracionSistema;

    #endregion

    public class Ubicacion : Entity
    {
        private string nombre;
        private Sucursal sucursal;

        #region Constructor

        public Ubicacion()
        { 
        
        }

        #endregion

        #region Propiedades

        public virtual string Nombre 
        {
            get
            {
                return this.nombre;
            }
        }

        public virtual Sucursal Sucursal 
        {
            get
            {
                return this.sucursal;
            }
        }

        #endregion
    }
}
