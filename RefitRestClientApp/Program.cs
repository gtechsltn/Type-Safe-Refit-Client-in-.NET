// See https://aka.ms/new-console-template for more information
using RefitRestClientApp.Models;
using RefitRestClientApp.Services;

Console.WriteLine("Hello, World!");
var apiService = new ApiService("https://jsonplaceholder.typicode.com"); // Example API for testing


// Create a new user
var newUser = new User
{
    Name = "John Doe",
    Email = "john.doe@example.com"
};

var createdUser = await apiService.CreateUserAsync(newUser);
Console.WriteLine($"Created User: {createdUser.Id}, {createdUser.Name}, {createdUser.Email}");
createdUser.Id = createdUser.Id - 1;
// Get the user
var user = await apiService.GetUserAsync(createdUser.Id.ToString());
Console.WriteLine($"Retrieved User: {user.Id}, {user.Name}, {user.Email}");

// Update the user
user.Name = "Jane Doe";
var updatedUser = await apiService.UpdateUserAsync(user.Id.ToString(), user);
Console.WriteLine($"Updated User: {updatedUser.Id}, {updatedUser.Name}, {updatedUser.Email}");

// Delete the user
await apiService.DeleteUserAsync(user.Id.ToString());
Console.WriteLine("User deleted successfully.");