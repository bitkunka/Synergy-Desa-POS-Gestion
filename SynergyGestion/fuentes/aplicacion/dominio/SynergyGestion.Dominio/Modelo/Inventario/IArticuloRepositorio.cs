namespace SynergyGestion.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using SynergyGestion.Dominio.Comun;

    #endregion

    //public interface IArticuloRepositorio : IRepositorio<Articulo>
    //{
    //    /// <summary>
    //    /// Buscar articulos existentes en el Catálogo
    //    /// </summary>
    //    /// <param name="grupoArticulo">Grupo de Articulo</param>
    //    /// <param name="familiaArticulo">Familia de Articulo</param>
    //    /// <param name="codigo">Código de Articulo</param>
    //    /// <param name="descripcion">Descripción de Articulo</param>
    //    /// <returns>List de Articulos encontrados en la búsqueda</returns>
    //    IList<Articulo> BuscarArticulos(GrupoArticulo grupoArticulo, FamiliaArticulo familiaArticulo, string codigo, string descripcion);
    //}

    public interface IArticuloRepositorio : IRepositorio<Articulo>
    {
        /// <summary>
        /// Buscar articulos existentes en el Catálogo
        /// </summary>
        /// <param name="grupoArticulo">Grupo de Articulo</param>
        /// <param name="codigo">Código de Articulo</param>
        /// <param name="descripcion">Descripción de Articulo</param>
        /// <returns>List de Articulos encontrados en la búsqueda</returns>
        IList<Articulo> BuscarArticulos(int? grupoArticulo, string codigo, string descripcion);

        /// <summary>
        /// Busca articulo por codigo
        /// </summary>
        /// <param name="codigo">codigo de articulo</param>
        /// <returns> articulo</returns>
        Articulo BuscarArticuloPorCodigo(string codigo);
    }
}
