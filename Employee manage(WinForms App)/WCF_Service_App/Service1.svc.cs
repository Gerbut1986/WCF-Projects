namespace WCF_Service_App
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    // URL Current Service: http://localhost:49875/Service1.svc

    public class Service1 : IService1
    {
        public readonly string connectionString;

        public Service1()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }
        // Add one New:
        public string InsertEmployer(Employers e)
        {
            string MSG = string.Empty;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employers(FIO, Addresss, Phone, Email, Datebirth, Salary) " +
                "VALUES(@FIO, @Addresss, @Phone, @Email, @Datebirth, @Salary)", conn);
            cmd.Parameters.AddWithValue("@FIO", e.FIO);
            cmd.Parameters.AddWithValue("@Addresss", e.Address);
            cmd.Parameters.AddWithValue("@Phone", e.Phone);
            cmd.Parameters.AddWithValue("@Email", e.Email);
            cmd.Parameters.AddWithValue("@Datebirth", e.Datebirthday);
            cmd.Parameters.AddWithValue("@Salary", e.Salary);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                MSG = e.FIO + " Inserted Successfully!";
            else
                MSG = e.FIO + " NOT Inserted! Try to Find this Error";
            conn.Close();

            return MSG;
        }

        // Search by Id:
        public string[] FindEmployerById(int id)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            List<string> tmp = new List<string>(6);
            var query = context.Employers.Where(i => i.Id == id);
            foreach (var e in query)
            {
                tmp.Add((e.Id).ToString());
                tmp.Add(e.FIO);
                tmp.Add(e.Addresss);
                tmp.Add((e.Phone).ToString());
                tmp.Add(e.Email);
                tmp.Add(e.Salary);
            }

            return tmp.ToArray();
        }

        // Select All:
        public DataSet ShowAllEntities()
        {
            SqlConnection conn = null; DataSet dataSet = null;
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employers", conn);
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
            finally { conn.Close(); }

            return dataSet;
        }
    }
}
