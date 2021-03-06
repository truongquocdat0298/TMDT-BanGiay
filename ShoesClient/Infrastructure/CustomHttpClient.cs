﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ShoesClient.Helper;
using ShoesClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShoesClient.Infrastructure
{
    public class CustomHttpClient:IHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly HttpContext _httpContext;

        public CustomHttpClient(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContext = httpContextAccessor.HttpContext;
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(string uri) where T : class
        {
            await AttachTokenToHttpMessage();

            var responseString = await _httpClient.GetStringAsync(uri);

            return JsonConvert.DeserializeObject<IEnumerable<T>>(responseString);

        }

        public async Task<T> GetAsync<T>(string uri) where T : class
        {
            await AttachTokenToHttpMessage();

            var responseString = await _httpClient.GetStringAsync(uri);

            return JsonConvert.DeserializeObject<T>(responseString);

        }

        public async Task PostAsync(string uri, object entity)
        {
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");

            await AttachTokenToHttpMessage();

            var response = await _httpClient.PostAsync(uri, content);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception($"Error in Creating {entity.GetType().Name}, try later");
            }

            response.EnsureSuccessStatusCode();
        }

        public async Task PutAsync(string uri, object entity)
        {
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");

            await AttachTokenToHttpMessage();

            var response = await _httpClient.PutAsync(uri, content);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception("Error in Udpating {entity.GetType().Name}, try later");
            }

            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(string uri)
        {
            await AttachTokenToHttpMessage();

            var response = await _httpClient.DeleteAsync(uri);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception($"Error in deleting object, try later");
            }

            response.EnsureSuccessStatusCode();
        }

        private async Task AttachTokenToHttpMessage()
        {
            var auth = _httpContext.Session.GetObjectFromJson<AuthenticateModel>("JWToken");
            if(auth!=default)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth.access_token);
            }
           
        }
    }
}
