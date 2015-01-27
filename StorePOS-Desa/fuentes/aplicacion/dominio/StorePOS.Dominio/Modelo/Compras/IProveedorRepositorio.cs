namespace StorePOS.Dominio.Modelo.Compras
{
    #region Using

    using System;
    using System.Collections.Generic;
    using StorePOS.Dominio.Comun;

    #endregion

    public interface IProveedorRepositorio : IRepositorio<Proveedor>
    {
        IList<Proveedor> BuscarProveedores(string cuit, string nombre);
    }
}
