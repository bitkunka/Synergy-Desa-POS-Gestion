namespace StorePOS.Dominio.Comun
{
    using System;

    /// <summary>
    /// Entidad
    /// </summary>  
    public interface IEntity<T>
    {
        /// <summary>
        /// Las entidads son comparadas por su identificador, no por sus atributos.
        /// </summary>
        /// <param name="other">The other entity.</param>
        /// <returns>true si los identificadores son inguales, obviando los demás atributos.</returns>
        bool MismaIdentidadQue(T otraEntidad);
    }
}