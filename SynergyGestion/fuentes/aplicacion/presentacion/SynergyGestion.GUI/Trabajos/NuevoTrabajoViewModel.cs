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

    public class NuevoTrabajoViewModel: Screen
    {
        #region Ctor

        public NuevoTrabajoViewModel()
        {
           
        }

        #endregion

        #region Propiedades

        #endregion

        #region Metodos

       

        #endregion
    }

    public class TrabajoViewModel : PropertyChangedBase
    {
        private string nombre;
        private DateTime fecha;
        
        #region Ctor

        #endregion

        #region Propiedades

        public virtual string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                this.NotifyOfPropertyChange(()=>this.Nombre);
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }


        #endregion
    }
}
