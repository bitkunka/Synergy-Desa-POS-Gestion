namespace StorePOS.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion
    
    public class OpcionMenu : Entity
    {
        private readonly IList<OpcionMenu> subOpciones = new List<OpcionMenu>();

        public virtual string Nombre { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string NombreImagen { get; set; }

        public virtual IList<OpcionMenu> SubOpciones
        {
            get { return new ReadOnlyCollection<OpcionMenu>(subOpciones); }
        }

        #region SubOpciones Collection Methods

        public virtual void AddSubOpcion(OpcionMenu opcion)
        {
            if (!subOpciones.Contains(opcion))
            {
                subOpciones.Add(opcion);
            }
        }

        public virtual void RemoveSubOpcion(OpcionMenu opcion)
        {
            if (subOpciones.Contains(opcion))
            {
                subOpciones.Remove(opcion);
            }
        }

        public virtual void ClearSubOpciones()
        {
            subOpciones.Clear();
        }

        public virtual void AddSubOpciones(IList<OpcionMenu> opciones)
        {
            foreach (var opcion in opciones)
            {
                AddSubOpcion(opcion);
            }
        }

        public virtual void AddOrUpdate(OpcionMenu opcion)
        {
            if (!subOpciones.Contains(opcion))
            {
                AddSubOpcion(opcion);
            }
            else
            {
                subOpciones[subOpciones.IndexOf(opcion)] = opcion;
            }
        }

        #endregion
    }
}
