using MongoDB.Driver;

namespace Dispet.Services
{
    public class MongoDbService
    {
        private readonly IMongoDatabase _database;

        public MongoDbService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDB"));
            _database = client.GetDatabase("DispetDB");
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
