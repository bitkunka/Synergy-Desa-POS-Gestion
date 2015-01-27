namespace SynergyGestion.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Comun;

    #endregion
    
    public class Sucursal: Entity
    {
        public virtual string Nombre { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
