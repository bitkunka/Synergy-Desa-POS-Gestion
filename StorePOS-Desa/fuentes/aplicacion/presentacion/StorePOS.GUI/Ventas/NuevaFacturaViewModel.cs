namespace StorePOS.GUI.Ventas
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Caliburn.Micro;
    using System.Windows.Input;
    using StorePOS.GUI.Fake;

    #endregion

    public class NuevaFacturaViewModel : Screen
    {
        private string filtro = "Cod o Desc.";
        private BindableCollection<Articulo> articulos = new BindableCollection<Articulo>();
        private Articulo articuloSeleccionado;
        private TabFacturaVenta tabFacturaSeleccionado;
        private BindableCollection<ItemFacturaViewModel> itemsFactura = new BindableCollection<ItemFacturaViewModel>();

        #region Ctor

        public NuevaFacturaViewModel()
	    {
            Articulo.Init();
            this.tabFacturaSeleccionado = TabFacturaVenta.Encabezado;
	    }

        #endregion

        #region Propiedades

        public string Filtro
        {
            get
            {
                return this.filtro;
            }
            set
            {
                filtro = value;
                NotifyOfPropertyChange(() => Filtro);
            }
        }

        public BindableCollection<Articulo> Articulos
        {
            get 
            { 
                return articulos; 
            }
            set 
            { 
                articulos = value;
                NotifyOfPropertyChange(() => Articulos);
            }
        }

        public Articulo ArticuloSeleccionado
        {
            get 
            { 
                return articuloSeleccionado; 
            }
            set 
            { 
                articuloSeleccionado = value;
                NotifyOfPropertyChange(() => ArticuloSeleccionado);
            }
        }

        public int TabFacturaSeleccionado
        {
            get
            {
                return (int)tabFacturaSeleccionado;
            }
            set
            {
                tabFacturaSeleccionado = (TabFacturaVenta)value;
                NotifyOfPropertyChange(() => TabFacturaSeleccionado);
            }
        }

        public BindableCollection<ItemFacturaViewModel> ItemsFactura
        {
            get 
            { 
                return itemsFactura; 
            }
            set 
            { 
                itemsFactura = value;
                NotifyOfPropertyChange(() => ItemsFactura);
            }
        }

        #endregion

        #region Metodos

        public void BuscarArticulos()
        {
            this.Articulos = (BindableCollection<Articulo>)Articulo.ObtenerArticulos(string.Empty, string.Empty);
        }

        public void AgregarArticulo()
        {
            Articulo articulo = this.ArticuloSeleccionado;

            this.TabFacturaSeleccionado = (int)TabFacturaVenta.Articulos;

            ItemFacturaViewModel nuevoItem = new ItemFacturaViewModel(articulo);

            nuevoItem.Cantidad = 1;
            nuevoItem.Precio = 12;

            ItemsFactura.Add(nuevoItem);
        }

        #endregion
    }

    public enum TabFacturaVenta
    {
        Encabezado = 0,
        Articulos = 1,
        Pagos = 2
    }

    public class ItemFacturaViewModel : PropertyChangedBase
    {
        private ItemFactura item;

        public ItemFacturaViewModel(Articulo articulo)
        {
            item = new ItemFactura(articulo);
        }

        public long Id
        {
            get { return item.Id; }
            set
            {
                if (item.Id != value)
                {
                    item.Id = value;
                    NotifyOfPropertyChange(() => Id);
                }
            }
        }

        public string Articulo
        {
            get { return item.Articulo.Descripcion; }
        }

        public string ColorArticulo
        {
            get { return item.ColorArticulo.ToString(); }
        }

        public TalleArticulo TalleArticulo
        {
            get { return item.TalleArticulo; }
        }

        public int Cantidad
        {
            get { return item.Cantidad; }
            set
            {
                if (item.Cantidad != value)
                {
                    item.Cantidad = value;
                    NotifyOfPropertyChange(() => Cantidad);
                }
            }
        }

        public decimal Precio
        {
            get { return item.Precio; }
            set
            {
                if (item.Precio != value)
                {
                    item.Precio = value;
                    NotifyOfPropertyChange(() => Precio);
                    NotifyOfPropertyChange(() => Importe);
                }
            }
        }

        public decimal Importe
        {
            get { return item.Cantidad * item.Precio; }
        }

        public ItemFactura Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
