namespace SynergyGestion.Infrastructura.Persistencia.ADO
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using Dominio.Modelo.Inventario;

    #endregion
    
    public class ImportacionDatosCatalago
    {
        private const string _connectionString = "Data Source=GUSTAVO-NBX\\SQLEXPRESS;Initial Catalog=DbApreAlmacen;Integrated Security=True;";

        public IList<Articulo> GetArticulosByFamilia(int idFamiliaArticulo)
        {
            List<Articulo> articulos = new List<Articulo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = string.Format("SELECT Nombre, Descripcion, Simbolo as Codigo, Valor FROM Inventario.Articulo WHERE IdFamiliaArticulo = {0} AND Nombre IS NOT NULL AND Descripcion IS NOT NULL AND Valor IS NOT NULL AND LEN(Descripcion) < 256", idFamiliaArticulo);

                connection.Open();
                command.Connection = connection;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        articulos.Add
                        (
                            new Articulo(reader["Codigo"] != null ? reader["Codigo"].ToString() : string.Empty, reader["Descripcion"].ToString(), Convert.ToDecimal(reader["Valor"]), CriterioCosteo.PPP)
                        );
                    }
                }
            }

            return articulos;
        }

        //public IList<FamiliaArticulo> GetAllFamilias()
        //{
        //    List<FamiliaArticulo> familias = new List<FamiliaArticulo>();
        //    IList<Articulo> articulos = new List<Articulo>();

        //    FamiliaArticulo famila;

        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    using (SqlCommand command = new SqlCommand())
        //    {
        //        command.CommandText = "SELECT idFamiliaArticulo, Nombre, Descripcion FROM Inventario.FamiliaArticulo";

        //        connection.Open();
        //        command.Connection = connection;

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                articulos = GetArticulosByFamilia(Convert.ToInt32(reader["idFamiliaArticulo"]) );

        //                famila = new FamiliaArticulo(reader["Nombre"].ToString(), reader["Descripcion"].ToString());
                        
        //                famila.AgregarArticulos(articulos);

        //                familias.Add(famila);
        //            }
        //        }
        //    }

        //    return familias;
        //}

        //public IList<FamiliaArticulo> GetFamiliasByGrupo(int idGrupo)
        //{
        //    FamiliaArticulo familia;
            
        //    List<FamiliaArticulo> familias = new List<FamiliaArticulo>();
        //    IList<Articulo> articulos = new List<Articulo>();

        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    using (SqlCommand command = new SqlCommand())
        //    {
        //        command.CommandText = string.Format("SELECT Nombre, Descripcion, idFamiliaArticulo FROM Inventario.FamiliaArticulo WHERE IdGrupoArticulo = {0} AND  Descripcion IS NOT NULL AND LEN(Descripcion) < 256", idGrupo);

        //        connection.Open();
        //        command.Connection = connection;

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                articulos = GetArticulosByFamilia(Convert.ToInt32(reader["idFamiliaArticulo"]));

        //                familia = new FamiliaArticulo(reader["Nombre"].ToString(), reader["Descripcion"].ToString());
                       
        //                familia.AgregarArticulos(articulos);

        //                familias.Add(familia);
        //            }
        //        }
        //    }

        //    return familias;
        //}

        public IList<GrupoArticulo> GetAllGrupos()
        {
            List<GrupoArticulo> grupos = new List<GrupoArticulo>();
            //IList<FamiliaArticulo> familias = new List<FamiliaArticulo>();

            //GrupoArticulo grupo;

            //using (SqlConnection connection = new SqlConnection(_connectionString))
            //using (SqlCommand command = new SqlCommand())
            //{
            //    command.CommandText = "SELECT idGrupoArticulo, Nombre, Descripcion FROM Inventario.GrupoArticulo";

            //    connection.Open();
            //    command.Connection = connection;

            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            familias = GetFamiliasByGrupo(Convert.ToInt32(reader["idGrupoArticulo"]));

            //            grupo = new GrupoArticulo(reader["Nombre"].ToString(), reader["Descripcion"].ToString());
                        
            //            //grupo.AgregarFamilias(familias);

            //            grupos.Add(grupo);
            //        }
            //    }
            //}

            return grupos;
        }
    }
}
