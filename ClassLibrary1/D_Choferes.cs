using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;
using System.Configuration;

namespace Capa_Datos
{
    public class D_Choferes
    {
        private SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public void Guardar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Choferes", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@nombre", E_Choferes.Nombre1);
            cmd.Parameters.AddWithValue("@apellido", E_Choferes.Apellido1);
            cmd.Parameters.AddWithValue("@cedula", E_Choferes.Cedula1);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", E_Choferes.FechaNacimiento1);

            cmd.ExecuteNonQuery();

            cnx.Close();
        }
        public void Editar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Choferes", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@ID", E_Choferes.ID1);
            cmd.Parameters.AddWithValue("@nombre", E_Choferes.Nombre1);
            cmd.Parameters.AddWithValue("@apellido", E_Choferes.Apellido1);
            cmd.Parameters.AddWithValue("@cedula", E_Choferes.Cedula1);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", E_Choferes.FechaNacimiento1);

            cmd.ExecuteNonQuery();

            cnx.Close();
        }
        public void Borrar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Choferes", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cnx.Open();

            cmd.Parameters.AddWithValue("@id", E_Choferes.ID1);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable Buscar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Buscar_Choferes", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@id", E_Choferes.ID1);
            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cnx.Close();
            return tabla;

        }
        public DataTable Mostrar_D()
        {
            cnx.Open();
            SqlCommand Command = new SqlCommand("select * from VW_choferes", cnx);


            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cnx.Close();
            return dataTable;
        }
    }
}
