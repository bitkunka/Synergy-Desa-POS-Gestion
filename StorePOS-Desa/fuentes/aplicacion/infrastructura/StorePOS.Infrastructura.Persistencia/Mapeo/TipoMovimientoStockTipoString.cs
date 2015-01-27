namespace StorePOS.Infrastructura.Persistencia.Mapeo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text; 
    using Dominio.Modelo.Inventario;
    
    public class TipoMovimientoStockTipoString : NHibernate.Type.EnumStringType
    {
        public TipoMovimientoStockTipoString(): base(typeof(TipoMovimientoStock), 20)
        {
        
        }

        public override object GetValue(object enm)
        {
            if (null == enm)
                return String.Empty;

            switch ((TipoMovimientoStock)enm)
            {
                case TipoMovimientoStock.IngresoStock: return "IngresoStock";
                case TipoMovimientoStock.SalidaStock: return "SalidaStock";
                case TipoMovimientoStock.TraspasoStock: return "TraspasoStock";
              
                default: throw new ArgumentException("Criterio de Costeo No válido.");
            }
        }

        public override object GetInstance(object code)
        {
            code = code.ToString().ToUpper();

            if ("IngresoStock".Equals(code))
                return TipoMovimientoStock.IngresoStock;
            else if ("SalidaStock".Equals(code))
                return TipoMovimientoStock.SalidaStock;
            else if ("TraspasoStock".Equals(code))
                return TipoMovimientoStock.TraspasoStock;

            throw new ArgumentException(
                "No se puede convertir el tipo movimiento'" + code + "' a tipo movimiento de stock.");
        }
    }
}
