using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidade;

namespace CapaDeDados
{
    public class ClasseDados
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        #region Login
        public DataTable D_Login(ClassEntidade obje)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_logar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", obje.user);
                cmd.Parameters.AddWithValue("@senha", obje.passe);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }
        #endregion

        public DataTable D_Buscar(ClassEntidade obje)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_buscar_listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", obje.user);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        public DataTable D_Listar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_listar_usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        public String D_Procurar(ClassEntidade obje)
        {
            String accão = "";
            SqlCommand cmd = new SqlCommand("procedimento_usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_codigo", obje.id_codigo);
            cmd.Parameters.AddWithValue("@nome", obje.nome);
            cmd.Parameters.AddWithValue("@nome_usuario", obje.user);
            cmd.Parameters.AddWithValue("@tipo_id", obje.tipo);
            cmd.Parameters.Add("@acção", SqlDbType.VarChar, 50).Value = obje.accão;
            cmd.Parameters["acção"].Direction = ParameterDirection.InputOutput;

            if(cn.State == ConnectionState.Open)cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accão = cmd.Parameters["@acção"].Value.ToString();
            return accão;
        }

    }
}
