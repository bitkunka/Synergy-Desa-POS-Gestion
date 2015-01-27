namespace StorePOS.Dominio.Modelo.Compras
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion
    
    public class Proveedor: Entity
    {
        private string nombre;
        private string cuit;

        public Proveedor()
        {
           
        }

        public Proveedor(string nombre, string cuit)
        {
            this.nombre = nombre;
            this.cuit = cuit;
        }

        public virtual string Nombre 
        {
            get
            {
                return nombre;
            }
        }

        public virtual string CUIT
        {
            get
            {
                return cuit;
            }
        }
    }
}
