namespace SynergyGestion.Dominio.Comun
{
    using System;
    
    public interface IGenericEntity<TIdentity> : IEquatable<IGenericEntity<TIdentity>>
	{
		TIdentity Id { get; }
	}
}