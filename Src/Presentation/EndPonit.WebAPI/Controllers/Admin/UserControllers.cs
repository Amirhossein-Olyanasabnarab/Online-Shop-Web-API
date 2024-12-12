using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.Services.Users.Queries;

namespace EndPonit.WebAPI.Controllers.Admin;

[ApiController]
[Route("/api/admin/[controller]")]
public class UserControllers : ControllerBase
{
    private readonly IGetUserService _getUserService;

    public UserControllers(IGetUserService getUserService)
    {
        _getUserService = getUserService;
    }

    [HttpGet("Index")]
    public IActionResult GetUsers([FromQuery] string searchKey, [FromQuery] int page = 1)
    {
        var result = _getUserService.Execute(new RequestGetUserDto
        {
            Page = page,
            SearchKey = searchKey
        });

        return Ok(result);
    }
}