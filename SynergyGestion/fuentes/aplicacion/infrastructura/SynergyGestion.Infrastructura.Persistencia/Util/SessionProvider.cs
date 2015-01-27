namespace SynergyGestion.Infrastructura.Persistencia.Util
{
    #region Using

    using System;
    using System.Collections.Generic;
    using NHibernate;

    #endregion

    public class SessionProvider: ISessionProvider
    {
        private readonly ISessionFactory sessionFactory;
        private ISession currentSession;

        public SessionProvider(ISessionFactory sessionFactory)
        {
            Console.WriteLine("Building session provider");
            this.sessionFactory = sessionFactory;
        }
        
        public ISession GetCurrentSession()
        {
            if (null == this.currentSession)
                this.currentSession = this.sessionFactory.OpenSession();

            string s = this.currentSession != null ? this.currentSession.GetHashCode().ToString() : string.Empty;

            return this.currentSession;
        }

        public void DisposeCurrentSession()
        {
            this.currentSession.Dispose();
            this.currentSession = null;
        }
        
        public void Dispose()
        {
            if (this.currentSession != null)
                this.currentSession.Dispose();

            this.currentSession = null;
        }
    }
}