using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace SnackService.Api.Integracao.Interface
{
    public interface IViaCepClient
    {
        ViaCepResponse Search(string zipCode); 
        IEnumerable<ViaCepResponse> Search(string stateInitials, string city, string address);
        Task<ViaCepResponse> SearchAsync(string zipCode, CancellationToken cancellationToken);
        Task<IEnumerable<ViaCepResponse>> SearchAsync(string stateInitials, string city, string address, CancellationToken cancellationToken);
    }
}
