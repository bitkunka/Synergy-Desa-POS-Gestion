namespace StorePOS.Dominio.Modelo.Compras
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion
    
    public static class DatosEjemplo
    {
        private static Proveedor proveedor1;
        private static Proveedor proveedor2;
        
        public static void Inicializar()
        {
            CrearProveedores();
        }

        private static void CrearProveedores()
        {
            proveedor1 = new Proveedor("Proveedor 1", "2456789456");
            proveedor2 = new Proveedor("Proveedor 2", "2456789456");
        }

        #region Proveedor 1

        public static Proveedor PROVEEDOR1
        {
            get
            {
                return proveedor1;
            }
        }

        #endregion

        #region Proveedor 2

        public static Proveedor PROVEEDOR2
        {
            get
            {
                return proveedor2;
            }
        }

        #endregion
    }
}
