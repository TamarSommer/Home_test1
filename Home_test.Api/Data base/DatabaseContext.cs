using System.Data.SQLite;


namespace Home_test.Api.Data_base
{
    public class DatabaseContext
    {
        private readonly string connectionString;

        public DatabaseContext(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeDatabase();
        }

        public void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create table for Infected class
                using (var command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Infected (" +
                    "Id INTEGER PRIMARY KEY," +
                    "Positive DATETIME," +
                    "Recovery DATETIME" +
                    ")", connection))
                {
                    command.ExecuteNonQuery();
                }

                // Create table for Person class
                using (var command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Person (" +
                    "Id INTEGER PRIMARY KEY," +
                    "Name TEXT," +
                    "Address TEXT," +
                    "Birthdate DATETIME," +
                    "PhoneNumber TEXT," +
                    "TelephoneNumber TEXT" +
                    ")", connection))
                {
                    command.ExecuteNonQuery();
                }

                // Create table for Vaccinated class
                using (var command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Vaccinated (" +
                    "Id INTEGER PRIMARY KEY," +
                    "PersonId INTEGER," +
                    "FOREIGN KEY (PersonId) REFERENCES Person (Id)" +
                    ")", connection))
                {
                    command.ExecuteNonQuery();
                }

                // Create table for Vaccine class
                using (var command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Vaccine (" +
                    "Id INTEGER PRIMARY KEY," +
                    "PersonId INTEGER," +
                    "Manufacturer TEXT," +
                    "Given DATETIME," +
                    "FOREIGN KEY (PersonId) REFERENCES Person (Id)" +
                    ")", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}

