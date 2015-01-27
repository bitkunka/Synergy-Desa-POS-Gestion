namespace SynergyGestion.Aplicacion.Impl
{
    #region Using

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Linq;
    using Dominio.Comun;
    using Dominio.Modelo.AdministracionSistema;

    #endregion

    public class CuentaUsuarioServicio : ICuentaUsuarioServicio
    {
        private readonly IUsuarioRepositorio repositorioUsuario;

        public CuentaUsuarioServicio(IUsuarioRepositorio repositorioUsuario)
        {
            this.repositorioUsuario = repositorioUsuario;
        }

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            Usuario usuarioExistente = this.repositorioUsuario.ObtenerUsuarioPorNombreUsuario(nombreUsuario);

            if (usuarioExistente == null)
                throw new ApplicationException("No existe el usuario en la base de datos");

            Dictionary<string, byte[]> contraseñaUsuario = this.repositorioUsuario.ObtenerContraseñaUsuario(nombreUsuario);

            var keyValueSalt = contraseñaUsuario.Single(x => x.Key == "SaltContraseña");
            var keyValueHash = contraseñaUsuario.Single(x => x.Key == "HashContraseña");

            byte[] salt = keyValueSalt.Value;

            byte[] hashContraseñaIngresada = GetSecureHash(contraseña, salt);
            byte[] hashContraseñaUsuario = keyValueHash.Value;

            return StructuralComparisons.StructuralEqualityComparer.Equals(hashContraseñaIngresada, hashContraseñaUsuario);  
        }

        public Usuario CrearCuentaUsuario(Usuario usuario, out EstadoCreacionCuentaUsuario estado)
        {
            byte[] saltContraseña;

            byte[] hashContraseña;

            Usuario usuarioExistente = this.repositorioUsuario.ObtenerUsuarioPorNombreUsuario(usuario.NombreUsuario);

            if (usuarioExistente == null)
            {
                saltContraseña = this.GetSalt();

                hashContraseña = this.GetSecureHash("1234", saltContraseña);

                usuario = this.repositorioUsuario.CrearCuentaUsuario(usuario, saltContraseña, hashContraseña);

                if (usuario.Id != 0)
                {
                    estado = EstadoCreacionCuentaUsuario.Exitosa;
                }
                else
                {
                    estado = EstadoCreacionCuentaUsuario.Error;
                    return null;
                }

                return usuario;
            }
            else
            {
                estado = EstadoCreacionCuentaUsuario.NombreUsuarioDuplicado;
            }

            return null;
        }

        #region Utils

        public byte[] GetSalt()
        {
            var p = new RNGCryptoServiceProvider();
            var salt = new byte[16];
            p.GetBytes(salt);
            return salt;
        }

        public byte[] GetSecureHash(string password, byte[] salt)
        {
            Rfc2898DeriveBytes PBKDF2 = new Rfc2898DeriveBytes(password, salt);
            return PBKDF2.GetBytes(64);
        }

        #endregion

        public void Dispose()
        {
            repositorioUsuario.Dispose();
        } 
    }
}
