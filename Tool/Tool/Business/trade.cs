using System.Data.SqlClient;
using System.Data;
namespace Tool.Business
{
    public class TradeData
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        public TradeData()
        {
            connection = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AdventureWorks2012;server=DESKTOP-S5F17MF\\SQLEXPRESS");
        }
        public DataTable GetTrade(int entityId)
        {
            command = new SqlCommand("Select * from [Person].Person Where BusinessEntityID=@entityId",connection);
            command.Parameters.AddWithValue("@entityId", entityId);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }

}