namespace SynergyGestion.Dominio.Modelo.Ventas
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    #endregion
    
    public class CestaOrdenVenta
    {
        private int indiceItems = 0;
       
        private string documentoComercial;
        private DateTime fechaDocumento;
        private int idProveedor;
        private int idUsuario;

        public CestaOrdenVenta()
        { 
        
        }

        public CestaOrdenVenta(int idUsuario)
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

        private IList<ItemCestaOrdenVenta> items = new List<ItemCestaOrdenVenta>();

        public IList<ItemCestaOrdenVenta> Items
        {
            get { return items; }
            set { items = value; }
        }

        #region Items Collection Methods

        public virtual void AgregarItem(ItemCestaOrdenVenta item)
        {
            this.indiceItems += 1;
            item.NroItem = this.indiceItems;
            
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }

        public virtual void EliminarItem(ItemCestaOrdenVenta item)
        {
            int indice;

            this.indiceItems -= 1;
            
            if (items.Contains(item))
            {
                indice = items.IndexOf(item);
                
                items.Remove(item);
            }

            foreach (ItemCestaOrdenVenta cadaItem in this.Items)
            {
                cadaItem.NroItem = items.IndexOf(cadaItem) + 1;
            }
        }

        public virtual void Limpiar()
        {
            items.Clear();
        }

        public virtual void AgregarItems(IList<ItemCestaOrdenVenta> items)
        {
            foreach (var item in items)
            {
                AgregarItem(item);
            }
        }

        public virtual void AgregarActualizar(ItemCestaOrdenVenta item)
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

    public class ItemCestaOrdenVenta
    {
        public int NroItem { get; set; }
        public string CodigoArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
