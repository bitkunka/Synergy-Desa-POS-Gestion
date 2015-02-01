namespace StorePOS.GUI.Ventas
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Caliburn.Micro;
    using StorePOS.GUI.Util;

    #endregion

    public class DesktopViewModel : Screen
    {
        private readonly IWindowManager windowManager;
        private ObservableCollection<DesktopOptionItem> itemsTransacciones = new ObservableCollection<DesktopOptionItem>();
        private ObservableCollection<DesktopOptionItem> itemsInformes = new ObservableCollection<DesktopOptionItem>();
        private ObservableCollection<DesktopOptionItem> itemsAdministracion = new ObservableCollection<DesktopOptionItem>();

        #region Ctor

        [ImportingConstructor]
        public DesktopViewModel(Caliburn.Micro.IWindowManager windowManager)
        {
            this.windowManager = windowManager;

            itemsTransacciones.Add(new DesktopOptionItem() { Title = "Factura/Ticket", Color = "#CC60A917", Image = "appbar_add", ViewModelName = "GenerarFacturaViewModel" });
            itemsTransacciones.Add(new DesktopOptionItem() { Title = "N.Credito/Ticket", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
            itemsTransacciones.Add(new DesktopOptionItem() { Title = "N.Debito/Ticket", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });

            itemsTransacciones.Add(new DesktopOptionItem() { Title = "Factura/Manual", Color = "#CC60A917", Image = "appbar_add", ViewModelName = "GenerarFacturaViewModel" });
            itemsTransacciones.Add(new DesktopOptionItem() { Title = "N.Credito/Manual", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
            itemsTransacciones.Add(new DesktopOptionItem() { Title = "N.Debito/Manual", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });

            itemsTransacciones.Add(new DesktopOptionItem() { Title = "Cancelaciones", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });

            itemsInformes.Add(new DesktopOptionItem() { Title = "Consulta de Facturas/N.Credito", Color = "#CC60A917", Image = "appbar_add", ViewModelName = "GenerarFacturaViewModel" });
            itemsInformes.Add(new DesktopOptionItem() { Title = "Resumen Facturas/N.Credito", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
            itemsInformes.Add(new DesktopOptionItem() { Title = "Estado de Cuenta de Clientes", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
            itemsInformes.Add(new DesktopOptionItem() { Title = "Consulta de Articulos / Precio de Venta", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });

            itemsAdministracion.Add(new DesktopOptionItem() { Title = "Lista de Precio de Venta", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
        }

        #endregion

        #region Propiedades

        public ObservableCollection<DesktopOptionItem> ItemsTransacciones
        {
            get { return itemsTransacciones; }
            set { itemsTransacciones = value; }
        }

        public ObservableCollection<DesktopOptionItem> ItemsInformes
        {
            get { return itemsInformes; }
            set { itemsInformes = value; }
        }

        public ObservableCollection<DesktopOptionItem> ItemsAdministracion
        {
            get { return itemsAdministracion; }
            set { itemsAdministracion = value; }
        }

        #endregion
    }
}
