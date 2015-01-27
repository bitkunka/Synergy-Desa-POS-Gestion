namespace StorePOS.Aplicacion
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Modelo.AdministracionSistema;

    #endregion

    public interface ICuentaUsuarioServicio : IDisposable
    {
        /// <summary>
        /// Valida si el nombre de usuario  contraseña corresonden a un usuario en el sistema
        /// </summary>
        /// <param name="nombreUsuario">nombre de usuario</param>
        /// <param name="contraseña">contraseña de ingreso</param>
        /// <returns>true si la validación es correcta, de lo contrario false</returns>
        bool ValidarUsuario(string nombreUsuario, string contraseña);

        Usuario CrearCuentaUsuario(Usuario usuario, out EstadoCreacionCuentaUsuario estado);
    }
}
