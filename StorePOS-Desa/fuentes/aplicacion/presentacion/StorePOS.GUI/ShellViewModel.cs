namespace StorePOS.GUI
{
    #region Using

    using System;
    using System.Reflection;
    using System.Dynamic;
    using System.Windows;
    using System.ComponentModel.Composition;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Ninject;
    using Caliburn.Micro;
    using Util;

    #endregion

    public class ShellViewModel : Conductor<object>, IHandle<VisualizationViewModel>
    {
        private readonly IWindowManager windowManager;
        private readonly IEventAggregator eventAggregator;
        private bool isSettingsFlyoutOpen;

        #region Ctor

        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            this.windowManager = windowManager;
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe(this);

            VisualizationViewModel visualization = new VisualizationViewModel("DesktopViewModel", VisualizationViewModelType.Screen);

            this.Handle(visualization);

            //InicializarDatosPrueba();
        }

        #endregion

        #region Propiedades

        public bool IsSettingsFlyoutOpen
        {
            get { return isSettingsFlyoutOpen; }
            set
            {
                isSettingsFlyoutOpen = value;
                NotifyOfPropertyChange(() => IsSettingsFlyoutOpen);
            }
        }

        public void OpenSettings()
        {
            IsSettingsFlyoutOpen = true;
        }


        #endregion

        #region Metodos

        public void MostrarViewModel(string viewModel)
        {
            VisualizationViewModel visualization = new VisualizationViewModel(viewModel, VisualizationViewModelType.Screen);

            this.eventAggregator.PublishOnUIThread(visualization);
        }

        public void MostrarPopupViewModel(string viewModel)
        {
            VisualizationViewModel visualization = new VisualizationViewModel(viewModel, VisualizationViewModelType.Window);

            this.eventAggregator.PublishOnUIThread(visualization);
        }

        #endregion

        #region Implementacion IHandle<string>

        public void Handle(VisualizationViewModel visualization)
        {
            IScreen viewModelScreen = ScreenLocator.Get(visualization.ViewModel);

            if (visualization.VisualizationViewModelType == VisualizationViewModelType.Screen)
                ActivateItem(viewModelScreen);
            else
                windowManager.ShowWindow(viewModelScreen, null, null);
        }

        #endregion
    }
    
    
    //#region Using

    //using System.Dynamic;
    //using System.Windows;
    //using System.ComponentModel.Composition;
    //using Caliburn.Micro;
    //using Ventas;
    //using System.Collections.Generic;
    //using System.Collections.ObjectModel;

    //#endregion

    //public class ShellViewModel : Screen
    //{
    //    private readonly IWindowManager windowManager;
    //    private bool isSettingsFlyoutOpen;

    //    private ObservableCollection<TodoItem> items = new ObservableCollection<TodoItem>();

    //    public ObservableCollection<TodoItem> Items
    //    {
    //        get { return items; }
    //        set { items = value; }
    //    }

    //    [ImportingConstructor]
    //    public ShellViewModel(Caliburn.Micro.IWindowManager windowManager)
    //    {
    //        this.windowManager = windowManager;

    //        items.Add(new TodoItem() { Title = "Nueva Factura", Completion = 45, Color = "#CC60A917", Image = "appbar_add", ViewModelName = "GenerarFacturaViewModel" });
    //        items.Add(new TodoItem() { Title = "Nueva N.Credito", Completion = 80, Color = "#CC60A917", Image = "appbar_add", ViewModelName =  string.Empty });
    //        items.Add(new TodoItem() { Title = "Cancelar Factura / N.Credito", Completion = 0, Color = "#CC60A917", Image = "appbar_add", ViewModelName = string.Empty });
    //    }

    //    public bool IsSettingsFlyoutOpen
    //    {
    //        get { return isSettingsFlyoutOpen; }
    //        set
    //        {
    //            isSettingsFlyoutOpen = value;
    //            NotifyOfPropertyChange(() => IsSettingsFlyoutOpen);
    //        }
    //    }

    //    public void OpenSettings()
    //    {
    //        IsSettingsFlyoutOpen = true;
    //    }

    //    public void MostrarGenerarFactura()
    //    {
    //        dynamic settings = new ExpandoObject();
    //        settings.WindowStartupLocation = WindowStartupLocation.Manual;
    //        settings.Title = "Generar Factura";
    //        windowManager.ShowWindow(AppBootstrapper.Kernel.GetService(typeof(GenerarFacturaViewModel)), null, settings);
    //    }

    //    public void OpenWindow(string viewModel)
    //    {
    //        dynamic settings = new ExpandoObject();

    //        settings.WindowStartupLocation = WindowStartupLocation.CenterScreen;
    //        settings.WindowState = WindowState.Maximized;

    //        switch (viewModel)
    //        {
    //            case "GenerarFacturaViewModel":
    //                windowManager.ShowWindow(new Ventas.GenerarFacturaViewModel(), null, settings);
    //                break;
    //        }
    //    }
    //}

    //public class TodoItem
    //{
    //    public string Title { get; set; }
    //    public int Completion { get; set; }
    //    public string Color { get; set; }
    //    public string Image { get; set; }
    //    public string ViewModelName { get; set; }
    //}
}