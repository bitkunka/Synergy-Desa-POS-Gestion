namespace SynergyGestion.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion
    
    public class Menu : Entity
    {
        private readonly IList<OpcionMenu> opciones = new List<OpcionMenu>();

        public virtual string[] Roles { get; set; }

        public virtual IList<OpcionMenu> Opciones
        {
            get { return new ReadOnlyCollection<OpcionMenu>(opciones); }
        }

        #region SubOpciones Collection Methods

        public virtual void AddOpcion(OpcionMenu opcion)
        {
            if (!opciones.Contains(opcion))
            {
                opciones.Add(opcion);
            }
        }

        public virtual void RemoveOpcion(OpcionMenu opcion)
        {
            if (opciones.Contains(opcion))
            {
                opciones.Remove(opcion);
            }
        }

        public virtual void ClearOpciones()
        {
            opciones.Clear();
        }

        public virtual void AddOpciones(IList<OpcionMenu> opciones)
        {
            foreach (var opcion in opciones)
            {
                AddOpcion(opcion);
            }
        }

        public virtual void AddOrUpdate(OpcionMenu opcion)
        {
            if (!opciones.Contains(opcion))
            {
                AddOpcion(opcion);
            }
            else
            {
                opciones[opciones.IndexOf(opcion)] = opcion;
            }
        }

        #endregion
    }
}
