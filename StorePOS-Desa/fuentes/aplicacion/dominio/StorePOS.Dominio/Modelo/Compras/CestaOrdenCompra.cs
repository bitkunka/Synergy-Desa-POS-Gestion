namespace StorePOS.Dominio.Modelo.Compras
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Dominio.Modelo.Inventario;

    #endregion
    
    public class CestaOrdenCompra
    {
        private int indiceItems = 0;
       
        private string documentoComercial;
        private DateTime fechaDocumento;
        private int idProveedor;
        private int idUsuario;

        public CestaOrdenCompra()
        { 
        
        }

        public CestaOrdenCompra(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public int IndiceItems
        {
            get { return indiceItems; }
            set { indiceItems = value; }
        }

        public string DocumentoComercial
        {
            get { return documentoComercial; }
            set { documentoComercial = value; }
        }

        public DateTime FechaDocumento
        {
            get { return fechaDocumento; }
            set { fechaDocumento = value; }
        }

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
        }
        
        private IList<ItemCestaOrdenCompra> items = new List<ItemCestaOrdenCompra>();

        public IList<ItemCestaOrdenCompra> Items
        {
            get { return items; }
            set { items = value; }
        }

        #region Items Collection Methods

        public virtual void AgregarItem(ItemCestaOrdenCompra item)
        {
            this.indiceItems += 1;
            item.NroItem = this.indiceItems;
            
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }

        public virtual void EliminarItem(ItemCestaOrdenCompra item)
        {
            int indice;

            this.indiceItems -= 1;
            
            if (items.Contains(item))
            {
                indice = items.IndexOf(item);
                
                items.Remove(item);
            }

            foreach (ItemCestaOrdenCompra cadaItem in this.Items)
            {
                cadaItem.NroItem = items.IndexOf(cadaItem) + 1;
            }
        }

        public virtual void Limpiar()
        {
            items.Clear();
        }

        public virtual void AgregarItems(IList<ItemCestaOrdenCompra> items)
        {
            foreach (var item in items)
            {
                AgregarItem(item);
            }
        }

        public virtual void AgregarActualizar(ItemCestaOrdenCompra item)
        {
            if (!items.Contains(item))
            {
                AgregarItem(item);
            }
            else
            {
                items[items.IndexOf(item)] = item;
            }
        }

        #endregion
    }

    public class ItemCestaOrdenCompra
    {
        public int NroItem { get; set; }
        public string CodigoArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
