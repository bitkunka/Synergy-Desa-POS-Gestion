namespace StorePOS.GUI.Ventas
{
    #region Using

    using System;

    #endregion

    public class TalleArticulo
    {
        private int talle;

        public TalleArticulo(int talle)
        {
            this.talle = talle;
        }

        public int Talle
        {
            get { return talle; }
            set { talle = value; }
        }

        public override string ToString()
        {
            return this.Talle.ToString();
        }
    }
}
