namespace SynergyGestion.Dominio.Modelo.AdministracionSistema
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
        private static Usuario usuario1;

        public static void Inicializar()
        {
            CrearUsuarios();
        }

        private static void CrearUsuarios()
        {
            usuario1 = new Usuario("admin");
        }

        public static Usuario USUARIO1
        {
            get
            {
                return usuario1;
            }
        }

        public static Modulo MODULO_STOCK()
        {
            Menu MENU_STK = new Menu();
            MENU_STK.Roles = new string[] { "CLG_TRSN", "CLG_TRSN2" };

            #region TRSN

            OpcionMenu OPCION_STK_TRSN = new OpcionMenu();

            OPCION_STK_TRSN.Nombre = string.Empty;
            OPCION_STK_TRSN.Titulo = "Registro de Productos";
            OPCION_STK_TRSN.NombreImagen = "carpeta_abierta";

            OPCION_STK_TRSN.AddSubOpcion
            (
                new OpcionMenu() 
                {
                    Nombre = string.Empty,
                    Titulo = "ABM Productos",
                    NombreImagen = "formulario1" 
                }
            );

            //OPCION_STK_TRSN.AddSubOpcion
            //(
            //    new OpcionMenu()
            //    {
            //        Nombre = "MovSalida",
            //        Titulo = "Sobrante inventario",
            //        NombreImagen = "transacciones"
            //    }
            //);

            //OPCION_STK_TRSN.AddSubOpcion
            //(
            //    new OpcionMenu()
            //    {
            //        Nombre = "MovTransferencia",
            //        Titulo = "Remitos Transferencia",
            //        NombreImagen = "transacciones"
            //    }
            //);

            MENU_STK.AddOpcion(OPCION_STK_TRSN);

            #endregion

            #region CFG

            OpcionMenu OPCION_STK_CFG = new OpcionMenu();

            OPCION_STK_CFG.Nombre = string.Empty;
            OPCION_STK_CFG.Titulo = "Ajustes de Productos";
            OPCION_STK_CFG.NombreImagen = "carpeta_abierta";

            OpcionMenu opcionMenuAjusteCantidades = new OpcionMenu()
            {
                Nombre = string.Empty,
                Titulo = "Ajustes de Cantidades",
                NombreImagen = "carpeta_abierta"
            };

            opcionMenuAjusteCantidades.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Faltante de Stock",
                    NombreImagen = "formulario1"
                }
            );

            opcionMenuAjusteCantidades.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Sobrante de Stock",
                    NombreImagen = "formulario1"
                }
            );

            OPCION_STK_CFG.AddSubOpcion
            (
                opcionMenuAjusteCantidades
            );

            OPCION_STK_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Ajustes de Precios",
                    NombreImagen = "carpeta_abierta"
                }
            );

            OPCION_STK_CFG.AddSubOpcion
           (
               new OpcionMenu()
               {
                   Nombre = string.Empty,
                   Titulo = "Costos",
                   NombreImagen = "carpeta_abierta"
               }
           );

            MENU_STK.AddOpcion(OPCION_STK_CFG);

            #endregion

            #region RPT

            OpcionMenu OPCION_RPT_CFG = new OpcionMenu();

            OPCION_RPT_CFG.Nombre = string.Empty;
            OPCION_RPT_CFG.Titulo = "Reportes";
            OPCION_RPT_CFG.NombreImagen = "carpeta_abierta";

            OPCION_RPT_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Stock Usuarios",
                    NombreImagen = "informes"
                }
            );

            OPCION_RPT_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Reporte de Movimientos",
                    NombreImagen = "informes"
                }
            );

            OPCION_RPT_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Buscador de Materiales",
                    NombreImagen = "informes"
                }
            );

            OPCION_RPT_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Valorizado Familia",
                    NombreImagen = "informes"
                }
            );

            OPCION_RPT_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Valorizado Usuario",
                    NombreImagen = "informes"
                }
            );

            OPCION_RPT_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Valorizado Imputación",
                    NombreImagen = "informes"
                }
            );

            MENU_STK.AddOpcion(OPCION_RPT_CFG);

            #endregion

            Modulo MODULO_CATALOGO = new Modulo();

            MODULO_CATALOGO.Nombre = "Stock";
            MODULO_CATALOGO.Titulo = "Inventario";
            MODULO_CATALOGO.NombreImagen = "stock22";
            MODULO_CATALOGO.Menu = MENU_STK;

            return MODULO_CATALOGO;
        }

        public static Modulo MODULO_VENTAS()
        {
            Modulo MODULO_VENTAS = new Modulo();

            Menu MENU_VTS = new Menu();
            MENU_VTS.Roles = new string[] { "CLG_TRSN", "CLG_TRSN2" };

            #region TRSN

            OpcionMenu OPCION_VTS_TRSN = new OpcionMenu();

            OPCION_VTS_TRSN.Nombre = string.Empty;
            OPCION_VTS_TRSN.Titulo = "Gestión de Ventas";
            OPCION_VTS_TRSN.NombreImagen = "carpeta_abierta";

   
            OPCION_VTS_TRSN.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Ventas.GenerarOrdenVentaPresentador",
                    Titulo = "Registrar Ventas",
                    NombreImagen = "formulario1"
                }
            );

            OPCION_VTS_TRSN.AddSubOpcion
           (
               new OpcionMenu()
               {
                   Nombre = string.Empty,
                   Titulo = "Anular Ventas",
                   NombreImagen = "formulario1"
               }
           );

            MENU_VTS.AddOpcion(OPCION_VTS_TRSN);

            #endregion

            #region RPT

            OpcionMenu OPCION_VTS_RPT = new OpcionMenu();

            OPCION_VTS_RPT.Nombre = string.Empty;
            OPCION_VTS_RPT.Titulo = "Informes";
            OPCION_VTS_RPT.NombreImagen = "carpeta_abierta";

            OPCION_VTS_RPT.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Consultar Ventas/Anulaciónes",
                    NombreImagen = "informes"
                }
            );


            OPCION_VTS_RPT.AddSubOpcion
           (
               new OpcionMenu()
               {
                   Nombre = string.Empty,
                   Titulo = "Consultar Catálogo de Articulos",
                   NombreImagen = "informes"
               }
           );

            MENU_VTS.AddOpcion(OPCION_VTS_RPT);

            #endregion

            #region CFG

            OpcionMenu OPCION_VTS_CFG = new OpcionMenu();

            OPCION_VTS_CFG.Nombre = string.Empty;
            OPCION_VTS_CFG.Titulo = "Configuración";
            OPCION_VTS_CFG.NombreImagen = "carpeta_abierta";

            OPCION_VTS_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Administrar Lista de Precios",
                    NombreImagen = "configuracion"
                }
            );

            MENU_VTS.AddOpcion(OPCION_VTS_CFG);

            #endregion

            MODULO_VENTAS.Nombre = "Ventas";
            MODULO_VENTAS.Titulo = "Ventas";
            MODULO_VENTAS.NombreImagen = "ventas24";
            MODULO_VENTAS.Menu = MENU_VTS;

            return MODULO_VENTAS;
        }

        // en uso
        public static Modulo MODULO_MERCADERIAS()
        {
            Modulo MODULO_MERCADERIAS = new Modulo();

            Menu MENU_MRC = new Menu();
            MENU_MRC.Roles = new string[] { "CLG_TRSN", "CLG_TRSN2" };

            #region TRSN

            OpcionMenu OPCION_MRC_TRSN = new OpcionMenu();

            OPCION_MRC_TRSN.Nombre = string.Empty;
            OPCION_MRC_TRSN.Titulo = "Gestión de Stock";
            OPCION_MRC_TRSN.NombreImagen = "carpeta_abierta";

            OPCION_MRC_TRSN.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Inventario.RegistrarRemitoIngresoStockPresentador",
                    Titulo = "Ingresar Stock / Compra a Proveedores",
                    NombreImagen = "formulario1"
                }
            );

            OPCION_MRC_TRSN.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Registrar Ajuste de Inventario",
                    NombreImagen = "formulario1"
                }
            );


            MENU_MRC.AddOpcion(OPCION_MRC_TRSN);

            #endregion

            #region RPT

            OpcionMenu OPCION_MRC_RPT = new OpcionMenu();

            OPCION_MRC_RPT.Nombre = string.Empty;
            OPCION_MRC_RPT.Titulo = "Informes";
            OPCION_MRC_RPT.NombreImagen = "carpeta_abierta";

            OPCION_MRC_RPT.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Inventario.ConsultaStockPresentador",
                    Titulo = "Consultar Stock",
                    NombreImagen = "informes"
                }
            );

            OPCION_MRC_RPT.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Consultar Movimientos de Stock",
                    NombreImagen = "informes"
                }
            );

            MENU_MRC.AddOpcion(OPCION_MRC_RPT);

            #endregion

            #region CFG

            OpcionMenu OPCION_MRC_CFG = new OpcionMenu();

            OPCION_MRC_CFG.Nombre = string.Empty;
            OPCION_MRC_CFG.Titulo = "Configuración";
            OPCION_MRC_CFG.NombreImagen = "carpeta_abierta";

            OPCION_MRC_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Inventario.AdministrarCatalogoArticulosPresentador",
                    Titulo = "Administrar Catálogo de Articulos",
                    NombreImagen = "configuracion"
                }
            );

            OPCION_MRC_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Inventario.AdministrarGrupoArticulosPresentador",
                    Titulo = "Administrar Agrupamiento de Articulos",
                    NombreImagen = "configuracion"
                }
            );

            MENU_MRC.AddOpcion(OPCION_MRC_CFG);

            #endregion

            MODULO_MERCADERIAS.Nombre = "Inventario";
            MODULO_MERCADERIAS.Titulo = "Inventario";
            MODULO_MERCADERIAS.NombreImagen = "stock22";
            MODULO_MERCADERIAS.Menu = MENU_MRC;

            return MODULO_MERCADERIAS;
        }

        public static Modulo MODULO_COMPRAS()
        {
            Modulo MODULO_COMPRAS = new Modulo();

            Menu MENU_CPR = new Menu();
            MENU_CPR.Roles = new string[] { "CLG_TRSN", "CLG_TRSN2" };

            #region TRSN

            OpcionMenu OPCION_CPR_TRSN = new OpcionMenu();

            OPCION_CPR_TRSN.Nombre = string.Empty;
            OPCION_CPR_TRSN.Titulo = "Gestión de Compras";
            OPCION_CPR_TRSN.NombreImagen = "carpeta_abierta";


            OPCION_CPR_TRSN.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Compras.GenerarOrdenCompraPresentador",
                    Titulo = "Registrar Compras",
                    NombreImagen = "formulario1"
                }
            );

            OPCION_CPR_TRSN.AddSubOpcion
           (
               new OpcionMenu()
               {
                   Nombre = string.Empty,
                   Titulo = "Anular Compras",
                   NombreImagen = "formulario1"
               }
           );

            MENU_CPR.AddOpcion(OPCION_CPR_TRSN);

            #endregion

            #region RPT

            OpcionMenu OPCION_CPR_RPT = new OpcionMenu();

            OPCION_CPR_RPT.Nombre = string.Empty;
            OPCION_CPR_RPT.Titulo = "Informes";
            OPCION_CPR_RPT.NombreImagen = "carpeta_abierta";

            OPCION_CPR_RPT.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Consultar Compras/Anulaciónes",
                    NombreImagen = "informes"
                }
            );


            OPCION_CPR_RPT.AddSubOpcion
           (
               new OpcionMenu()
               {
                   Nombre = string.Empty,
                   Titulo = "Consultar Catálogo de Articulos",
                   NombreImagen = "informes"
               }
           );

            MENU_CPR.AddOpcion(OPCION_CPR_RPT);

            #endregion

            #region CFG

            OpcionMenu OPCION_CPR_CFG = new OpcionMenu();

            OPCION_CPR_CFG.Nombre = string.Empty;
            OPCION_CPR_CFG.Titulo = "Configuración";
            OPCION_CPR_CFG.NombreImagen = "carpeta_abierta";

            OPCION_CPR_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = string.Empty,
                    Titulo = "Administrar Lista de Precios",
                    NombreImagen = "configuracion"
                }
            );

            OPCION_CPR_CFG.AddSubOpcion
            (
                new OpcionMenu()
                {
                    Nombre = "Compras.AdministrarProveedoresPresentador",
                    Titulo = "Administrar Proveedores",
                    NombreImagen = "configuracion"
                }
            );

            MENU_CPR.AddOpcion(OPCION_CPR_CFG);

            #endregion

            MODULO_COMPRAS.Nombre = "Compras";
            MODULO_COMPRAS.Titulo = "Compras";
            MODULO_COMPRAS.NombreImagen = "compras24";
            MODULO_COMPRAS.Menu = MENU_CPR;

            return MODULO_COMPRAS;
        }
    }
}
