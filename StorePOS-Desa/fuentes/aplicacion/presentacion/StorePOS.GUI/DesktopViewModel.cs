namespace StorePOS.GUI
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
        private ObservableCollection<DesktopOptionItem> desktopOptionItems = new ObservableCollection<DesktopOptionItem>();

        #region Ctor

        [ImportingConstructor]
        public DesktopViewModel(Caliburn.Micro.IWindowManager windowManager)
        {
            this.windowManager = windowManager;

            desktopOptionItems.Add(new DesktopOptionItem() { Title = "Nueva Factura", Color = "#CC60A917", Image = "appbar_add", ViewModelName = "Ventas.GenerarFacturaViewModel" });
            desktopOptionItems.Add(new DesktopOptionItem() { Title = "Nueva N.Credito", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
            desktopOptionItems.Add(new DesktopOptionItem() { Title = "Cancelar Factura / N.Credito", Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
        }

        #endregion

        #region Propiedades

        public ObservableCollection<DesktopOptionItem> DesktopOptionItems
        {
            get { return desktopOptionItems; }
            set { desktopOptionItems = value; }
        }

        #endregion
    }
}
