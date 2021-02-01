using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.ViewModels;

namespace LibrarySystem.Application.Services
{
    public class AnswersService :IAnswersService
    {
        private readonly IHttpClientFactory _clientFactory;

        public AnswersService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<AnswersModel> GetAnswers()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "/2.2/answers?order=desc&sort=activity&site=stackoverflow");
            var client = _clientFactory.CreateClient("StackOverFlowClient");
            var response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode) return new AnswersModel();
            var answers = await response.Content.ReadAsStreamAsync();
            if (answers != null) await JsonSerializer.DeserializeAsync<IEnumerable<AnswersModel>>(answers);
            return new AnswersModel();
            
        }
    }
}
