namespace StorePOS.Infrastructura.Persistencia
{
    #region Using

    using System;
    using System.Collections.Generic;
    using NHibernate;
    using NHibernate.Type;
    using NHibernate.Transform;
    using Dominio.Modelo.AdministracionSistema;
    using Infrastructura.Persistencia.Util;

    #endregion

    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ISessionProvider sessionProvider) : base(sessionProvider) { }

        public Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            var session = this.sessionProvider.GetCurrentSession();
            Usuario usuario;

            using (var tx = session.BeginTransaction())
            {
                var hql = @"select usr
                            from  Usuario usr
                            where usr.nombreUsuario =:nombreUsuario";

                usuario = session.CreateQuery(hql)
                                 .SetParameter("nombreUsuario", nombreUsuario)
                                 .UniqueResult<Usuario>();

                tx.Commit();
            }

            return usuario;
        }

        public Dictionary<string, byte[]> ObtenerContraseñaUsuario(string nombreUsuario)
        {
            var session = this.sessionProvider.GetCurrentSession();

            Dictionary<string, byte[]> contraseñaUsuario = new Dictionary<string, byte[]>();

            using (var tx = session.BeginTransaction())
            {
                IQuery consultaContraseñaUsuario = session.GetNamedQuery("ObtenerContraseñaUsuario")
                                                          .SetParameter("nombreUsuario", nombreUsuario);

                object[] o = (object[]) consultaContraseñaUsuario.UniqueResult();

                byte[] saltContraseña = (byte[])o[0];
                byte[] hashContraseña = (byte[])o[1];

                contraseñaUsuario.Add("SaltContraseña", saltContraseña);
                contraseñaUsuario.Add("HashContraseña", hashContraseña);

                tx.Commit();
            }

            return contraseñaUsuario;
        }

        public Usuario CrearCuentaUsuario(Usuario usuario, byte[] saltContraseña, byte[] hashContraseña)
        {
            throw new NotImplementedException();
        }
    }
}