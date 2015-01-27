namespace StorePOS.Aplicacion.Impl
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Dominio.Comun;
    using Dominio.Modelo.Compras;

    #endregion

    public class ProveedorServicio : IProveedorServicio
    {
        private readonly IProveedorRepositorio repositorioProveedor;

        public ProveedorServicio(IProveedorRepositorio repositorioProveedor)
        {
            this.repositorioProveedor = repositorioProveedor;
        }

        public IList<Proveedor> BuscarProveedores(string cuit, string nombre)
        {
            return this.repositorioProveedor.BuscarProveedores(cuit, nombre);
        }

        public Proveedor GuardarProveedor(Proveedor proveedor)
        {
            this.repositorioProveedor.Guardar(proveedor);

            return proveedor;
        }
        
        public void Dispose()
        {
            this.repositorioProveedor.Dispose();
        }
    }
}
