namespace SynergyGestion.Dominio.Modelo.Trabajos
{
    #region Using

    using System;

    #endregion

    public class Rubro
    {
        private string nombre;

        #region Ctor

        public Rubro(string nombre)
        {
            this.nombre = nombre;
        }

        #endregion


        #region Using

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion
    }
}
