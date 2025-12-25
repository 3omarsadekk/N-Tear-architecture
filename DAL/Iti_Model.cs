using Intarfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DAL
{
    public class Iti_Model : Iiti_Model
    {
        public SqlConnection? Connection { get; set; }
        public SqlCommand command { get; set; }

        public string ConnectionString { get; set; }

        public Iti_Model()
        {
            var Conf = new ConfigurationBuilder().AddJsonFile("AppSettengs.json").Build();
            this.ConnectionString = Conf.GetConnectionString("default");
            this.Connection = new SqlConnection(this.ConnectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.Connection;
        }

        public DataTable ExecuteDisConnectedQuery(string commend)
        {
            this.command.CommandText = commend;
            SqlDataAdapter adapter = new SqlDataAdapter(this.command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool ExecuteManioulationcommend(string commend)
        {
            this.command.CommandText = commend;
            this.Connection.Open();
            int i = this.command.ExecuteNonQuery();
            this.Connection.Close();
            if (i > 0)
                return true;
            return false;

        }
    }
}
