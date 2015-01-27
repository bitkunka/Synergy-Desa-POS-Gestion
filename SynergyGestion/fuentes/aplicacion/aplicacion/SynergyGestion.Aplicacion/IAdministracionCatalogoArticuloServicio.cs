namespace SynergyGestion.Aplicacion
{
    #region Using
    
    using System;
    using System.Collections.Generic;
    using Dominio.Modelo.Inventario;

    #endregion

    public interface IAdministracionCatalogoArticuloServicio : IDisposable
    {
        /// <summary>
        /// Obtiene los grupos de artículos existente en el catálogo
        /// </summary>
        /// <returns>list de grupo de artículos</returns>
        IList<GrupoArticulo> ObtenerGrupoArticulos();
        /// <summary>
        /// Obtiene el grupo de artículos según el idGrupoArticulo
        /// </summary>
        /// <param name="idGrupoArticulo">id del grupo de articulo</param>
        /// <returns>instancia de GrupoArticulo</returns>
        GrupoArticulo ObtenerGrupo(int idGrupoArticulo);
        /// <summary>
        /// Guardar instancia de la Clase de Articulo
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns>intancia de Articulo</returns>
        Articulo GuardarArticulo(Articulo articulo);
        /// <summary>
        /// Buscar articulos existentes en el Catálogo
        /// </summary>
        /// <param name="grupoArticulo">Grupo de Articulo</param>
        /// <param name="codigo">Código de Articulo</param>
        /// <param name="descripcion">Descripción de Articulo</param>
        /// <returns>List de Articulos encontrados en la búsqueda</returns>
        IList<Articulo> BuscarArticulos(int? grupoArticulo, string codigo, string descripcion);  
    }
}
