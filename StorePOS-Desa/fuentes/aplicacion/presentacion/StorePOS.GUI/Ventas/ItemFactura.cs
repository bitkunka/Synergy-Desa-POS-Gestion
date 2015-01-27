namespace StorePOS.GUI.Ventas
{
    #region Using

    using System;
    using StorePOS.GUI.Fake;

    #endregion

    public class ItemFactura
    {
        private long id;
        private Articulo articulo;
        private ColorArticulo colorArticulo;
        private TalleArticulo talleArticulo;
        private int cantidad;
        private decimal precio;

        public ItemFactura(Articulo articulo)
        {
            this.articulo = articulo;
        }

        #region Propiedades

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public ColorArticulo ColorArticulo
        {
            get { return articulo.Color; }
        }

        public TalleArticulo TalleArticulo
        {
            get { return articulo.Talle; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        #endregion
    }
}
