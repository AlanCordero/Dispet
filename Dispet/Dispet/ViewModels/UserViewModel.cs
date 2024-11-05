using Dispet.Models;
using Dispet.Services;

namespace Dispet.ViewModels
{
    public class UserViewModel
    {
        private readonly UserService _userService;
        public List<User> Users { get; private set; } = new();

        public UserViewModel(UserService userService)
        {
            _userService = userService;
        }

        public async Task LoadUsersAsync()
        {
            Users = await _userService.GetUsersAsync();
        }

        public async Task AddUserAsync(User user)
        {
            await _userService.AddUserAsync(user);
            await LoadUsersAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userService.UpdateUserAsync(user);
            await LoadUsersAsync();
        }

        public async Task DeleteUserAsync(string id)
        {
            await _userService.DeleteUserAsync(id);
            await LoadUsersAsync();
        }
    }
}
