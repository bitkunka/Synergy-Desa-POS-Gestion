namespace SynergyGestion.Dominio.Comun
{
    using System;

    /// <summary>
    /// Objeto Valor
    /// </summary>  
    public interface IObjetoValor<T>
    {
        /// <summary>
        /// Las objeto valor son comparadas por sus atributos, no tienen identidad.
        /// </summary>
        /// <param name="other">The other entity.</param>
        /// <returns>true si los atributos son inguales.</returns>
        bool MismaValorQue(T otraEntidad);
    }
}