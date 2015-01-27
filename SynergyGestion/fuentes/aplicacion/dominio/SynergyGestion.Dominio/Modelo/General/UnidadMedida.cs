namespace SynergyGestion.Dominio.Modelo.General
{
    #region Using

    using System;

    #endregion

    public class UnidadMedida
    {
        private string nombre;

        #region Ctor

        public UnidadMedida(string nombre)
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
