namespace StorePOS.GUI.Ventas
{
    #region Using

    using System;

    #endregion

    public class ColorArticulo
    {
        private string color;

        public ColorArticulo(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return this.Color;
        }
    }
}
