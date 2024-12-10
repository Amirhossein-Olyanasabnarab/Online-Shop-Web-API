namespace OnlineShop.Application.Services.Users.Queries;

public class ResultGetUserDto
{
    public List<GetUserDto> Users { get; set; }
    public int Rows {get; set;}
}