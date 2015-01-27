namespace StorePOS.Dominio.Modelo.Inventario
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
        private static Articulo articulo1;
        private static Articulo articulo2;
        private static Articulo articulo3;
        private static Articulo articulo4;
        private static Articulo articulo5;

        private static Articulo articulo10;
        private static Articulo articulo20;
        private static Articulo articulo30;

        private static GrupoArticulo grupo1;
        private static GrupoArticulo grupo2;

        private static GrupoArticulo grupo10;
        private static GrupoArticulo grupo20;
        private static GrupoArticulo grupo30;
        private static GrupoArticulo grupo40;
        private static GrupoArticulo grupo50;

        private static Stock stock1art1;
        
        public static void Inicializar()
        {
            CrearArticulos();

            CrearGrupoArticulos();

            CrearStockUbicaciones();
            
            StockUbicaciones = new List<Stock>();

            StockUbicaciones.Add(STOCK1_ART1);

            STOCK1_ART1.Articulo.IncrementarCantidadStock(STOCK1_ART1.Cantidad);

            StockUbicaciones.Add(STOCK2_ART1);

            STOCK2_ART1.Articulo.IncrementarCantidadStock(STOCK2_ART1.Cantidad);
        }

        private static void CrearStockUbicaciones()
        {
            stock1art1 = new Stock(ART1, "ALMACEN_1", 100);
        }

        private static void CrearGrupoArticulos()
        {
            grupo1 = new GrupoArticulo("GRUPO 1", "Se describe GRUPO 1");
            grupo2 = new GrupoArticulo("GRUPO 2", "Se describe GRUPO 2");
            

            grupo10 = new GrupoArticulo("INDUMENTARIAS", "Se describe GRUPO Indumentarias");
            grupo20 = new GrupoArticulo("CAMISAS", "Se describe GRUPO Camisas");
            grupo30 = new GrupoArticulo("GRUPO 30", "Se describe GRUPO 30");
            grupo40 = new GrupoArticulo("GRUPO 40", "Se describe GRUPO 40");
            grupo50 = new GrupoArticulo("GRUPO 50", "Se describe GRUPO 50");

            grupo10.AgregarSubGrupo(grupo20);

            grupo10.AgregarArticulo(ART10);
            grupo20.AgregarArticulo(ART20);
            grupo30.AgregarArticulo(ART30);

            grupo20.AgregarSubGrupo(grupo30);
            grupo20.AgregarSubGrupo(grupo50);
        }

        private static void CrearArticulos()
        {
            articulo1 = new Articulo("CART1", "Se describe ART1", 10.0M, CriterioCosteo.PEPS);

            articulo2 = new Articulo("CART2", "Se describe ART2", 13.0M, CriterioCosteo.PEPS);

            articulo3 = new Articulo("CART3", "Se describe ART3", 15.0M, CriterioCosteo.PPP);

            articulo4 = new Articulo("CART4", "Se describe ART4", 12.0M, CriterioCosteo.PPP);

            articulo5 = new Articulo("CART5", "Se describe ART5", 11.0M, CriterioCosteo.PPP);

            articulo10 = new Articulo("CART10", "Se describe ART10", 10.0M, CriterioCosteo.PEPS);

            articulo20 = new Articulo("CART20", "Se describe ART20", 13.0M, CriterioCosteo.PEPS);

            articulo30 = new Articulo("CART30", "Se describe ART30", 13.0M, CriterioCosteo.PEPS);
        }
        
        public static List<Stock> StockUbicaciones 
        { 
            get; 
            set; 
        }

        #region Grupo 1

        public static GrupoArticulo GRUPO1
        {
            get
            {
                return grupo1;
            }
        }

        public static GrupoArticulo GRUPO10
        {
            get
            {
                return grupo10;
            }
        }

        public static GrupoArticulo GRUPO40
        {
            get
            {
                return grupo40;
            }
        }


        #endregion

        #region Grupo 2

        public static GrupoArticulo GRUPO2
        {
            get
            {
                return grupo2;
            }
        }

        #endregion

        #region Articulo 1

        public static Articulo ART1
        {
            get
            {
                return articulo1;
            }
        }

        public static Articulo ART10
        {
            get
            {
                return articulo10;
            }
        }

        #endregion

        #region Articulo 2

        public static Articulo ART2
        {
            get
            {
                return articulo2;
            }
        }

        public static Articulo ART20
        {
            get
            {
                return articulo20;
            }
        }

        #endregion

        #region Articulo 3

        public static Articulo ART3
        {
            get
            {
                return articulo3;
            }
        }

        public static Articulo ART30
        {
            get
            {
                return articulo30;
            }
        }

        #endregion

        #region Articulo 4

        public static Articulo ART4
        {
            get
            {
                return articulo4;
            }
        }

        #endregion

        #region Articulo 5

        public static Articulo ART5
        {
            get
            {
                return articulo5;
            }
        }

        #endregion

        public static Stock STOCK1_ART1 
        {
            get
            {
               return stock1art1;
            }
        }

        public static Stock STOCK2_ART1
        {
            get
            {
                return new Stock(ART1, "ALMACEN_2", 20);
            }
        }

        public static MovimientoStock MOV_STOCK_ART1()
        {
            MovimientoStock MOV_STOCK_ART1 = null; 
                
            //    = new MovimientoStock();

            //MOV_STOCK_ART1.Stock = STOCK_ART_1();
            //MOV_STOCK_ART1.Cantidad = -10;
            

            return MOV_STOCK_ART1;
        }
    }
}
