using Refit;
using RefitRestClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitRestClientApp.Services
{
    public interface IMyApi
    {
        [Get("/users/{id}")]
        Task<User> GetUserAsync(string id);

        [Post("/users")]
        Task<User> CreateUserAsync([Body] User newUser);

        [Put("/users/{id}")]
        Task<User> UpdateUserAsync(string id, [Body] User updatedUser);

        [Delete("/users/{id}")]
        Task DeleteUserAsync(string id);
    }
}
