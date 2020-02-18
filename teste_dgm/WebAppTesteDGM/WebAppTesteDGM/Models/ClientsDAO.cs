using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebAppTesteDGM.Models
{
    public class ClientsDAO
    {
        private SqlConnection conn;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["TESTEDGM"].ToString();
            conn = new SqlConnection(constr);
        }

        public bool AddClient(ClienteModel cliModel)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("AddClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOM_USUAL", cliModel.NOM_USUAL);
            cmd.Parameters.AddWithValue("@NOM_COMPLETO", cliModel.NOM_COMPLETO);
            cmd.Parameters.AddWithValue("@NRO_CPF", cliModel.NRO_CPF);
            cmd.Parameters.AddWithValue("@COD_TIPO_CLIENTE", cliModel.COD_TIPO_CLIENTE);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<ClienteModel> GetAllClientes()
        {
            Connection();
            List<ClienteModel> cliList = new List<ClienteModel>();

            SqlCommand cmd = new SqlCommand("GetAllClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            sd.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                cliList.Add(
                    new ClienteModel
                    {
                        COD_CLIENTE = Convert.ToInt32(dr["COD_CLIENTE"]),
                        NOM_USUAL = Convert.ToString(dr["NOM_USUAL"]),
                        NOM_COMPLETO = Convert.ToString(dr["NOM_COMPLETO"]),
                        NRO_CPF = Convert.ToString(dr["NRO_CPF"]),
                        COD_TIPO_CLIENTE = Convert.ToInt32(dr["COD_TIPO_CLIENTE"]),
                        DSC_TIPO_CLIENTE = Convert.ToString(dr["DSC_TIPO_CLIENTE"])
                    });
            }
            return cliList;
        }

        // Get cliente by id
        public ClienteModel GetClienteById(int cliId )
        {
            Connection();
            ClienteModel cliEdit = new ClienteModel();

            SqlCommand cmd = new SqlCommand("GetClientByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_CLIENTE", cliId);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            sd.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                cliEdit = 
                    new ClienteModel
                    {
                        COD_CLIENTE = Convert.ToInt32(dr["COD_CLIENTE"]),
                        NOM_USUAL = Convert.ToString(dr["NOM_USUAL"]),
                        NOM_COMPLETO = Convert.ToString(dr["NOM_COMPLETO"]),
                        NRO_CPF = Convert.ToString(dr["NRO_CPF"]),
                        COD_TIPO_CLIENTE = Convert.ToInt32(dr["COD_TIPO_CLIENTE"]),
                        DSC_TIPO_CLIENTE = Convert.ToString(dr["DSC_TIPO_CLIENTE"])
                    };
            }
            return cliEdit;
        }

        public bool UpdateCliente(ClienteModel cliModel)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("UpdateClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_CLIENTE", cliModel.COD_CLIENTE);
            cmd.Parameters.AddWithValue("@NOM_USUAL", cliModel.NOM_USUAL);
            cmd.Parameters.AddWithValue("@NOM_COMPLETO", cliModel.NOM_COMPLETO);
            cmd.Parameters.AddWithValue("@NRO_CPF", cliModel.NRO_CPF);
            cmd.Parameters.AddWithValue("@COD_TIPO_CLIENTE", cliModel.COD_TIPO_CLIENTE);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool DeleteCliente(int id)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("DeleteClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_CLIENTE", id);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}