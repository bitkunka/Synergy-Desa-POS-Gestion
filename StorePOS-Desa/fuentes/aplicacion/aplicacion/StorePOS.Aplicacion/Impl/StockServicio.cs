namespace StorePOS.Aplicacion.Impl
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;
    using Dominio.Modelo.Inventario;

    #endregion

    public class StockServicio : IStockServicio
    {
        private readonly IStockRepositorio repositorioStock;
        private readonly IArticuloRepositorio repositorioArticulo;

        public StockServicio(IStockRepositorio repositorioStock, IArticuloRepositorio repositorioArticulo)
        {
            this.repositorioStock = repositorioStock;
            this.repositorioArticulo = repositorioArticulo;
        }

        private Stock ObtenerStockPorCodigoArticuloUbicacion(string codigoArticulo, string ubicacion)
        {
            Stock stock;

            if (this.repositorioStock.ObtenerStockPorCodigoArticuloUbicacion(codigoArticulo, ubicacion) != null)
            {
                stock = this.repositorioStock.ObtenerStockPorCodigoArticuloUbicacion(codigoArticulo, ubicacion);
            }
            else
            {
                Articulo articulo = this.repositorioArticulo.BuscarArticuloPorCodigo(codigoArticulo);
                stock = new Stock(articulo, ubicacion, 0);
            }
          
            return stock;
        }

        public void GuardarIngresoStock(CestaIngresoStock cestaIngresoStock)
        {
            Stock stock;

            List<MovimientoStock> movimientos = new List<MovimientoStock>();

            foreach (ItemCestaIngresoStock item in cestaIngresoStock.Items)
            {
                stock = this.ObtenerStockPorCodigoArticuloUbicacion(item.CodigoArticulo, item.Ubicacion);

                movimientos.Add(new MovimientoStock(TipoMovimientoStock.IngresoStock, stock, item.Cantidad, cestaIngresoStock.DocumentoComercial, cestaIngresoStock.FechaDocumento, cestaIngresoStock.IdUsuario));
            }

            this.repositorioStock.GuardarMovimientosStock(movimientos);
        }

        public IList<Stock> ConsultarStock(GrupoArticulo grupoArticulo, string codigoArticulo, string descripcionArticulo)
        {
            return this.repositorioStock.ConsultarStock(grupoArticulo, codigoArticulo, descripcionArticulo);
        }

        public void Dispose()
        {
            this.repositorioStock.Dispose();
        }
    }
}
