﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trackademia_PDC50.Model;
using System.Net.Http.Json;

namespace Trackademia_PDC50.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost/pdc50/";
        public UserService() 
        {
            _httpClient = new HttpClient();
        }

        //GetFromJsonAsync - method to call HTTP GET
        //PostAsJsonAsync - method to call HTTP POST
        //ReadAsStringAsync - method to read the content of HTTPContent

        //Get User
        public async Task<List<User>> GetUsersAsync()
        {
            var response = 
                await _httpClient.GetFromJsonAsync<List<User>>($"{BaseUrl}get_user.php");
            return response ?? new List<User>();
        }

        //Add User
        public async Task<string>AddUserAsync(User user)
        {
            var response = 
                await _httpClient.PostAsJsonAsync($"{BaseUrl}add_user.php", user);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        //update User
        public async Task<string> UpdateUserAsync(User user)
        {
            var response =
                await _httpClient.PostAsJsonAsync($"{BaseUrl}update_user.php", user);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        //Delete User
        public async Task<string> DeleteUserAsync(int userId)
        {
            var response =
                await _httpClient.PostAsJsonAsync($"{BaseUrl}delete_user.php", new {id = userId});
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
