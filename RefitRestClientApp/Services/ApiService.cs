using Refit;
using RefitRestClientApp.Models;

namespace RefitRestClientApp.Services
{
    public class ApiService
    {
        private readonly IMyApi _api;

        public ApiService(string baseUrl)
        {
            _api = RestService.For<IMyApi>(baseUrl);
        }

        public async Task<User> GetUserAsync(string id)
        {
            var user=new User();
            try
            {
                return await _api.GetUserAsync(id);
            }
            catch (Exception ex) 
            {
                return user;
            }

        }

        public async Task<User> CreateUserAsync(User newUser)
        {
            return await _api.CreateUserAsync(newUser);
        }

        public async Task<User> UpdateUserAsync(string id, User updatedUser)
        {
            return await _api.UpdateUserAsync(id, updatedUser);
        }

        public async Task DeleteUserAsync(string id)
        {
            await _api.DeleteUserAsync(id);
        }
    }
}
