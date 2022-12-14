using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_AUTOBUS
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

        public List<CE_AUTOBUS> Listado_Chofer(string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CHOFER", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<CE_AUTOBUS> Listado = new List<CE_AUTOBUS>();
            while (leer.Read())
            {
                Listado.Add(new CE_AUTOBUS
                {
                    ID_CHOFER = leer.GetInt32(0),
                    NOMBRE = leer.GetString(1),
                    APELLIDO = leer.GetString(2),
                    FECHA = leer.GetDateTime(3),
                    CEDULA = leer.GetString(4),
                    DISPON = leer.GetString(5)
                });
            }

            connect.Close();
            leer.Close();
            return Listado;
        }

        public void InsertadoChofer(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CHOFER", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", ce_Autobus.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", ce_Autobus.APELLIDO);
            cmd.Parameters.AddWithValue("@FECHA", ce_Autobus.FECHA);
            cmd.Parameters.AddWithValue("@CEDULA", ce_Autobus.CEDULA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void EditadoChofer(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_CHOFER", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", ce_Autobus.ID_CHOFER);
            cmd.Parameters.AddWithValue("@NOMBRE", ce_Autobus.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", ce_Autobus.APELLIDO);
            cmd.Parameters.AddWithValue("@FECHA", ce_Autobus.FECHA);
            cmd.Parameters.AddWithValue("@CEDULA", ce_Autobus.CEDULA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void EliminadoChofer(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CHOFER", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", ce_Autobus.ID_CHOFER);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public DataTable cbxChofer()
        {
            SqlDataAdapter leer = new SqlDataAdapter("SP_CARGAR_CHOFER", connect);
            DataTable table = new DataTable();
            leer.Fill(table);
            return table;
        }

        public void DisponChofer(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPON_CHOFER", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", ce_Autobus.CHOFER);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void DisponChoferV(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPONIBLE_CHOFER_V", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", ce_Autobus.CHOFER);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<CE_AUTOBUS> Listado_Autobus(string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_AUTOBUS", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<CE_AUTOBUS> Listado = new List<CE_AUTOBUS>();
            while (leer.Read())
            {
                Listado.Add(new CE_AUTOBUS
                {
                    ID_AUTOBUS = leer.GetInt32(0),
                    MARCA = leer.GetString(1),
                    MODELO = leer.GetString(2),
                    PLACA = leer.GetString(3),
                    COLOR = leer.GetString(4),
                    ANIO = leer.GetString(5)
                });
            }

            connect.Close();
            leer.Close();
            return Listado;
        }

        public void InsertadoAutobus(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_AUTOBUS", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@MARCA", ce_Autobus.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", ce_Autobus.MODELO);
            cmd.Parameters.AddWithValue("@PLACA", ce_Autobus.PLACA);
            cmd.Parameters.AddWithValue("@COLOR", ce_Autobus.COLOR);
            cmd.Parameters.AddWithValue("@ANIO", ce_Autobus.ANIO);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void EditadoAutobus(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_AUTOBUS", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", ce_Autobus.ID_AUTOBUS);
            cmd.Parameters.AddWithValue("@MARCA", ce_Autobus.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", ce_Autobus.MODELO);
            cmd.Parameters.AddWithValue("@PLACA", ce_Autobus.PLACA);
            cmd.Parameters.AddWithValue("@COLOR", ce_Autobus.COLOR);
            cmd.Parameters.AddWithValue("@ANIO", ce_Autobus.ANIO);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void EliminadoAutobus(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_AUTOBUS", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", ce_Autobus.ID_AUTOBUS);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public DataTable cbxAutobus()
        {
            SqlDataAdapter leer = new SqlDataAdapter("SP_CARGAR_AUTOBUS", connect);
            DataTable table = new DataTable();
            leer.Fill(table);
            return table;
        }

        public void DisponAutobus(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPON_AUTOBUS", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@PLACA", ce_Autobus.AUTOBUS);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void DisponAutobusV(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPONIBLE_AUTOBUS_V", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@PLACA", ce_Autobus.AUTOBUS);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<CE_AUTOBUS> Listado_Rutas(string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_RUTA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<CE_AUTOBUS> Listado = new List<CE_AUTOBUS>();
            while (leer.Read())
            {
                Listado.Add(new CE_AUTOBUS
                {
                    ID_RUTA = leer.GetInt32(0),
                    NOMBRE_RUTA = leer.GetString(1)
                });
            }

            connect.Close();
            leer.Close();
            return Listado;
        }
        public void InsertadoRuta(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_RUTA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", ce_Autobus.NOMBRE_RUTA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void EditadoRuta(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_RUTA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", ce_Autobus.ID_RUTA);
            cmd.Parameters.AddWithValue("@NOMBRE", ce_Autobus.NOMBRE_RUTA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void EliminadoRuta(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_RUTA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", ce_Autobus.ID_RUTA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public DataTable cbxRuta()
        {
            SqlDataAdapter leer = new SqlDataAdapter("SP_CARGAR_RUTA", connect);
            DataTable table = new DataTable();
            leer.Fill(table);
            return table;
        }

        public void DisponRuta(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPON_RUTA", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@RUTA", ce_Autobus.RUTA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void DisponRutaV(CE_AUTOBUS e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPONIBLE_RUTA_V", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.RUTA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<CE_AUTOBUS> ListarViajes(string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VIAJE", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<CE_AUTOBUS> Listado = new List<CE_AUTOBUS>();
            while (leer.Read())
            {
                Listado.Add(new CE_AUTOBUS
                {
                    ID_VIAJE = leer.GetInt32(0),
                    CHOFER = leer.GetString(1),
                    AUTOBUS = leer.GetString(2),
                    RUTA = leer.GetString(3)
                });
            }

            connect.Close();
            leer.Close();
            return Listado;
        }
        public void InsertadoViaje(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_VIAJE", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@CHOFER", ce_Autobus.CHOFER);
            cmd.Parameters.AddWithValue("@AUTOBUS", ce_Autobus.AUTOBUS);
            cmd.Parameters.AddWithValue("@RUTA", ce_Autobus.RUTA);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void EliminadoViaje(CE_AUTOBUS ce_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_FIN_VIAJE", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            cmd.Parameters.AddWithValue("@ID_VIAJE", ce_Autobus.ID_VIAJE);

            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
