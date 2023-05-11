using System.Data.SQLite;
using System.IO;

public class Database
{
    private const string DatabaseName = "workers.db";
    private const string ConnectionString = "Data Source=" + DatabaseName;

    public void CreateDatabase()
    {
        if (File.Exists(DatabaseName))
        {
            File.Delete(DatabaseName);
        }

        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"CREATE TABLE Workers (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL,
                                            Address TEXT NOT NULL,
                                            PhoneNumber TEXT NOT NULL,
                                            TelephoneNumber TEXT NOT NULL,
                                            DateOfBirth TEXT NOT NULL
                                        );
                                        CREATE TABLE InfectedPeople (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            DateOfPositiveResult TEXT NOT NULL,
                                            DateOfRecovery TEXT NOT NULL
                                        );
                                        CREATE TABLE Vaccines (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            WorkerId INTEGER NOT NULL,
                                            Manufacturer TEXT NOT NULL,
                                            DateGiven TEXT NOT NULL,
                                            FOREIGN KEY(WorkerId) REFERENCES Workers(Id)
                                        );";
                command.ExecuteNonQuery();
            }
        }
    }

    public SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(ConnectionString);
    }
}
