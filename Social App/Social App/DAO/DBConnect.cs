using System;
using System.Data.SqlClient;
using System.Data;
namespace Social_App.DAO
{
    public class DBConnect
    {
        protected string conn = @"Data Source=LAPTOP-73T7CMIB;Initial Catalog=socialapp;Integrated Security=True";
        public SqlConnection con;
        protected SqlDataAdapter dt;
        protected SqlCommand cm;


        private static DBConnect instance;

        public static DBConnect Instance
        {
            get
            {
                if (instance == null) instance = new DBConnect();
                return instance;
            }
        }
        private DBConnect() { }
        public void openConnection()
        {
            con = new SqlConnection(conn);
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
        protected void ExecuteNonQuery(string sql)
        {
            using (cm = new SqlCommand(sql))
            {
                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
            }
        }
        

        public DataTable ExecuteQuery_DataTable(string sql)
        {
            DataTable dataum = null;
            try
            {
                SqlDataAdapter dr = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                dataum = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            return dataum;
        }
        public void ExecuteUpdateQuery(string sql) //Them, xoa, sua
        {
            openConnection();
            ExecuteNonQuery(sql);
            closeConnection();
        }

    }
}
