namespace SynergyGestion.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using SynergyGestion.Dominio.Comun;

    #endregion

    public interface IStockRepositorio : IRepositorio<Stock>
    {
        /// <summary>
        /// Obtiene el Stock del articulo en la ubicación indicada
        /// </summary>
        /// <param name="codigoArticulo">codigo del articulo</param>
        /// <param name="ubicacion">ubicación</param>
        /// <returns>Stock</returns>
        Stock ObtenerStockPorCodigoArticuloUbicacion(string codigoArticulo, string ubicacion);
        /// <summary>
        /// Guarda en el sistema los movimientos de stock
        /// </summary>
        /// <param name="movimientos">movimientos de stock</param>
        void GuardarMovimientosStock(List<MovimientoStock> movimientos);

        IList<Stock> ConsultarStock(GrupoArticulo grupoArticulo, string codigoArticulo, string descripcionArticulo);
    }
}
