namespace StorePOS.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Dominio.Comun;

    #endregion
    
    public class GrupoArticulo : Entity
    {
        private string nombre;
        private string descripcion;
        private GrupoArticulo grupoArticulo;
        private readonly IList<GrupoArticulo> subGrupos = new List<GrupoArticulo>();
        private readonly IList<Articulo> articulos = new List<Articulo>();

        #region Constructor

        public GrupoArticulo()
        {

        }

        public GrupoArticulo(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        #endregion

        #region Propiedades

        public virtual string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public virtual string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public virtual GrupoArticulo GrupoArticuloPadre
        {
            get { return grupoArticulo; }
            set { grupoArticulo = value; }
        }

        public virtual IList<GrupoArticulo> SubGrupos
        {
            get { return new ReadOnlyCollection<GrupoArticulo>(subGrupos); }
        }

        public virtual IList<Articulo> Articulos
        {
            get { return new ReadOnlyCollection<Articulo>(articulos); }
        }

        public virtual string Leyenda
        {
            get
            {
                return string.Format("{0} - ({1})",this.nombre, this.articulos.Count);
            }
        }

        #endregion

        #region Manejo de Coleccion Subgrupo

        public virtual void AgregarSubGrupo(GrupoArticulo subGrupo)
        {
            if (!subGrupos.Contains(subGrupo))
            {
                subGrupos.Add(subGrupo);
            }
        }

        public virtual void EliminarSubGrupo(GrupoArticulo subGrupo)
        {
            if (subGrupos.Contains(subGrupo))
            {
                subGrupos.Remove(subGrupo);
            }
        }

        public virtual void Limpiar()
        {
            subGrupos.Clear();
        }

        public virtual void AgregarSubGrupos(IList<GrupoArticulo> subGrupos)
        {
            foreach (var subGrupo in subGrupos)
            {
                AgregarSubGrupo(subGrupo);
            }
        }

        public virtual void AgregarActualizarSubGrupo(GrupoArticulo subGrupo)
        {
            if (!subGrupos.Contains(subGrupo))
            {
                AgregarSubGrupo(subGrupo);
            }
            else
            {
                subGrupos[subGrupos.IndexOf(subGrupo)] = subGrupo;
            }
        }

        #endregion

        #region Articulos Collection Methods

        public virtual void AgregarArticulo(Articulo articulo)
        {
            if (!articulos.Contains(articulo))
            {
                articulos.Add(articulo);
            }
        }

        public virtual void EliminarArticulo(Articulo aticulo)
        {
            if (articulos.Contains(aticulo))
            {
                articulos.Remove(aticulo);
            }
        }

        public virtual void LimpiarArticulos()
        {
            articulos.Clear();
        }

        public virtual void AgregarArticulos(IList<Articulo> articulos)
        {
            foreach (var articulo in articulos)
            {
                AgregarArticulo(articulo);
            }
        }

        public virtual void AgregarActualizar(Articulo articulo)
        {
            if (!articulos.Contains(articulo))
            {
                AgregarArticulo(articulo);
            }
            else
            {
                articulos[articulos.IndexOf(articulo)] = articulo;
            }
        }

        #endregion
    }
}
