using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CSharpModBusExample
{
    class SQLHelper
    {
        private static string connstr = ConfigurationManager.ConnectionStrings["HS"].ConnectionString;

        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }
            }
        } //执行一条SQL语句，返回影响的行数

        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
            }
        }  //返回第一行第一列的值

        public static DataSet ExecuteDataSet(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        } //返回一个DataSet集合

        public static DataTable ExecuteDataTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        } //返回一个DataSet集合中的第一个Table


        public static DataRow ExecuteDataRow(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0].Rows[0];
                }
            }
        } //返回一个DataSet集合中的第一个Table
        //public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        //{
        //    using (SqlConnection conn = new SqlConnection(connstr))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = sql;
        //            //foreach (SqlParameter param in parameters)
        //            //{
        //            //    cmd.Parameters.Add(param);
        //            //}
        //            cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历
        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //} //执行带参数的SQL语句

        //public static object ExecuteScalar(string sql, SqlParameter[] parameters)
        //{
        //    using (SqlConnection conn = new SqlConnection(connstr))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = sql;
        //            cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历
        //            return cmd.ExecuteScalar();
        //        }
        //    }
        //} //执行带参数的SQL语句，返回第一行第一列的值

        //public static DataSet ExecuteDataSet(string sql, SqlParameter[] parameters)
        //{
        //    using (SqlConnection conn = new SqlConnection(connstr))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = sql;
        //            cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataSet dataSet = new DataSet();
        //            adapter.Fill(dataSet);
        //            return dataSet;
        //        }
        //    }
        //} //执行带参数的SQL语

        //public static DataTable ExecuteDataTable(string sql, SqlParameter[] parameters)
        //{
        //    using (SqlConnection conn = new SqlConnection(connstr))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = sql;
        //            cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataSet dataSet = new DataSet();
        //            adapter.Fill(dataSet);
        //            return dataSet.Tables[0];
        //        }
        //    }
        //} //执行带参数的SQL语,返回DataSet的第一个Table

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters) //用params声明数组，意思是不知道数组长度用的
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历                    
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters) //用params声明数组，意思是不知道数组长度用的
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历                    
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataSet ExecuteDataSet(string sql, params SqlParameter[] parameters) //用params声明数组，意思是不知道数组长度用的
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历    
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters) //用params声明数组，意思是不知道数组长度用的
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历    
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }

        public static int SelectRows(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataRow ExecuteDataRow(string sql, params SqlParameter[] parameters) //用params声明数组，意思是不知道数组长度用的
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters); //用AddRange直接代替foreach遍历    
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0].Rows[0];
                }
            }
        }
    }
}
