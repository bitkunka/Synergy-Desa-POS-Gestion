namespace StorePOS.GUI.Util
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Ninject;
    using Caliburn.Micro;

    #endregion

    public static class ScreenLocator
    {
        public static IScreen Get(string viewModel)
        {
            IScreen viewModelScreen;
            Assembly assem = typeof(ShellViewModel).Assembly;
            AssemblyName assemName = assem.GetName();

            Type viewModelType = assem.GetType(string.Format("{0}.{1}", assemName.Name, viewModel));

            if (viewModelType != null)
                viewModelScreen = (IScreen)AppBootstrapper.Kernel.Get(viewModelType);
            else
                throw new ApplicationException("No se pudo localizar la función solicitada.");

            return viewModelScreen;
        }
    }
}
