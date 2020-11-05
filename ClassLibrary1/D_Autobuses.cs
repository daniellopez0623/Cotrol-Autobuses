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
    public class D_Autobuses
    {

        private SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public void Guardar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Autobus", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@id_Chofer", E_Autobuses.ID_Chofer1);
            cmd.Parameters.AddWithValue("@marca", E_Autobuses.Marca1);
            cmd.Parameters.AddWithValue("@modelo", E_Autobuses.Modelo1);
            cmd.Parameters.AddWithValue("@placa", E_Autobuses.Placa1);
            cmd.Parameters.AddWithValue("@color", E_Autobuses.Color1);
            cmd.Parameters.AddWithValue("@año", E_Autobuses.Año1);

            cmd.ExecuteNonQuery();

            cnx.Close();
        }
        public void Editar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Autobus", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@ID", E_Autobuses.ID1);
            cmd.Parameters.AddWithValue("@id_Chofer", E_Autobuses.ID_Chofer1);
            cmd.Parameters.AddWithValue("@marca", E_Autobuses.Marca1);
            cmd.Parameters.AddWithValue("@modelo", E_Autobuses.Modelo1);
            cmd.Parameters.AddWithValue("@placa", E_Autobuses.Placa1);
            cmd.Parameters.AddWithValue("@color", E_Autobuses.Color1);
            cmd.Parameters.AddWithValue("@año", E_Autobuses.Año1);

            cmd.ExecuteNonQuery();

            cnx.Close();
        }
        public void Borrar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Autobus", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cnx.Open();

            cmd.Parameters.AddWithValue("@id", E_Autobuses.ID1);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable Buscar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Buscar_Autobus", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@id", E_Autobuses.ID1);
            cmd.Parameters.AddWithValue("@id_Chofer", E_Autobuses.ID_Chofer1);

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
            SqlCommand cmd = new SqlCommand("select * from VW_Autobuses", cnx);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cnx.Close();
            return dataTable;
        }
    }
}
