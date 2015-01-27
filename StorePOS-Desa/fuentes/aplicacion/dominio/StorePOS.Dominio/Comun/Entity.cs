namespace StorePOS.Dominio.Comun
{
	public class Entity : AbstractEntity<int>
	{
        protected int id;
        
        public override int Id 
        {
            get
            {
                return this.id;
            }
            protected set
            {
                this.id = value;
            }
        }
	}
}