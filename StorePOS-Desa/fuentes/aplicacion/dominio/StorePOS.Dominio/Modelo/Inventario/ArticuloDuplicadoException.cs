namespace StorePOS.Dominio.Modelo.Inventario
{
    using System;
    using Dominio.Comun;

    public class ArticuloDuplicadoException : DominioException
    {
        private string codigo;


        public ArticuloDuplicadoException(string codigo)
        {
            this.codigo = codigo;
        }
        
        public override string Message
        {
            get
            {
                return string.Format("Ya existe otro artículo con código {0} en la base de datos.", this.codigo);
            }
        }
    }
}
