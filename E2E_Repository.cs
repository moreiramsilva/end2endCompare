using Microsoft.Data.Sqlite;
namespace end2endCompare;

class E2E_Repository
{
    public static string connectionString = @"Data Source=end2end.db";

    public static void CheckTable(){

        using (var connection = new SqliteConnection(connectionString)){
            connection.Open();
            var tableCmd = connection.CreateCommand();


            tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS e2e_tpx (
                e2e_tpx varchar(35)
            )";
            tableCmd.ExecuteNonQuery();

            tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS e2e_autbank (
                e2e_autbank varchar(35)
            )";
            tableCmd.ExecuteNonQuery();
            
            connection.Close();
        }
    }

    public static void InsertE2e(string parameter, string parameter2){

        if (CheckParametro(parameter) && CheckParametro(parameter2)){
            using (var connection = new SqliteConnection(connectionString)){
                connection.Open();
                var tableCmd = connection.CreateCommand();
                var dominio = parameter2 == "TPX" ? "e2e_tpx" : "e2e_autbank";
                tableCmd.CommandText = @"INSERT INTO " +dominio+" ("+dominio+") VALUES ("+parameter+");";
                tableCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }

    public static bool CheckParametro(string parameter){
        return (parameter != null) && (parameter != "");
    }
}
