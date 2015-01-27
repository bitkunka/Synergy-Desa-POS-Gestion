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

    public class PresupuestoViewModel: Screen
    {
        private BindableCollection<Actividad> actividades;

        #region Ctor

        public PresupuestoViewModel()
        {
            IEnumerable<Actividad> enumerableActividades = DatosEjemplo.Actividades;

            actividades = new BindableCollection<Actividad>(enumerableActividades);
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

        public BindableCollection<Actividad> Actividades
        {
            get { return actividades; }
        }

        #endregion

        #region Metodos

       

        #endregion
    }
}
