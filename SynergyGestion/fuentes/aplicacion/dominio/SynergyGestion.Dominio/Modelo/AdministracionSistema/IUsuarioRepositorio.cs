namespace SynergyGestion.Dominio.Modelo.AdministracionSistema
{
    #region Using

    using System;
    using System.Collections.Generic;
    using SynergyGestion.Dominio.Comun;

    #endregion

    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        /// <summary>
        /// Obtiene el usuario según nombre de usuario
        /// </summary>
        /// <param name="nombreUsuario">Nombre de Usuario</param>
        /// <returns>instancia de Usuario</returns>
        Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario);
        /// <summary>
        /// Obtiene la contraseña del usuario según nombre de usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <returns>dicccionario con el nombre de usuario y contraseña</returns>
        Dictionary<string, byte[]> ObtenerContraseñaUsuario(string nombreUsuario);

        Usuario CrearCuentaUsuario(Usuario usuario, byte[] saltContraseña, byte[] hashContraseña);
    }
}
