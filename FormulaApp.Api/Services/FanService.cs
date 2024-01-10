using FormulaApp.Api.Models;
using FormulaApp.Api.Services.Interfaces;

namespace FormulaApp.Api.Services;

public class FanService : IFanServices
{

    private readonly HttpClient _httpClient;

    public FanService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }


    public async Task<List<Fan>> GetAllFans()
    {
        throw new NotImplementedException();
    }
}