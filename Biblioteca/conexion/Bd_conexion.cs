using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.conexion
{
    public class BD_conexion
    {
        private static BD_conexion bd;
        //private SqlConnection cnn;
        private SqlConnection cnn;
        private SqlCommand cmd;


        private BD_conexion()

        {
            string connectionString = string.Format("Data Source=GENOMA;Initial Catalog=ropa;Integrated Security=True");
            cnn = new SqlConnection(connectionString);
        }

        public static BD_conexion getInstance()
        {
            if (bd == null)
            {
                bd = new BD_conexion();
            }
            return bd;
        }

        public int sqlExecute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int var = cmd.ExecuteNonQuery();
            cnn.Close();
            return var;
        }
        public DataTable mySQLSelect(string mysql)
        {
            SqlCommand cmd = new SqlCommand(mysql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public int SqlExecuteProcedure(string sqlCmd, ArrayList valores)
        {
            SqlCommand cmd = new SqlCommand(sqlCmd, cnn);
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@param", Convert.ToInt32(Textbox1.Text));
            /*cmd.Parameters.AddWithValue("@rut", 1);
            cmd.Parameters.AddWithValue("@nombre", "Harrys");*/
            for (int i = 0; i < valores.Count; i++)
            {
                Parametros xx = (Parametros)valores[i];
                cmd.Parameters.AddWithValue("@" + xx.valor, xx.clave);
            }
            int result = cmd.ExecuteNonQuery();

            cnn.Close();
            return result;
        }

        public void sqlPkgDec(String stSql)
        {
            cmd = new SqlCommand(stSql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.InitialLONGFetchSize = 1000;
        }

        public ConeccionReturn sqlPkgExe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            String code = cmd.Parameters["@resultado"].Value.ToString();
            ConeccionReturn rt = new ConeccionReturn(dt, code);
            return rt;
        }

        public void sqlPkgParIn(String name, String valor)
        {
            cmd.Parameters.Add("@" + name, valor);
        }
        public void ParnOutString(String name, int largo)
        {

            SqlParameter param = new SqlParameter();
            param.ParameterName = name;
            param.SqlDbType = SqlDbType.VarChar;
            param.Size = largo;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
        }
        //public string SqlExecute(string sqlCmd, ArrayList valores)
        //{
        //    SqlCommand cmd = new SqlCommand(sqlCmd, cnn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    for (int i = 0; i < valores.Count; i++)
        //    {
        //        Parametros xx = (Parametros)valores[i];
        //        cmd.Parameters.Add("@" + xx.valor, xx.clave);
        //    }
        //    cnn.Open();
        //    SqlDataReader rd = cmd.ExecuteReader();

        //    if (rd.HasRows)
        //    {

        //        string variable = rd.Read().ToString();
        //        return variable;
        //    }
        //    cnn.Close();
        //    return "error";
        //}

    }

    public class Parametros
    {
        public string valor; public string clave;
        public Parametros(string valor, string clave)
        {
            this.valor = valor;
            this.clave = clave;
        }
    }

    public class ConeccionReturn
    {
        public DataTable dt { get; set; }
        public String code { get; set; }
        //public String descripcion { get; set; }
        public ConeccionReturn(DataTable dt, String code)
        {
            this.dt = dt;
            this.code = code;
            //this.descripcion = descripcion;
        }
    }
}
