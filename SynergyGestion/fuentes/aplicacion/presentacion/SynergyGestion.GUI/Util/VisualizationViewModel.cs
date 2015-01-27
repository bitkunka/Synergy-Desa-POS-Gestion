namespace SynergyGestion.GUI.Util
{
    #region Using

    using System;

    #endregion

    public class VisualizationViewModel
    {
        private string viewModel;
        private VisualizationViewModelType visualizationViewModelType;

        public VisualizationViewModel(string viewModel, VisualizationViewModelType visualizationViewModelType)
        {
            this.viewModel = viewModel;
            this.visualizationViewModelType = visualizationViewModelType;
        }

        public string ViewModel
        {
            get
            {
                return this.viewModel;
            }
            set
            {
                this.viewModel = value;
            }
        }

        public VisualizationViewModelType VisualizationViewModelType
        {
            get
            {
                return visualizationViewModelType;
            }
            set
            {
                visualizationViewModelType = value;
            }
        }
    }
}
