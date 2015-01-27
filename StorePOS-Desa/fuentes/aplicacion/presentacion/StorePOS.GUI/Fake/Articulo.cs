namespace StorePOS.GUI.Fake
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Caliburn.Micro;
    using StorePOS.GUI.Ventas;

    #endregion
    
    public class Articulo
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Familia { get; set; }
        public TalleArticulo Talle { get; set; }
        public ColorArticulo Color { get; set; }
        public string Marca { get; set; }

        public static BindableCollection<Articulo> ObtenerArticulos(string codigo, string descripcion)
        {
            BindableCollection<Articulo> listArticulos = new BindableCollection<Articulo>();

            return articulos;
        }

        public static void Init()
        {
            articulos = new BindableCollection<Articulo>();
            
            articulos.Add
            (
                new Articulo() { Id = 1, Codigo = 12345, Descripcion = "Pantalon Kosiuko", Color = new ColorArticulo("Celeste"), Familia = "Pantalon Damas", Marca = "Kosiuko", Talle = new TalleArticulo(32) }
            );

            articulos.Add
            (
                new Articulo() { Id = 2, Codigo = 12346, Descripcion = "Pantalon Kosiuko", Color = new ColorArticulo("Azul"), Familia = "Pantalon Damas", Marca = "Kosiuko", Talle = new TalleArticulo(36) }
            );
        }

        public static BindableCollection<Articulo> articulos;
    }
}
