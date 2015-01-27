namespace StorePOS.Dominio.Comun
{
    #region Using

    using System;
    using System.Collections.Generic;

    #endregion

    public interface IRepositorio<TEntidad> : IDisposable where TEntidad : class
    {
        void Guardar(TEntidad entidad);
        TEntidad ObtenerPorId(int id);
        IEnumerable<TEntidad> ObtenerTodos();
    }
}
