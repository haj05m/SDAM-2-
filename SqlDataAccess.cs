using System;
using System.Data;
using System.Data.SqlClient;

public class SqlDataAccess
{
    private SqlConnection connection;

    public SqlDataAccess(string connectionString)
    {
        connection = new SqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(string query)
    {
        DataTable dataTable = new DataTable();

        try
        {
            connection.Open();
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions here
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }

        return dataTable;
    }
}

public class Program
{
    public static void MainBak()
    {
        string connectionString = "Your_Connection_String_Here";
        SqlDataAccess sqlDataAccess = new SqlDataAccess(connectionString);
        string query = "SELECT * FROM YourTable";

        DataTable result = sqlDataAccess.ExecuteQuery(query);
        int rowCount = result.Rows.Count;

        Console.WriteLine("Row Count: " + rowCount);
    }
}
