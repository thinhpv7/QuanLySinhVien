using System;
using System.Data;
using System.Data.SqlClient;


namespace DataProvider
{
    
    public class DBLayer
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter adp;

        string strConnect =
            "Data Source=FRT;Initial Catalog=QuanLySinhVienHeQuanTri;Integrated Security=True";
        public DBLayer()
        {
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }
        // Select query
        public DataSet ExecuteQueryDataSet(
            string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = ct;
            cmd.CommandText = strSQL;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public string ExecuteQueryXML(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandType = ct;
            cmd.CommandText = strSQL;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }

        // action query
        //Insert||Delete||Update||Store Pro
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error,
            params SqlParameter[] param)
        {
            bool f = false;

            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = ct;
            cmd.CommandText = strSQL;

            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
        //
        public DataSet ExecuteQueryDataSet1(
           string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = ct;
            cmd.CommandText = strSQL;
            DataSet ds;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            cmd.ExecuteNonQuery();
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            cnn.Close();
            return ds;
        }
    }
}
