using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient.SqlConnection;
using System.Data.SqlClient;


namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }//ben ngoai kg dc phep set du lieu
        }

        private DataProvider(){}

        private string connSring = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBenXe;User ID=sa;Password=sa2014";

        public DataTable ExcuteQuery(string query, object[] paramater = null) //paramater la chuoi dong de thuc thi
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connSring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string query, object[] paramater = null) //paramater la chuoi dong de thuc thi
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connSring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }


        public object ExcuteScalar(string query, object[] paramater = null) //paramater la chuoi dong de thuc thi
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connSring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
    
}
