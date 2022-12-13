using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class AppControllerBase : ControllerBase
    {
    }
}
