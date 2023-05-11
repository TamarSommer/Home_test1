namespace Home_test.Api.Controllers
{
    class App
    {
        static void Main(string[] args)
        {
            // Create database if it doesn't exist
            var database = new Database();
            database.CreateDatabase();

            // Register API controllers
            var workerController = new WorkerController(database);
            var infectedPeopleController = new InfectedPeopleController(database);
            var vaccineController = new VaccineController(database);

            Console.WriteLine("Database created and API controllers registered.");
            Console.ReadLine();
        }
    }
}

