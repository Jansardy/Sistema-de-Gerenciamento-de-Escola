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
        public DataTable DLogin(ClassEntidade obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_logar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", obj.user);
                cmd.Parameters.AddWithValue("@senha", obj.passe);

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
    }
}
