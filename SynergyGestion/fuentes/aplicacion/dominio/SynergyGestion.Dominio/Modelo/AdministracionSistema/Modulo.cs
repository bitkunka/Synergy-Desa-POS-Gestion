namespace SynergyGestion.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion
    
    public class Modulo: Entity
    {
        private Menu menu;
        
        public virtual string Nombre { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string NombreImagen { get; set; }

        public virtual Menu Menu
        {
            get { return menu; }
            set
            {
                if (!Equals(menu, value))
                {
                    menu = value;
                }
            }
        }
    }
}
