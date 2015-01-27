namespace SynergyGestion.Infrastructura.Persistencia.Mapeo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text; 
    using Dominio.Modelo.Inventario;
    
    public class CriterioCosteoTipoString : NHibernate.Type.EnumStringType
    {
        public CriterioCosteoTipoString(): base(typeof(CriterioCosteo), 4)
        {
        
        }

        public override object GetValue(object enm)
        {
            if (null == enm)
                return String.Empty;

            switch ((CriterioCosteo)enm)
            {
                case CriterioCosteo.PEPS: return "PEPS";
                case CriterioCosteo.UEPS: return "UEPS";
                case CriterioCosteo.PPP: return "PPP";
                case CriterioCosteo.CREP: return "CREP";
                default: throw new ArgumentException("Criterio de Costeo No válido.");
            }
        }

        public override object GetInstance(object code)
        {
            code = code.ToString().ToUpper();

            if ("PEPS".Equals(code))
                return CriterioCosteo.PEPS;
            else if ("UEPS".Equals(code))
                return CriterioCosteo.UEPS;
            else if ("PPP".Equals(code))
                return CriterioCosteo.PPP;
            else if ("CREP".Equals(code))
                return CriterioCosteo.CREP;

            throw new ArgumentException(
                "No se puede convertir el código '" + code + "' a Critério Costeo.");
        }
    }
}
