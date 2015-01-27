namespace SynergyGestion.Aplicacion
{
    #region Using
    
    using System;
    using System.Collections.Generic;
    using Dominio.Modelo.Inventario;

    #endregion

    public interface IStockServicio : IDisposable
    {
        void GuardarIngresoStock(CestaIngresoStock cestaIngresoStock);

        IList<Stock> ConsultarStock(GrupoArticulo grupoArticulo, string codigoArticulo, string descripcionArticulo);
    }
}
