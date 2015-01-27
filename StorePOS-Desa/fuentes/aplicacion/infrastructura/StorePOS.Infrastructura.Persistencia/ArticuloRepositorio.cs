namespace StorePOS.Infrastructura.Persistencia
{
    #region Using

    using System;
    using System.Collections.Generic;
    using NHibernate;
    using NHibernate.Type;
    using Dominio.Modelo.Inventario;
    using Infrastructura.Persistencia.Util;

    #endregion

//    public class ArticuloRepositorio : Repositorio<Articulo>,  IArticuloRepositorio
//    {
//        public ArticuloRepositorio(ISessionProvider sessionProvider): base(sessionProvider){}

//        public IList<Articulo> BuscarArticulos(GrupoArticulo grupoArticulo, FamiliaArticulo familiaArticulo, string codigo, string descripcion)
//        {
//            var session = this.sessionProvider.GetCurrentSession();
//            IList<Articulo> articulos;

//            using (var tx = session.BeginTransaction())
//            {
//                var hql = @"select art
//                            from  GrupoArticulo grp
//                            join  grp.familias as fla
//                            join  fla.articulos as art
//                            where  (fla.grupoArticulo     =:grupoArticulo or :grupoArticulo is null)
//                            and    (art.familiaArticulo   =:familiaArticulo or :familiaArticulo is null)
//                            and    art.codigo      like :codigo
//                            and    art.descripcion like :descripcion";

//                articulos = session.CreateQuery(hql)
//                                   .SetParameter("grupoArticulo",   grupoArticulo)
//                                   .SetParameter("familiaArticulo", familiaArticulo)
//                                   .SetParameter("codigo", string.Format("%{0}%", codigo))
//                                   .SetParameter("descripcion", string.Format("%{0}%", descripcion))
//                                   .List<Articulo>();

//                tx.Commit();
//            }

//            return articulos;
//        }
//    }

    public class ArticuloRepositorio : Repositorio<Articulo>, IArticuloRepositorio
    {
        public ArticuloRepositorio(ISessionProvider sessionProvider) : base(sessionProvider) { }

        public IList<Articulo> BuscarArticulos(int? grupoArticulo, string codigo, string descripcion)
        {
            var session = this.sessionProvider.GetCurrentSession();
            IList<Articulo> articulos;

            articulos = session.GetNamedQuery("ObtenerArticulos")
                               .SetParameter("idGrupoArticulo", grupoArticulo)
                               .SetParameter("codigo", string.Format("%{0}%", codigo))
                               .SetParameter("descripcion", string.Format("%{0}%", descripcion))
                               .List<Articulo>();

           

            return articulos;
        }

        public Articulo BuscarArticuloPorCodigo(string codigo)
        {
            var session = this.sessionProvider.GetCurrentSession();
            Articulo articulo;

            var hql = @"select art
                        from  Articulo art
                        where art.codigo =:codigo";

            articulo = session.CreateQuery(hql)
                               .SetParameter("codigo", codigo)
                               .UniqueResult<Articulo>();

            return articulo;
        }
    }
}