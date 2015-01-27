namespace StorePOS.Test.Dominio.Modelo.Inventario
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using StorePOS.Dominio.Modelo.Inventario;

    #endregion

    [TestFixture]
    public class MovimientoStockTest
    {
        private Stock stock1;
        private Stock stock2;
        
        [SetUp]
        protected void SetUp()
        {
            DatosEjemplo.Inicializar();
            
            this.stock1 = StorePOS.Dominio.Modelo.Inventario.DatosEjemplo.STOCK1_ART1;
            this.stock2 = StorePOS.Dominio.Modelo.Inventario.DatosEjemplo.STOCK2_ART1;
        }

        [Test]
        public void Test_MovimientoStock_Ingreso()
        {
            MovimientoStock movIngreso = new MovimientoStock
            (
                 TipoMovimientoStock.IngresoStock
                , stock1
                , 10
                , "Remito1"
                ,DateTime.Now
                , 1
            );

            Assert.AreEqual(110, stock1.Cantidad);
            Assert.AreEqual(130, stock1.Articulo.CantidadStock);
        }

        [Test]
        public void Test_MovimientoStock_Salidad()
        {
            MovimientoStock movIngreso = new MovimientoStock
            (
                 TipoMovimientoStock.SalidaStock
                , stock2
                , 20
                , "Factura1"
                ,DateTime.Now
                , 1
            );

            Assert.AreEqual(0, stock2.Cantidad);
            Assert.AreEqual(100, stock1.Articulo.CantidadStock);
        }
    }
}
