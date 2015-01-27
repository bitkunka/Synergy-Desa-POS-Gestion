namespace SynergyGestion.GUI
{
    #region Using

    using System;
    using System.Dynamic;
    using System.Windows;
    using System.ComponentModel.Composition;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using Ninject;
    using Caliburn.Micro;
    using Util;

   
    #endregion

    public class NavBarViewModel: Screen
    {
        private readonly IWindowManager windowManager;
        private readonly IEventAggregator eventAggregator;

        #region Ctor

        [ImportingConstructor]
        public NavBarViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            this.windowManager = windowManager;
            this.eventAggregator = eventAggregator;   
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
    }
}
