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
    public class D_Rutas
    {
        private SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public void Guardar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Guardar_Rutas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@id_Chofer", E_Rutas.ID_Chofer1);
            cmd.Parameters.AddWithValue("@id_Autobus", E_Rutas.ID_Autobus1);
            cmd.Parameters.AddWithValue("@ruta", E_Rutas.Rutas1);

            cmd.ExecuteNonQuery();

            cnx.Close();
        }
        public void Editar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Rutas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@id", E_Rutas.ID1);
            cmd.Parameters.AddWithValue("@id_Chofer", E_Rutas.ID_Chofer1);
            cmd.Parameters.AddWithValue("@id_Autobus", E_Rutas.ID_Autobus1);
            cmd.Parameters.AddWithValue("@ruta", E_Rutas.Rutas1);

            cmd.ExecuteNonQuery();

            cnx.Close();
        }
        public void Borrar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Borrar_Rutas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cnx.Open();

            cmd.Parameters.AddWithValue("@id", E_Rutas.ID1);
            cmd.Parameters.AddWithValue("@id_Chofer", E_Rutas.ID_Chofer1);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable Buscar_D()
        {
            SqlCommand cmd = new SqlCommand("SP_Buscar_Rutas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();
            cmd.Parameters.AddWithValue("@id", E_Rutas.ID1);
            cmd.Parameters.AddWithValue("@id_Chofer", E_Rutas.ID_Chofer1);
            cmd.Parameters.AddWithValue("@id_Autobus", E_Rutas.ID_Autobus1); cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cnx.Close();
            return tabla;

        }
        public DataTable Mostrar_D()
        {
            cnx.Open();
            SqlCommand Command = new SqlCommand("select * from VW_Rutas", cnx);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cnx.Close();
            return dataTable;
        }
    }
}
