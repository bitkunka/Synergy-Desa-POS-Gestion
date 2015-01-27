namespace StorePOS.Aplicacion.Impl
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;
    using Dominio.Modelo.Inventario;

    #endregion

    public class AdministracionCatalogoArticuloServicio : IAdministracionCatalogoArticuloServicio
    {
        private readonly IRepositorio<GrupoArticulo> repositorioGrupoArticulo;
        private readonly IArticuloRepositorio repositorioArticulo;

        public AdministracionCatalogoArticuloServicio(IRepositorio<GrupoArticulo> repositorioGrupoArticulo, IArticuloRepositorio repositorioArticulo)
        {
            this.repositorioGrupoArticulo = repositorioGrupoArticulo;
            this.repositorioArticulo = repositorioArticulo;
        }
        
        public IList<GrupoArticulo> ObtenerGrupoArticulos()
        {
            return (IList<GrupoArticulo>)repositorioGrupoArticulo.ObtenerTodos();
        }

        public GrupoArticulo ObtenerGrupo(int idGrupoArticulo)
        {
            return this.repositorioGrupoArticulo.ObtenerPorId(idGrupoArticulo);
        }

        public Articulo GuardarArticulo(Articulo articulo)
        {
            Articulo busquedaArticulo = this.repositorioArticulo.BuscarArticuloPorCodigo(articulo.Codigo);

            if (busquedaArticulo != null)
            {
                if (!busquedaArticulo.Equals(articulo))
                    throw new ArticuloDuplicadoException(articulo.Codigo);
            }

            repositorioArticulo.Guardar(articulo);

            return articulo;
        }

        public IList<Articulo> BuscarArticulos(int? grupoArticulo, string codigo, string descripcion)
        {
            return this.repositorioArticulo.BuscarArticulos(grupoArticulo, codigo, descripcion);
        }

        public void Dispose()
        {
            repositorioGrupoArticulo.Dispose();
        }
    }
}
