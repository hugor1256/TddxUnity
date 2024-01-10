using FormulaApp.Api.Models;

namespace FormulaApp.Api.Services.Interfaces;

public interface IFanServices
{
    Task<List<Fan>> GetAllFans();
}