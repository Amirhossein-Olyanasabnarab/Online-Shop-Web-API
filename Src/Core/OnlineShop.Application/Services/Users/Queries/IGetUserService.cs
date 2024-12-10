namespace OnlineShop.Application.Services.Users.Queries;

public interface IGetUserService
{
    ResultGetUserDto Execute(RequestGetUserDto request);
}