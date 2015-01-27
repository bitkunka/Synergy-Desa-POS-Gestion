namespace SynergyGestion.GUI
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
        private NavBarViewModel navBar;

        #region Ctor

        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            this.windowManager = windowManager;
            eventAggregator.Subscribe(this);

            this.NavBar = new NavBarViewModel(windowManager, eventAggregator);

            // desa luego eliminar

            InicializarDatosPrueba();
        }

        #endregion

        #region Propiedades

        public NavBarViewModel NavBar
        {
            get
            {
                return navBar;
            }
            set
            {
                navBar = value;
                NotifyOfPropertyChange(() => NavBar);
            }
        }

        #endregion

        #region Metodos

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

        private void InicializarDatosPrueba()
        {
            Dominio.Modelo.Trabajos.DatosEjemplo.Inicializar();
        }
    }
}