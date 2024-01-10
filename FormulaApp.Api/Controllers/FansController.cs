using FormulaApp.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FansController : ControllerBase
{
    private readonly IFanServices _fanServices;

    public FansController(IFanServices fanServices)
    {
        _fanServices = fanServices;
    }

    [HttpGet(Name = "GetFans")]
    public async Task<IActionResult> Get()
    {
        var fans = await _fanServices.GetAllFans();
        return Ok(fans);
    }
}