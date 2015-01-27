namespace SynergyGestion.Infrastructura.Persistencia.Util
{
    #region Using

    using System;
    using NHibernate;

    #endregion

    public interface ISessionProvider : IDisposable
    {
        ISession GetCurrentSession();
        void DisposeCurrentSession();
    }
}
