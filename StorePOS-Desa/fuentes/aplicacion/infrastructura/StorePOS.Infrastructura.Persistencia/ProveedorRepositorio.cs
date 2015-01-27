namespace StorePOS.Infrastructura.Persistencia
{
    #region Using

    using System;
    using System.Collections.Generic;
    using NHibernate;
    using NHibernate.Type;
    using NHibernate.Transform;
    using Dominio.Modelo.Compras;
    using Infrastructura.Persistencia.Util;

    #endregion

    public class ProveedorRepositorio : Repositorio<Proveedor>, IProveedorRepositorio
    {
        public ProveedorRepositorio(ISessionProvider sessionProvider) : base(sessionProvider) { }

        public IList<Proveedor> BuscarProveedores(string cuit, string nombre)
        {
            var session = this.sessionProvider.GetCurrentSession();
            IList<Proveedor> proveedores;

            using (var tx = session.BeginTransaction())
            {
                var hql = @"select prv
                            from  Proveedor prv
                            where (prv.cuit   like :cuit)
                            and   (prv.nombre like :nombre)";

                proveedores = session.CreateQuery(hql)
                                 .SetParameter("cuit", string.Format("%{0}%", cuit))
                                 .SetParameter("nombre", string.Format("%{0}%", nombre))
                                 .List<Proveedor>();

                tx.Commit();
            }

            return proveedores;
        }
    }
}