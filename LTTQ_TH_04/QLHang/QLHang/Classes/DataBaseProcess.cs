using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHang.Classes
{
	public class DataBaseProcess
	{
		string strConnect = "Data Source=DESKTOP-04URNFP;Initial Catalog=BanHang;Integrated Security=True;Encrypt=False";
		SqlConnection sqlConnect = null;

		private void OpenConnection()
		{
			sqlConnect = new SqlConnection(strConnect);

			if (sqlConnect.State != ConnectionState.Open)
				sqlConnect.Open();
			
		}
		
		private void CloseConnection()
		{
			if (sqlConnect.State != ConnectionState.Closed)
				sqlConnect.Close();
		}

		public DataTable DataReader(string sqlSelect)
		{
			DataTable dt = new DataTable();

			OpenConnection();
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, strConnect);
			sqlData.Fill(dt);
			CloseConnection();

			return dt;
		}

		public void DataChange(string sql)
		{
			OpenConnection();
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnect;
			sqlCommand.CommandText = sql;
			sqlCommand.ExecuteNonQuery();
			CloseConnection();
		}

	}
}
