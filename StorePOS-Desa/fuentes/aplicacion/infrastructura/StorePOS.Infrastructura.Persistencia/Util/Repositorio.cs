namespace StorePOS.Infrastructura.Persistencia.Util
{
    #region Using

    using System;
    using System.Collections.Generic;
    using NHibernate;
    using Dominio.Comun;

    #endregion

    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : class
    {
        protected readonly ISessionProvider sessionProvider;

        public Repositorio(ISessionProvider sessionProvider)
        {
            this.sessionProvider = sessionProvider;
        }
        
        public void Dispose()
        {
            this.sessionProvider.Dispose();
        }

        public void Guardar(TEntidad entidad)
        {
            var session = this.sessionProvider.GetCurrentSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entidad);
                transaction.Commit();
            }
        }

        public TEntidad ObtenerPorId(int id)
        {
            var session = this.sessionProvider.GetCurrentSession();
            TEntidad result;

            using (var tx = session.BeginTransaction())
            {
                result = session.Load<TEntidad>(id);
                tx.Commit();
            }

            return result;
        }

        public IEnumerable<TEntidad> ObtenerTodos()
        {
            var session = this.sessionProvider.GetCurrentSession();
            IEnumerable<TEntidad> results;

            using (var tx = session.BeginTransaction())
            {
                results = session.QueryOver<TEntidad>()
                .List<TEntidad>();
                tx.Commit();
            }

            return results;
        }
    }
}