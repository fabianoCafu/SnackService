using Microsoft.Extensions.Options;
using SnackService.Api.Integracao.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace SnackService.Api.Integracao.NovaPasta
{
    public class ViaCepClientSevice : IViaCepClient
    {
        private readonly HttpClient _httpClient;

        public ViaCepClientSevice(IOptions<AppSettings> appSettings)
        {
            _httpClient = HttpClientFactory.Create();
            _httpClient.BaseAddress = new Uri(appSettings.Value.BaseUrl);
        }

        public ViaCepResponse Search(string zipCode)
        {
            return SearchAsync(zipCode, CancellationToken.None).Result;
        }

        public IEnumerable<ViaCepResponse> Search(
            string stateInitials,
            string city,
            string address)
        {
            return SearchAsync(stateInitials, city, address, CancellationToken.None).Result;
        }

        public async Task<ViaCepResponse> SearchAsync(
            string zipCode,
            CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($"/ws/{zipCode}/json", cancellationToken)
                                            .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            return await response.Content
                                 .ReadAsAsync<ViaCepResponse>(cancellationToken)
                                 .ConfigureAwait(false);
        }

        public async Task<IEnumerable<ViaCepResponse>> SearchAsync(
            string stateInitials,
            string city,
            string address,
            CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($"/ws/{stateInitials}/{city}/{address}/json", cancellationToken)
                                            .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            return await response.Content
                                 .ReadAsAsync<List<ViaCepResponse>>(cancellationToken)
                                 .ConfigureAwait(false);
        }
    }
}

