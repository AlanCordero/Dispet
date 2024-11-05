using Dispet.Models;
using MongoDB.Driver;

namespace Dispet.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserService(MongoDbService dbService)
        {
            _usersCollection = dbService.GetCollection<User>("Users");
        }

        public async Task<List<User>> GetUsersAsync() => await _usersCollection.Find(_ => true).ToListAsync();

        public async Task<User> GetUserByIdAsync(string id) => await _usersCollection.Find(u => u.Id == id).FirstOrDefaultAsync();

        public async Task AddUserAsync(User user) => await _usersCollection.InsertOneAsync(user);

        public async Task UpdateUserAsync(User user) => await _usersCollection.ReplaceOneAsync(u => u.Id == user.Id, user);

        public async Task DeleteUserAsync(string id) => await _usersCollection.DeleteOneAsync(u => u.Id == id);
    }
}
