using OnlineShop.Application.Interfaces.Contexts;
using OnlineShop.Common;

namespace OnlineShop.Application.Services.Users.Queries;

public class GetUserService : IGetUserService
{
    private readonly IDataBaseContext _context;

    public GetUserService(IDataBaseContext context)
    {
        _context = context;
    }
    
    public ResultGetUserDto Execute(RequestGetUserDto request)
    {
        var users = _context.Users.AsQueryable();
        if (!string.IsNullOrEmpty(request.SearchKey))
        {
            users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
        }

        int rowsCount = 0;
        var usersList = users.ToPaged(request.Page, 20, out rowsCount)
            .Select(p => new GetUserDto
            {
                Id = p.Id,
                FullName = p.FullName,
                Email = p.Email,
            }).ToList();
        return new ResultGetUserDto()
        {
            Rows = rowsCount,
            Users = usersList
        };
    }
}