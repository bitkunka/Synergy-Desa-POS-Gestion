namespace SynergyGestion.Dominio.Modelo.Compras
{
    #region Using

    using System;
    using System.Collections.Generic;
    using SynergyGestion.Dominio.Comun;

    #endregion

    public interface IProveedorRepositorio : IRepositorio<Proveedor>
    {
        IList<Proveedor> BuscarProveedores(string cuit, string nombre);
    }
}
