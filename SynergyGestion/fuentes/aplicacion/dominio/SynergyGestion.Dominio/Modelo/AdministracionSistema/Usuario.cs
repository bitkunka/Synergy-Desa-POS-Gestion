namespace SynergyGestion.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;

    #endregion

    public class Usuario : Entity
    {
        private string nombreUsuario;

        #region Constructor

        public Usuario()
        { 
        
        }

        public Usuario(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }

        #endregion

        #region Propiedades

        public virtual string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        #endregion
    }

    public enum EstadoCreacionCuentaUsuario
    {
        ClaveNoValida = 0,
        EMailDuplicado = 1,
        Exitosa = 2,
        Error = 3,
        NombreUsuarioDuplicado = 4
    }
}
