namespace StorePOS.GUI
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.ComponentModel.Composition.Primitives;
    using System.Linq;
    using System.Windows;
    using Caliburn.Micro;
    using Ninject;

    #endregion

    public class AppBootstrapper : BootstrapperBase
    {
        public static IKernel Kernel;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            Kernel = new StandardKernel();

            Kernel.Bind<IWindowManager>().To<AppWindowManager>().InSingletonScope();
            Kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();

            Kernel.Bind<ShellViewModel>().ToSelf().InSingletonScope();
            Kernel.Bind<Ventas.GenerarFacturaViewModel>().ToSelf().InSingletonScope();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            Kernel.Dispose();
            base.OnExit(sender, e);
        }

        protected override object GetInstance(Type service, string key)
        {
            if (service == null)
                throw new ArgumentNullException("service");

            return Kernel.Get(service);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return Kernel.GetAll(service);
        }

        protected override void BuildUp(object instance)
        {
            Kernel.Inject(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}