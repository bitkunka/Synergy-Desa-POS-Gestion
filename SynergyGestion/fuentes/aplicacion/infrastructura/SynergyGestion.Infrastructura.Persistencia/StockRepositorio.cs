namespace SynergyGestion.Infrastructura.Persistencia
{
    #region Using

    using System;
    using System.Collections.Generic;
    using NHibernate;
    using NHibernate.Type;
    using NHibernate.Transform;
    using Dominio.Modelo.Inventario;
    using Infrastructura.Persistencia.Util;

    #endregion

    public class StockRepositorio : Repositorio<Stock>, IStockRepositorio
    {
        public StockRepositorio(ISessionProvider sessionProvider) : base(sessionProvider) { }

        public Stock ObtenerStockPorCodigoArticuloUbicacion(string codigoArticulo, string ubicacion)
        {
            var session = this.sessionProvider.GetCurrentSession();
            Stock stock;

            using (var tx = session.BeginTransaction())
            {
                var hql = @"select stk
                            from  Stock stk
                            join  stk.articulo as art
                            where art.codigo =:codigoArticulo 
                            and   stk.ubicacion =:ubicacion";

                stock = session.CreateQuery(hql)
                                 .SetParameter("codigoArticulo", codigoArticulo)
                                 .SetParameter("ubicacion", ubicacion)
                                 .UniqueResult<Stock>();

                tx.Commit();
            }

            return stock;
        }

        public void GuardarMovimientosStock(List<MovimientoStock> movimientos)
        {
            var session = this.sessionProvider.GetCurrentSession();

            using (var tx = session.BeginTransaction())
            {
                foreach (MovimientoStock movimiento in movimientos)
                {
                    session.SaveOrUpdate(movimiento);
                }

                tx.Commit();
            } 
        }

        public IList<Stock> ConsultarStock(GrupoArticulo grupoArticulo, string codigoArticulo, string descripcionArticulo)
        {
            var session = this.sessionProvider.GetCurrentSession();
            IList<Stock> stock;

            using (var tx = session.BeginTransaction())
            {
                var hql = @"select stk
                            from  Stock stk
                            join  stk.articulo as art
                            where (art.grupoArticulo =:grupoArticulo or :grupoArticulo is null)
                            and   art.codigo like :codigoArticulo
                            and   art.descripcion like :descripcionArticulo";

                stock = session.CreateQuery(hql)
                                 .SetParameter("grupoArticulo", grupoArticulo)
                                 .SetParameter("codigoArticulo", string.Format("%{0}%", codigoArticulo))
                                 .SetParameter("descripcionArticulo", string.Format("%{0}%", descripcionArticulo))
                                 .List<Stock>();

                tx.Commit();
            }

            return stock;
        }
    }
}