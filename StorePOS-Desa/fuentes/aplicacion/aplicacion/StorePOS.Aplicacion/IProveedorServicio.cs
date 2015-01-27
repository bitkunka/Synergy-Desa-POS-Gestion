namespace StorePOS.Aplicacion
{
    #region Using
    
    using System;
    using System.Collections.Generic;
    using Dominio.Modelo.Compras;

    #endregion

    public interface IProveedorServicio : IDisposable
    {
        IList<Proveedor> BuscarProveedores(string cuit, string nombre);

        Proveedor GuardarProveedor(Proveedor proveedor);
    }
}
