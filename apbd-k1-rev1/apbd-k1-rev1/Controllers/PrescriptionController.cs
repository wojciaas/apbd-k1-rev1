using apbd_k1_rev1.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_k1_rev1.Controllers;

[ApiController]
[Route("api/prescriptions")]
public class PrescriptionController : ControllerBase
{
    private readonly IPrescriptionService _prescriptionService;

    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetPrescriptionsAsync(string? doctorLastName)
    {
        return Ok();
    }
}