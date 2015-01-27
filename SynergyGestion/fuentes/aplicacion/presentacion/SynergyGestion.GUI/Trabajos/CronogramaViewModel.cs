namespace SynergyGestion.GUI.Trabajos
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Caliburn.Micro;
    using Dominio.Modelo.Trabajos;

    #endregion

    public class CronogramaViewModel: Screen
    {
        private BindableCollection<Trabajo> trabajos;

        #region Ctor

        public CronogramaViewModel()
        {
            IEnumerable<Trabajo> enumerableTrabajos = DatosEjemplo.Trabajos;

            trabajos = new BindableCollection<Trabajo>(enumerableTrabajos);
        }

        #endregion

        #region Propiedades

        //public string LegendTitle
        //{
        //    get
        //    {
        //        return this.legendTitle;
        //    }

        //    set
        //    {
        //        this.legendTitle = value;
        //        this.NotifyOfPropertyChange(() => this.legendTitle);
        //    }
        //}

        public BindableCollection<Trabajo> Trabajos
        {
            get { return trabajos; }
        }

        #endregion

        #region Metodos

       

        #endregion
    }
}
