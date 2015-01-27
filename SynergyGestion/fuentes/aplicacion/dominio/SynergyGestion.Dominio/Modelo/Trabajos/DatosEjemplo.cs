namespace SynergyGestion.Dominio.Modelo.Trabajos
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public static class DatosEjemplo
    {
        private static Trabajo trabajo1;
        private static Trabajo trabajo2;
        private static IEnumerable<Trabajo> trabajos;

        private static Actividad actividad1;
        private static IEnumerable<Actividad> actividades;

        private static Rubro rubro1;

        public static void Inicializar()
        {
            CrearTrabajos();

            CrearRubros();

            CrearActividades();
        }

        private static void CrearTrabajos() 
        {
            List<Trabajo> listTrabajos = new List<Trabajo>();
            
            trabajo1 = new Trabajo("OBRA1", new DateTime(2015, 1, 1), new FichaTecnica());

            listTrabajos.Add(trabajo1);

            trabajo2 = new Trabajo("OBRA2", new DateTime(2015, 1, 1), new FichaTecnica());

            listTrabajos.Add(trabajo2);

            trabajos = listTrabajos;
        }

        public static IEnumerable<Trabajo> Trabajos
        {
            get 
            { 
                return DatosEjemplo.trabajos; 
            }
        }

        public static Trabajo TRABAJO1
        {
            get
            {
                return trabajo1;
            }
        }

        public static Trabajo TRABAJO2
        {
            get
            {
                return trabajo2;
            }
        }

        private static void CrearActividades()
        {
            List<Actividad> listActividades = new List<Actividad>();
            
            actividad1 = new Actividad("actividad1", rubro1, new General.UnidadMedida("U"), 1, 10, 12, EstadoActividad.EnCurso);

            listActividades.Add(actividad1);

            actividades = listActividades;
        }

        public static IEnumerable<Actividad> Actividades
        {
            get { return DatosEjemplo.actividades; }
            set { DatosEjemplo.actividades = value; }
        }

        public static void CrearRubros()
        {
            rubro1 = new Rubro("Fundaciones");
        }

        public static Rubro Rubro1
        {
            get { return DatosEjemplo.rubro1; }
            set { DatosEjemplo.rubro1 = value; }
        }
    }
}
