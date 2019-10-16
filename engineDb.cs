using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace VirtualGym.Database
{
    class engineDb
    {
        public DataSet RetornaDataSet(string strQuery)
        {
            DataSet ds = new DataSet();
            SqlConnection Conn = new SqlConnection();
            try
            {
                
                Conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=VIRTUALGYM;User ID=sa;Password=@Lcm2020"; //BASE OFICIAL                
                Conn.Open();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandTimeout = 0;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                SqlDataAdapter daAdaptador = new SqlDataAdapter();
                daAdaptador.SelectCommand = cmdComando;
                daAdaptador.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return ds;
        }
    }
}