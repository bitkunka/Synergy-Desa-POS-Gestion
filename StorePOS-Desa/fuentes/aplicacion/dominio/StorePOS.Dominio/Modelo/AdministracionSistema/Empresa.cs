namespace StorePOS.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion
    
    public class Empresa: Entity
    {
        public virtual string Nombre { get; set; }
    }
}
